namespace Samyang_135mm_Focuser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStepsHome = new System.Windows.Forms.Label();
            this.lblSigStrength = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLeft3 = new System.Windows.Forms.Button();
            this.btnLeft2 = new System.Windows.Forms.Button();
            this.btnLeft1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRight1 = new System.Windows.Forms.Button();
            this.btnRight2 = new System.Windows.Forms.Button();
            this.btnRight3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backlashSteps = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStepSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStepSize = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStepSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(6, 21);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(125, 23);
            this.btnDetect.TabIndex = 0;
            this.btnDetect.Text = "Scan Focuser";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Enabled = false;
            this.btnConnection.Location = new System.Drawing.Point(137, 21);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(125, 23);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblStepsHome);
            this.groupBox1.Controls.Add(this.lblSigStrength);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDetect);
            this.groupBox1.Controls.Add(this.btnConnection);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Focuser Information";
            // 
            // lblStepsHome
            // 
            this.lblStepsHome.AutoSize = true;
            this.lblStepsHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStepsHome.Location = new System.Drawing.Point(140, 99);
            this.lblStepsHome.Name = "lblStepsHome";
            this.lblStepsHome.Size = new System.Drawing.Size(26, 16);
            this.lblStepsHome.TabIndex = 9;
            this.lblStepsHome.Text = "NA";
            // 
            // lblSigStrength
            // 
            this.lblSigStrength.AutoSize = true;
            this.lblSigStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSigStrength.Location = new System.Drawing.Point(140, 83);
            this.lblSigStrength.Name = "lblSigStrength";
            this.lblSigStrength.Size = new System.Drawing.Size(26, 16);
            this.lblSigStrength.TabIndex = 8;
            this.lblSigStrength.Text = "NA";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(140, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 16);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "NA";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblName.Location = new System.Drawing.Point(140, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "NA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Signal Strength (db):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Steps From Home:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Focuser ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Focuser Name:";
            // 
            // btnLeft3
            // 
            this.btnLeft3.Location = new System.Drawing.Point(6, 140);
            this.btnLeft3.Name = "btnLeft3";
            this.btnLeft3.Size = new System.Drawing.Size(50, 50);
            this.btnLeft3.TabIndex = 3;
            this.btnLeft3.Text = "<<<";
            this.btnLeft3.UseVisualStyleBackColor = true;
            this.btnLeft3.Click += new System.EventHandler(this.btnLeft3_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Location = new System.Drawing.Point(62, 140);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(50, 50);
            this.btnLeft2.TabIndex = 4;
            this.btnLeft2.Text = "<<";
            this.btnLeft2.UseVisualStyleBackColor = true;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // btnLeft1
            // 
            this.btnLeft1.Location = new System.Drawing.Point(118, 140);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(50, 50);
            this.btnLeft1.TabIndex = 5;
            this.btnLeft1.Text = "<";
            this.btnLeft1.UseVisualStyleBackColor = true;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(174, 130);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 70);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRight1
            // 
            this.btnRight1.Location = new System.Drawing.Point(250, 140);
            this.btnRight1.Name = "btnRight1";
            this.btnRight1.Size = new System.Drawing.Size(50, 50);
            this.btnRight1.TabIndex = 7;
            this.btnRight1.Text = ">";
            this.btnRight1.UseVisualStyleBackColor = true;
            this.btnRight1.Click += new System.EventHandler(this.btnRight1_Click);
            // 
            // btnRight2
            // 
            this.btnRight2.Location = new System.Drawing.Point(306, 140);
            this.btnRight2.Name = "btnRight2";
            this.btnRight2.Size = new System.Drawing.Size(50, 50);
            this.btnRight2.TabIndex = 8;
            this.btnRight2.Text = ">>";
            this.btnRight2.UseVisualStyleBackColor = true;
            this.btnRight2.Click += new System.EventHandler(this.btnRight2_Click);
            // 
            // btnRight3
            // 
            this.btnRight3.Location = new System.Drawing.Point(362, 140);
            this.btnRight3.Name = "btnRight3";
            this.btnRight3.Size = new System.Drawing.Size(50, 50);
            this.btnRight3.TabIndex = 9;
            this.btnRight3.Text = ">>>";
            this.btnRight3.UseVisualStyleBackColor = true;
            this.btnRight3.Click += new System.EventHandler(this.btnRight3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.backlashSteps);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblStepSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnLeft3);
            this.groupBox2.Controls.Add(this.btnRight3);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.btnRight2);
            this.groupBox2.Controls.Add(this.btnLeft1);
            this.groupBox2.Controls.Add(this.btnRight1);
            this.groupBox2.Controls.Add(this.btnLeft2);
            this.groupBox2.Controls.Add(this.tbStepSize);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 206);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Focuser Control";
            // 
            // backlashSteps
            // 
            this.backlashSteps.Location = new System.Drawing.Point(184, 27);
            this.backlashSteps.Name = "backlashSteps";
            this.backlashSteps.Size = new System.Drawing.Size(33, 22);
            this.backlashSteps.TabIndex = 14;
            this.backlashSteps.Text = "48";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Backlash Step Correction";
            // 
            // lblStepSize
            // 
            this.lblStepSize.AutoSize = true;
            this.lblStepSize.Location = new System.Drawing.Point(362, 71);
            this.lblStepSize.Name = "lblStepSize";
            this.lblStepSize.Size = new System.Drawing.Size(21, 16);
            this.lblStepSize.TabIndex = 12;
            this.lblStepSize.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Base Step Size";
            // 
            // tbStepSize
            // 
            this.tbStepSize.Location = new System.Drawing.Point(114, 68);
            this.tbStepSize.Maximum = 40;
            this.tbStepSize.Name = "tbStepSize";
            this.tbStepSize.Size = new System.Drawing.Size(242, 56);
            this.tbStepSize.TabIndex = 10;
            this.tbStepSize.TickFrequency = 5;
            this.tbStepSize.Value = 10;
            this.tbStepSize.Scroll += new System.EventHandler(this.tbStepSize_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Location = new System.Drawing.Point(12, 381);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 210);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Focuser Status Messages";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(7, 22);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(404, 182);
            this.txtStatus.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Samyang 135mm Focuser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStepSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeft3;
        private System.Windows.Forms.Button btnLeft2;
        private System.Windows.Forms.Button btnLeft1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRight1;
        private System.Windows.Forms.Button btnRight2;
        private System.Windows.Forms.Button btnRight3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStepSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbStepSize;
        private System.Windows.Forms.Label lblStepsHome;
        private System.Windows.Forms.Label lblSigStrength;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox backlashSteps;
        private System.Windows.Forms.Label label2;
    }
}

