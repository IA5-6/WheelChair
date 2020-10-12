namespace WheelChairHMI
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.dataGridViewAlarms = new System.Windows.Forms.DataGridView();
            this.lblAlarms = new System.Windows.Forms.Label();
            this.picBoxBwd = new System.Windows.Forms.PictureBox();
            this.picBoxRight = new System.Windows.Forms.PictureBox();
            this.picBoxLeft = new System.Windows.Forms.PictureBox();
            this.picBoxFwd = new System.Windows.Forms.PictureBox();
            this.lblFwd = new System.Windows.Forms.Label();
            this.zone1 = new System.Windows.Forms.Button();
            this.zone4 = new System.Windows.Forms.Button();
            this.zone3 = new System.Windows.Forms.Button();
            this.zone2 = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.btnUpdateAlarms = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.picBoxAlarm = new System.Windows.Forms.PictureBox();
            this.btnAckAlarms = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.tabSetitngs = new System.Windows.Forms.TabPage();
            this.btnSerialConnect = new System.Windows.Forms.Button();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrLogData = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateAlarms = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateData = new System.Windows.Forms.Timer(this.components);
            this.tmrAlarmActive = new System.Windows.Forms.Timer(this.components);
            this.btnEnableDriving = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFwd)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).BeginInit();
            this.tabSetitngs.SuspendLayout();
            this.tabData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabSetitngs);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dataGridViewAlarms);
            this.tabMain.Controls.Add(this.lblAlarms);
            this.tabMain.Controls.Add(this.picBoxBwd);
            this.tabMain.Controls.Add(this.picBoxRight);
            this.tabMain.Controls.Add(this.picBoxLeft);
            this.tabMain.Controls.Add(this.picBoxFwd);
            this.tabMain.Controls.Add(this.lblFwd);
            this.tabMain.Controls.Add(this.zone1);
            this.tabMain.Controls.Add(this.zone4);
            this.tabMain.Controls.Add(this.zone3);
            this.tabMain.Controls.Add(this.zone2);
            this.tabMain.Controls.Add(this.groupBoxControls);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(2);
            this.tabMain.Size = new System.Drawing.Size(806, 533);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main menu";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAlarms
            // 
            this.dataGridViewAlarms.AllowUserToAddRows = false;
            this.dataGridViewAlarms.AllowUserToDeleteRows = false;
            this.dataGridViewAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarms.Location = new System.Drawing.Point(159, 296);
            this.dataGridViewAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.ReadOnly = true;
            this.dataGridViewAlarms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewAlarms.Size = new System.Drawing.Size(645, 234);
            this.dataGridViewAlarms.TabIndex = 21;
            // 
            // lblAlarms
            // 
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarms.Location = new System.Drawing.Point(160, 274);
            this.lblAlarms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(153, 24);
            this.lblAlarms.TabIndex = 20;
            this.lblAlarms.Text = "Alarm overview";
            // 
            // picBoxBwd
            // 
            this.picBoxBwd.Image = global::WheelChairHMI.Properties.Resources.ArrowBackward;
            this.picBoxBwd.Location = new System.Drawing.Point(412, 184);
            this.picBoxBwd.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxBwd.Name = "picBoxBwd";
            this.picBoxBwd.Size = new System.Drawing.Size(45, 62);
            this.picBoxBwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxBwd.TabIndex = 19;
            this.picBoxBwd.TabStop = false;
            this.picBoxBwd.Visible = false;
            // 
            // picBoxRight
            // 
            this.picBoxRight.Image = global::WheelChairHMI.Properties.Resources.ArrowRight;
            this.picBoxRight.Location = new System.Drawing.Point(476, 99);
            this.picBoxRight.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxRight.Name = "picBoxRight";
            this.picBoxRight.Size = new System.Drawing.Size(62, 45);
            this.picBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxRight.TabIndex = 18;
            this.picBoxRight.TabStop = false;
            this.picBoxRight.Visible = false;
            // 
            // picBoxLeft
            // 
            this.picBoxLeft.Image = global::WheelChairHMI.Properties.Resources.ArrowLeft;
            this.picBoxLeft.Location = new System.Drawing.Point(331, 99);
            this.picBoxLeft.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxLeft.Name = "picBoxLeft";
            this.picBoxLeft.Size = new System.Drawing.Size(62, 45);
            this.picBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLeft.TabIndex = 17;
            this.picBoxLeft.TabStop = false;
            this.picBoxLeft.Visible = false;
            // 
            // picBoxFwd
            // 
            this.picBoxFwd.Image = global::WheelChairHMI.Properties.Resources.ArrowForward;
            this.picBoxFwd.Location = new System.Drawing.Point(411, 32);
            this.picBoxFwd.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxFwd.Name = "picBoxFwd";
            this.picBoxFwd.Size = new System.Drawing.Size(46, 63);
            this.picBoxFwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFwd.TabIndex = 16;
            this.picBoxFwd.TabStop = false;
            this.picBoxFwd.Visible = false;
            // 
            // lblFwd
            // 
            this.lblFwd.AutoSize = true;
            this.lblFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFwd.Location = new System.Drawing.Point(386, 5);
            this.lblFwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFwd.Name = "lblFwd";
            this.lblFwd.Size = new System.Drawing.Size(97, 25);
            this.lblFwd.TabIndex = 15;
            this.lblFwd.Text = "Forward";
            // 
            // zone1
            // 
            this.zone1.BackColor = System.Drawing.Color.White;
            this.zone1.Enabled = false;
            this.zone1.FlatAppearance.BorderSize = 0;
            this.zone1.Location = new System.Drawing.Point(397, 99);
            this.zone1.Margin = new System.Windows.Forms.Padding(2);
            this.zone1.Name = "zone1";
            this.zone1.Size = new System.Drawing.Size(75, 81);
            this.zone1.TabIndex = 14;
            this.zone1.Text = "Zone 1";
            this.zone1.UseVisualStyleBackColor = false;
            // 
            // zone4
            // 
            this.zone4.BackColor = System.Drawing.Color.White;
            this.zone4.Enabled = false;
            this.zone4.Location = new System.Drawing.Point(331, 250);
            this.zone4.Margin = new System.Windows.Forms.Padding(2);
            this.zone4.Name = "zone4";
            this.zone4.Size = new System.Drawing.Size(207, 24);
            this.zone4.TabIndex = 13;
            this.zone4.Text = "Zone 4";
            this.zone4.UseVisualStyleBackColor = false;
            // 
            // zone3
            // 
            this.zone3.BackColor = System.Drawing.Color.White;
            this.zone3.Enabled = false;
            this.zone3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zone3.Location = new System.Drawing.Point(470, 32);
            this.zone3.Margin = new System.Windows.Forms.Padding(2);
            this.zone3.Name = "zone3";
            this.zone3.Size = new System.Drawing.Size(68, 57);
            this.zone3.TabIndex = 12;
            this.zone3.Text = "Zone 3";
            this.zone3.UseVisualStyleBackColor = false;
            // 
            // zone2
            // 
            this.zone2.BackColor = System.Drawing.Color.White;
            this.zone2.Enabled = false;
            this.zone2.Location = new System.Drawing.Point(331, 32);
            this.zone2.Margin = new System.Windows.Forms.Padding(2);
            this.zone2.Name = "zone2";
            this.zone2.Size = new System.Drawing.Size(68, 57);
            this.zone2.TabIndex = 11;
            this.zone2.Text = "Zone 2";
            this.zone2.UseVisualStyleBackColor = false;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.btnUpdateAlarms);
            this.groupBoxControls.Controls.Add(this.button1);
            this.groupBoxControls.Controls.Add(this.btnTest);
            this.groupBoxControls.Controls.Add(this.picBoxAlarm);
            this.groupBoxControls.Controls.Add(this.btnAckAlarms);
            this.groupBoxControls.Controls.Add(this.btnDisable);
            this.groupBoxControls.Controls.Add(this.btnEnableDriving);
            this.groupBoxControls.Location = new System.Drawing.Point(4, 5);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxControls.Size = new System.Drawing.Size(150, 525);
            this.groupBoxControls.TabIndex = 10;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // btnUpdateAlarms
            // 
            this.btnUpdateAlarms.Location = new System.Drawing.Point(4, 89);
            this.btnUpdateAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAlarms.Name = "btnUpdateAlarms";
            this.btnUpdateAlarms.Size = new System.Drawing.Size(141, 19);
            this.btnUpdateAlarms.TabIndex = 7;
            this.btnUpdateAlarms.Text = "Update Alarms";
            this.btnUpdateAlarms.UseVisualStyleBackColor = true;
            this.btnUpdateAlarms.Click += new System.EventHandler(this.btnUpdateAlarms_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(44, 290);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(56, 19);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test alarm";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // picBoxAlarm
            // 
            this.picBoxAlarm.Image = global::WheelChairHMI.Properties.Resources.Alarm;
            this.picBoxAlarm.Location = new System.Drawing.Point(17, 126);
            this.picBoxAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxAlarm.Name = "picBoxAlarm";
            this.picBoxAlarm.Size = new System.Drawing.Size(115, 58);
            this.picBoxAlarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxAlarm.TabIndex = 4;
            this.picBoxAlarm.TabStop = false;
            this.picBoxAlarm.Visible = false;
            // 
            // btnAckAlarms
            // 
            this.btnAckAlarms.Location = new System.Drawing.Point(4, 65);
            this.btnAckAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.btnAckAlarms.Name = "btnAckAlarms";
            this.btnAckAlarms.Size = new System.Drawing.Size(141, 19);
            this.btnAckAlarms.TabIndex = 3;
            this.btnAckAlarms.Text = "Acknowledge all alarms";
            this.btnAckAlarms.UseVisualStyleBackColor = true;
            this.btnAckAlarms.Click += new System.EventHandler(this.btnAckAlarms_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(4, 41);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(141, 19);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable driving";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // tabSetitngs
            // 
            this.tabSetitngs.Controls.Add(this.btnSerialConnect);
            this.tabSetitngs.Controls.Add(this.cboComPort);
            this.tabSetitngs.Controls.Add(this.lblSerialPort);
            this.tabSetitngs.Location = new System.Drawing.Point(4, 22);
            this.tabSetitngs.Margin = new System.Windows.Forms.Padding(2);
            this.tabSetitngs.Name = "tabSetitngs";
            this.tabSetitngs.Padding = new System.Windows.Forms.Padding(2);
            this.tabSetitngs.Size = new System.Drawing.Size(806, 533);
            this.tabSetitngs.TabIndex = 1;
            this.tabSetitngs.Text = "Settings";
            this.tabSetitngs.UseVisualStyleBackColor = true;
            // 
            // btnSerialConnect
            // 
            this.btnSerialConnect.Location = new System.Drawing.Point(16, 48);
            this.btnSerialConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSerialConnect.Name = "btnSerialConnect";
            this.btnSerialConnect.Size = new System.Drawing.Size(91, 19);
            this.btnSerialConnect.TabIndex = 2;
            this.btnSerialConnect.Text = "Connect";
            this.btnSerialConnect.UseVisualStyleBackColor = true;
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(16, 26);
            this.cboComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(92, 21);
            this.cboComPort.TabIndex = 1;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(16, 15);
            this.lblSerialPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(82, 13);
            this.lblSerialPort.TabIndex = 0;
            this.lblSerialPort.Text = "Serial Port---------";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.groupBox1);
            this.tabData.Controls.Add(this.dgvData);
            this.tabData.Controls.Add(this.label7);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Margin = new System.Windows.Forms.Padding(2);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(806, 533);
            this.tabData.TabIndex = 4;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateData);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 520);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data controller";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(4, 15);
            this.btnUpdateData.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(141, 19);
            this.btnUpdateData.TabIndex = 0;
            this.btnUpdateData.Text = "Update data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(159, 22);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(650, 510);
            this.dgvData.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "All the data stored in the database";
            // 
            // tmrLogData
            // 
            this.tmrLogData.Interval = 15000;
            this.tmrLogData.Tick += new System.EventHandler(this.tmrLogData_Tick);
            // 
            // tmrUpdateAlarms
            // 
            this.tmrUpdateAlarms.Interval = 1000;
            this.tmrUpdateAlarms.Tick += new System.EventHandler(this.tmrUpdateAlarms_Tick);
            // 
            // tmrUpdateData
            // 
            this.tmrUpdateData.Interval = 1000;
            this.tmrUpdateData.Tick += new System.EventHandler(this.tmrUpdateData_Tick);
            // 
            // tmrAlarmActive
            // 
            this.tmrAlarmActive.Tick += new System.EventHandler(this.tmrAlarmActive_Tick);
            // 
            // btnEnableDriving
            // 
            this.btnEnableDriving.Location = new System.Drawing.Point(4, 18);
            this.btnEnableDriving.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnableDriving.Name = "btnEnableDriving";
            this.btnEnableDriving.Size = new System.Drawing.Size(141, 19);
            this.btnEnableDriving.TabIndex = 0;
            this.btnEnableDriving.Text = "Enable driving";
            this.btnEnableDriving.UseVisualStyleBackColor = true;
            this.btnEnableDriving.Click += new System.EventHandler(this.btnEnableDriving_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 556);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wheelchair HMI";
            this.tabControl1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFwd)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAlarm)).EndInit();
            this.tabSetitngs.ResumeLayout(false);
            this.tabSetitngs.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSerialConnect;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSetitngs;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.PictureBox picBoxAlarm;
        private System.Windows.Forms.Button btnAckAlarms;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateAlarms;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button zone1;
        private System.Windows.Forms.Button zone4;
        private System.Windows.Forms.Button zone3;
        private System.Windows.Forms.Button zone2;
        private System.Windows.Forms.Label lblFwd;
        private System.Windows.Forms.PictureBox picBoxFwd;
        private System.Windows.Forms.PictureBox picBoxLeft;
        private System.Windows.Forms.PictureBox picBoxBwd;
        private System.Windows.Forms.PictureBox picBoxRight;
        private System.Windows.Forms.DataGridView dataGridViewAlarms;
        private System.Windows.Forms.Label lblAlarms;
        private System.Windows.Forms.Timer tmrLogData;
        private System.Windows.Forms.Timer tmrUpdateAlarms;
        private System.Windows.Forms.Timer tmrUpdateData;
        private System.Windows.Forms.Timer tmrAlarmActive;
        private System.Windows.Forms.Button btnEnableDriving;
    }
}

