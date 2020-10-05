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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAckAlarms = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnableDriving = new System.Windows.Forms.Button();
            this.tabSetitngs = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFwd)).BeginInit();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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

            this.tabControl1.Location = new System.Drawing.Point(-3, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1091, 678);
            this.tabControl1.Location = new System.Drawing.Point(3, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1441, 817);

            
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
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(1083, 652);
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
            this.dataGridViewAlarms.Location = new System.Drawing.Point(212, 364);
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.ReadOnly = true;
            this.dataGridViewAlarms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewAlarms.Size = new System.Drawing.Size(871, 288);
            this.dataGridViewAlarms.TabIndex = 21;
            // 
            // lblAlarms
            // 
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarms.Location = new System.Drawing.Point(213, 337);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(153, 24);
            this.lblAlarms.TabIndex = 20;
            this.lblAlarms.Text = "Alarm overview";
            // 
            // picBoxBwd
            // 
            this.picBoxBwd.Image = global::WheelChairHMI.Properties.Resources.ArrowBackward;
            this.picBoxBwd.Location = new System.Drawing.Point(325, 221);
            this.picBoxBwd.Name = "picBoxBwd";
            this.picBoxBwd.Size = new System.Drawing.Size(45, 62);
            this.picBoxBwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxBwd.TabIndex = 19;
            this.picBoxBwd.TabStop = false;
            // 
            // picBoxRight
            // 
            this.picBoxRight.Image = global::WheelChairHMI.Properties.Resources.ArrowRight;
            this.picBoxRight.Location = new System.Drawing.Point(405, 115);
            this.picBoxRight.Name = "picBoxRight";
            this.picBoxRight.Size = new System.Drawing.Size(62, 45);
            this.picBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxRight.TabIndex = 18;
            this.picBoxRight.TabStop = false;
            // 
            // picBoxLeft
            // 
            this.picBoxLeft.Image = global::WheelChairHMI.Properties.Resources.ArrowLeft;
            this.picBoxLeft.Location = new System.Drawing.Point(227, 115);
            this.picBoxLeft.Name = "picBoxLeft";
            this.picBoxLeft.Size = new System.Drawing.Size(62, 45);
            this.picBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLeft.TabIndex = 17;
            this.picBoxLeft.TabStop = false;
            // 
            // picBoxFwd
            // 
            this.picBoxFwd.Image = global::WheelChairHMI.Properties.Resources.ArrowForward;
            this.picBoxFwd.Location = new System.Drawing.Point(324, 39);
            this.picBoxFwd.Name = "picBoxFwd";
            this.picBoxFwd.Size = new System.Drawing.Size(46, 63);
            this.picBoxFwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFwd.TabIndex = 16;
            this.picBoxFwd.TabStop = false;
            // 
            // lblFwd
            // 
            this.lblFwd.AutoSize = true;
            this.lblFwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFwd.Location = new System.Drawing.Point(299, 14);
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
            this.zone1.Location = new System.Drawing.Point(297, 115);
            this.zone1.Name = "zone1";
            this.zone1.Size = new System.Drawing.Size(100, 100);
            this.zone1.TabIndex = 14;
            this.zone1.UseVisualStyleBackColor = false;
            // 
            // zone4
            // 
            this.zone4.BackColor = System.Drawing.Color.White;
            this.zone4.Enabled = false;
            this.zone4.Location = new System.Drawing.Point(227, 289);
            this.zone4.Name = "zone4";
            this.zone4.Size = new System.Drawing.Size(240, 30);
            this.zone4.TabIndex = 13;
            this.zone4.UseVisualStyleBackColor = false;
            // 
            // zone3
            // 
            this.zone3.BackColor = System.Drawing.Color.White;
            this.zone3.Enabled = false;
            this.zone3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zone3.Location = new System.Drawing.Point(377, 39);
            this.zone3.Name = "zone3";
            this.zone3.Size = new System.Drawing.Size(90, 70);
            this.zone3.TabIndex = 12;
            this.zone3.UseVisualStyleBackColor = false;
            // 
            // zone2
            // 
            this.zone2.BackColor = System.Drawing.Color.White;
            this.zone2.Enabled = false;
            this.zone2.Location = new System.Drawing.Point(227, 39);
            this.zone2.Name = "zone2";
            this.zone2.Size = new System.Drawing.Size(90, 70);
            this.zone2.TabIndex = 11;
            this.zone2.UseVisualStyleBackColor = false;

            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.btnUpdateAlarms);
            this.groupBoxControls.Controls.Add(this.button1);
            this.groupBoxControls.Controls.Add(this.btnTest);
            this.groupBoxControls.Controls.Add(this.pictureBox1);
            this.groupBoxControls.Controls.Add(this.btnAckAlarms);
            this.groupBoxControls.Controls.Add(this.btnDisable);
            this.groupBoxControls.Controls.Add(this.btnEnableDriving);
            this.groupBoxControls.Location = new System.Drawing.Point(6, 6);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(200, 640);
            this.groupBoxControls.TabIndex = 10;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // btnUpdateAlarms
            // 
            this.btnUpdateAlarms.Location = new System.Drawing.Point(5, 109);
            this.btnUpdateAlarms.Name = "btnUpdateAlarms";
            this.btnUpdateAlarms.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateAlarms.TabIndex = 7;
            this.btnUpdateAlarms.Text = "Update Alarms";
            this.btnUpdateAlarms.UseVisualStyleBackColor = true;
            this.btnUpdateAlarms.Click += new System.EventHandler(this.btnUpdateAlarms_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(58, 357);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test alarm";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WheelChairHMI.Properties.Resources.Alarm;
            this.pictureBox1.Location = new System.Drawing.Point(32, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAckAlarms
            // 
            this.btnAckAlarms.Location = new System.Drawing.Point(5, 80);
            this.btnAckAlarms.Name = "btnAckAlarms";
            this.btnAckAlarms.Size = new System.Drawing.Size(188, 23);
            this.btnAckAlarms.TabIndex = 3;
            this.btnAckAlarms.Text = "Acknowledge all alarms";
            this.btnAckAlarms.UseVisualStyleBackColor = true;
            this.btnAckAlarms.Click += new System.EventHandler(this.btnAckAlarms_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Location = new System.Drawing.Point(6, 51);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(188, 23);
            this.btnDisable.TabIndex = 1;
            this.btnDisable.Text = "Disable driving";
            this.btnDisable.UseVisualStyleBackColor = true;
            // 
            // btnEnableDriving
            // 
            this.btnEnableDriving.Location = new System.Drawing.Point(6, 22);
            this.btnEnableDriving.Name = "btnEnableDriving";
            this.btnEnableDriving.Size = new System.Drawing.Size(188, 23);
            this.btnEnableDriving.TabIndex = 0;
            this.btnEnableDriving.Text = "Enable driving";
            this.btnEnableDriving.UseVisualStyleBackColor = true;
            // 

            // tabSetitngs
            // 
            this.tabSetitngs.Location = new System.Drawing.Point(4, 22);
            this.tabSetitngs.Name = "tabSetitngs";
            this.tabSetitngs.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetitngs.Size = new System.Drawing.Size(1083, 652);
            this.tabSetitngs.TabIndex = 1;
            this.tabSetitngs.Text = "Settings";
            this.tabSetitngs.UseVisualStyleBackColor = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.groupBox1);
            this.tabData.Controls.Add(this.dgvData);
            this.tabData.Controls.Add(this.label7);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(1083, 652);
            this.tabData.TabIndex = 4;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateData);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 640);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data controller";
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(6, 19);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(188, 23);
            this.btnUpdateData.TabIndex = 0;
            this.btnUpdateData.Text = "Update data";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(212, 27);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(867, 628);
            this.dgvData.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "All the data stored in the database";
            // 
            // picBoxBwd
            // 
            this.picBoxBwd.Image = global::WheelChairHMI.Properties.Resources.ArrowBackward;
            this.picBoxBwd.Location = new System.Drawing.Point(325, 221);
            this.picBoxBwd.Name = "picBoxBwd";
            this.picBoxBwd.Size = new System.Drawing.Size(45, 62);
            this.picBoxBwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxBwd.TabIndex = 19;
            this.picBoxBwd.TabStop = false;
            // 
            // picBoxRight
            // 
            this.picBoxRight.Image = global::WheelChairHMI.Properties.Resources.ArrowRight;
            this.picBoxRight.Location = new System.Drawing.Point(405, 115);
            this.picBoxRight.Name = "picBoxRight";
            this.picBoxRight.Size = new System.Drawing.Size(62, 45);
            this.picBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxRight.TabIndex = 18;
            this.picBoxRight.TabStop = false;
            // 
            // picBoxLeft
            // 
            this.picBoxLeft.Image = global::WheelChairHMI.Properties.Resources.ArrowLeft;
            this.picBoxLeft.Location = new System.Drawing.Point(227, 115);
            this.picBoxLeft.Name = "picBoxLeft";
            this.picBoxLeft.Size = new System.Drawing.Size(62, 45);
            this.picBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLeft.TabIndex = 17;
            this.picBoxLeft.TabStop = false;
            // 
            // picBoxFwd
            // 
            this.picBoxFwd.Image = global::WheelChairHMI.Properties.Resources.ArrowForward;
            this.picBoxFwd.Location = new System.Drawing.Point(324, 39);
            this.picBoxFwd.Name = "picBoxFwd";
            this.picBoxFwd.Size = new System.Drawing.Size(46, 63);
            this.picBoxFwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFwd.TabIndex = 16;
            this.picBoxFwd.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WheelChairHMI.Properties.Resources.Alarm;
            this.pictureBox1.Location = new System.Drawing.Point(32, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblAlarms
            // 
            this.lblAlarms.AutoSize = true;
            this.lblAlarms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarms.Location = new System.Drawing.Point(213, 337);
            this.lblAlarms.Name = "lblAlarms";
            this.lblAlarms.Size = new System.Drawing.Size(153, 24);
            this.lblAlarms.TabIndex = 20;
            this.lblAlarms.Text = "Alarm overview";
            // 
            // dataGridViewAlarms
            // 
            this.dataGridViewAlarms.AllowUserToAddRows = false;
            this.dataGridViewAlarms.AllowUserToDeleteRows = false;
            this.dataGridViewAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarms.Location = new System.Drawing.Point(212, 364);
            this.dataGridViewAlarms.Name = "dataGridViewAlarms";
            this.dataGridViewAlarms.ReadOnly = true;
            this.dataGridViewAlarms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewAlarms.Size = new System.Drawing.Size(871, 288);
            this.dataGridViewAlarms.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSetitngs;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button btnEnableDriving;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.PictureBox pictureBox1;
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
    }
}

