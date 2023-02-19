using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;

// Create a NightMode Button to change colorscheme

namespace Samyang_135mm_Focuser
{
    public partial class Form1 : Form
    {

        private BluetoothLEAdvertisementWatcher adWatcher = null;
        private DeviceWatcher deviceWatcher = null;

        public BluetoothLEDevice bluetoothLEDevice = null;
        public GattDeviceServicesResult result { get; set; }
        public DeviceInformation device = null;
        public GattCharacteristic selectedCharacteristic = null;
        public GattDeviceService selectedService = null;

        private string focuserName = "Samyang 135mm Focuser";
        public string focuserServiceId = "0000";

        private string[] deviceInfo = null;
        private bool scanStatusState = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        #region BLE Connection

        private void BLE_StartScanner()
        {
                                    
            if (adWatcher == null)  // Check if there is an adWatcher object
            {
                StartNewScan();
                adWatcher = new BluetoothLEAdvertisementWatcher();

                adWatcher.ScanningMode = BluetoothLEScanningMode.Active;
                adWatcher.Received += OnAdvertisementReceived;

                adWatcher.SignalStrengthFilter.OutOfRangeTimeout = TimeSpan.FromMilliseconds(1000);
                adWatcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(1000);

                SendStatusMessage("Starting BLE Scanner");  // Status Message for Starting the BLE Scanner

                adWatcher.Start();
                
            }
            else
            {
                if (adWatcher.Status.ToString() == "Stopped")
                {
                    StartNewScan();
                    SendStatusMessage("Starting BLE Scanner");
                    adWatcher.Start();
                }
            }
        }

        private async void BLE_Connection() {

            if (bluetoothLEDevice == null)
            {
                SendStatusMessage("Connecting to " + deviceInfo[0]);

                string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected" };


                deviceWatcher = DeviceInformation.CreateWatcher(
                    BluetoothLEDevice.GetDeviceSelectorFromPairingState(false),
                    requestedProperties,
                    DeviceInformationKind.AssociationEndpoint);

                deviceWatcher.Added += DeviceWatcher_Added;
                deviceWatcher.Updated += DeviceWatcher_Updated;
                deviceWatcher.Removed += DeviceWatcher_Removed;

                deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
                deviceWatcher.Stopped += DeviceWatcher_Stopped;

                deviceWatcher.Start();

                while (true)
                {
                    if (device == null)
                    {
                        Thread.Sleep(200);
                    }
                    else
                    {
                        bluetoothLEDevice = await BluetoothLEDevice.FromIdAsync(device.Id);
                        result = await bluetoothLEDevice.GetGattServicesAsync();

                        if (result.Status == GattCommunicationStatus.Success)
                        {
                            SendStatusMessage(deviceInfo[0] + " Connected");
                            btnConnection.Text = "Disconnect";
                            btnDetect.Enabled = false;
                            groupBox2.Enabled = true;
                            SetReadNotifications("2b61");
                        }
                        break;
                    }
                }
            }
            else
            {
                selectedCharacteristic.ValueChanged -= Characteristic_ValueChanged;

                foreach (var service in result.Services)
                {
                    service.Dispose();
                }

                bluetoothLEDevice.Dispose();
                bluetoothLEDevice = null;
                deviceWatcher = null;
                SendStatusMessage(deviceInfo[0] + " Disconnected");
                btnConnection.Text = "Connect";
                btnDetect.Enabled= true;
                groupBox2.Enabled= false;
            }
        }

        private async void WriteCharacteristic (string CharId, byte commandString)
        {
            var services = result.Services;

            foreach (var service in services)
            {
                if (service.Uuid.ToString("N").Substring(4,4) == focuserServiceId)
                {
                    GattCharacteristicsResult characteristicResult = await service.GetCharacteristicsAsync();
                    if (characteristicResult.Status == GattCommunicationStatus.Success)
                    {
                        var characteristics = characteristicResult.Characteristics;
                        foreach (var characteristic in characteristics)
                        {
                            GattCharacteristicProperties properties = characteristic.CharacteristicProperties;

                            if (properties.HasFlag(GattCharacteristicProperties.Write))
                            {
                                if (characteristic.Uuid.ToString("N").Substring(4,4) == CharId)
                                {
                                    var writer = new DataWriter();
                                    writer.WriteByte(commandString);

                                    GattCommunicationStatus status = await characteristic.WriteValueAsync(writer.DetachBuffer());
                                }
                            }
                        }
                    }
                }
            }
        }

        

        private async void SetReadNotifications(string CharId)
        {
            var services = result.Services;

            foreach (var service in services)
            {
                if (service.Uuid.ToString("N").Substring(4, 4) == focuserServiceId)
                {
                    GattCharacteristicsResult characteristicResult = await service.GetCharacteristicsAsync();
                    if (characteristicResult.Status == GattCommunicationStatus.Success)
                    {
                        var characteristics = characteristicResult.Characteristics;
                        foreach (var characteristic in characteristics)
                        {
                            GattCharacteristicProperties properties = characteristic.CharacteristicProperties;

                            if (properties.HasFlag(GattCharacteristicProperties.Read))
                            {
                                if (characteristic.Uuid.ToString("N").Substring(4, 4) == CharId)
                                {
                                    selectedCharacteristic = characteristic;
                                    GattCommunicationStatus status = await selectedCharacteristic.WriteClientCharacteristicConfigurationDescriptorAsync(
                                        GattClientCharacteristicConfigurationDescriptorValue.Notify);
                                    if (status == GattCommunicationStatus.Success)
                                    {
                                        SendStatusMessage("Focuser Position Notification Set"); // Server has been informed of clients interest.
                                    }
                                    characteristic.ValueChanged += Characteristic_ValueChanged;                                   
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Characteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            SendStatusMessage("Move Command Complete");
            var reader = DataReader.FromBuffer(args.CharacteristicValue);
            byte[] input = new byte[reader.UnconsumedBufferLength];
            reader.ReadBytes(input);

            int i = BitConverter.ToInt32(input, 0);
            lblStepsHome.Text = i.ToString();
            groupBox2.Enabled = true;
        }

        private void DeviceWatcher_Stopped(DeviceWatcher sender, object args)
        {
            
        }

        private void DeviceWatcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {
            
        }

        private void DeviceWatcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            
        }

        private void DeviceWatcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            
        }

        private void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            if (args.Name == deviceInfo[0])
            {
                device = args;
            }
        }

        private void SendStatusMessage(string message)
        {
            string messageLine = GetTimestamp(DateTime.Now) + ": " + message + "\r\n";
            txtStatus.Text += messageLine;
            txtStatus.SelectionStart = txtStatus.Text.Length;
            txtStatus.ScrollToCaret();
        }

        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void OnAdvertisementReceived(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args)
        {
            string deviceBuffer = args.Advertisement.LocalName;

            if (deviceBuffer != string.Empty)
            {
                string[] adInfo = { deviceBuffer, args.BluetoothAddress.ToString(), args.RawSignalStrengthInDBm.ToString() };
        
                if (adInfo[0].ToString() == focuserName)
                {
                    deviceInfo = adInfo;
                    SetDeviceInformation(adInfo);
                    if (scanStatusState == false)
                    {
                        SendStatusMessage("Focuser Device Found");
                        scanStatusState = true;
                        btnConnection.Enabled = true;
                        adWatcher.Stop();
                        btnDetect.Text = "Rescan Focuser";
                    }
                }

            }
        }

        private void SetDeviceInformation(string[] adInfo)
        {
            lblName.Text = adInfo[0].ToString();
            lblID.Text = adInfo[1].ToString();
            lblSigStrength.Text = adInfo[2].ToString();
        }

        private void StartNewScan()
        {
            // txtStatus.Text = "";            // Clear Status Text Box
            scanStatusState = false;        // Clear Status State Flag to Print First Device Message
            btnConnection.Enabled = false;
            groupBox2.Enabled = false;
            lblName.Text = "Scanning";
            lblID.Text = "Scanning";
            lblSigStrength.Text = "Scanning";
        }

        #endregion

        private byte getNumberOfSteps(int multiplier)
        {
            int numSteps = multiplier * Convert.ToInt32(lblStepSize.Text);
            return Convert.ToByte(numSteps);
        }
        private void executeMoveCommand(byte cmd, byte dir, int multiplier)
        {
            groupBox2.Enabled = false;
            byte numSteps = getNumberOfSteps(multiplier);
            WriteCharacteristic("2a59", dir);
            WriteCharacteristic("2b60", numSteps);              // Set Number of Steps for the Focus Motor to Move
            WriteCharacteristic("2a57", cmd);

            SendStatusMessage("0x01-" + dir + "-" + numSteps + " : Processing");
        }


        #region Button Click Functions

        private void btnDetect_Click(object sender, EventArgs e)
        {
            BLE_StartScanner();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            BLE_Connection();
        }

        private void tbStepSize_Scroll(object sender, EventArgs e)
        {
            lblStepSize.Text = tbStepSize.Value.ToString();
        }

        private void btnLeft3_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x01, 5);
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x01, 3);
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x01, 1);
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x02, 1);
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x02, 3);
        }

        private void btnRight3_Click(object sender, EventArgs e)
        {
            executeMoveCommand(0x01, 0x02, 5);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            WriteCharacteristic("2a57", 0x02);
        }


        #endregion
    }
}
