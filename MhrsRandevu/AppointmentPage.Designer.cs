namespace MhrsRandevu
{
    partial class AppointmentPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.trackBarMinute = new System.Windows.Forms.TrackBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCycle = new System.Windows.Forms.Label();
            this.cbHospitals = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbClinics = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDistricts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAppointmentCheck = new System.Windows.Forms.Label();
            this.lblAppointmentCycle = new System.Windows.Forms.Label();
            this.lblNetStatus = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAuthExpiry = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAuthName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_Information = new System.Windows.Forms.ListBox();
            this.appointmentCycle = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinute)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.trackBarMinute);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblCycle);
            this.groupBox1.Controls.Add(this.cbHospitals);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbClinics);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDistricts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCities);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(455, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Seçim";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.Location = new System.Drawing.Point(132, 367);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(179, 41);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "DURDUR";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // trackBarMinute
            // 
            this.trackBarMinute.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackBarMinute.LargeChange = 1;
            this.trackBarMinute.Location = new System.Drawing.Point(64, 316);
            this.trackBarMinute.Maximum = 30;
            this.trackBarMinute.Minimum = 1;
            this.trackBarMinute.Name = "trackBarMinute";
            this.trackBarMinute.Size = new System.Drawing.Size(355, 45);
            this.trackBarMinute.TabIndex = 6;
            this.trackBarMinute.Value = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.Location = new System.Drawing.Point(132, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(179, 41);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "BAŞLAT";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCycle
            // 
            this.lblCycle.AutoSize = true;
            this.lblCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCycle.Location = new System.Drawing.Point(70, 286);
            this.lblCycle.Name = "lblCycle";
            this.lblCycle.Size = new System.Drawing.Size(104, 18);
            this.lblCycle.TabIndex = 0;
            this.lblCycle.Text = "Çalışma Sıklığı";
            // 
            // cbHospitals
            // 
            this.cbHospitals.DisplayMember = "Display";
            this.cbHospitals.FormattingEnabled = true;
            this.cbHospitals.Location = new System.Drawing.Point(175, 225);
            this.cbHospitals.Name = "cbHospitals";
            this.cbHospitals.Size = new System.Drawing.Size(244, 32);
            this.cbHospitals.TabIndex = 5;
            this.cbHospitals.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hastane :";
            // 
            // cbClinics
            // 
            this.cbClinics.DisplayMember = "Display";
            this.cbClinics.FormattingEnabled = true;
            this.cbClinics.Location = new System.Drawing.Point(175, 173);
            this.cbClinics.Name = "cbClinics";
            this.cbClinics.Size = new System.Drawing.Size(244, 32);
            this.cbClinics.TabIndex = 3;
            this.cbClinics.ValueMember = "Id";
            this.cbClinics.SelectedIndexChanged += new System.EventHandler(this.cbClinics_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Klinik   :";
            // 
            // cbDistricts
            // 
            this.cbDistricts.DisplayMember = "Display";
            this.cbDistricts.FormattingEnabled = true;
            this.cbDistricts.Location = new System.Drawing.Point(175, 120);
            this.cbDistricts.Name = "cbDistricts";
            this.cbDistricts.Size = new System.Drawing.Size(244, 32);
            this.cbDistricts.TabIndex = 2;
            this.cbDistricts.ValueMember = "Id";
            this.cbDistricts.SelectedIndexChanged += new System.EventHandler(this.cbDistricts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlçe     :";
            // 
            // cbCities
            // 
            this.cbCities.DisplayMember = "Display";
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(175, 71);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(244, 32);
            this.cbCities.TabIndex = 1;
            this.cbCities.ValueMember = "Id";
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.cbCities_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir   :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAppointmentCheck);
            this.groupBox2.Controls.Add(this.lblAppointmentCycle);
            this.groupBox2.Controls.Add(this.lblNetStatus);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblAuthExpiry);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblAuthName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(482, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(303, 442);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oturum Bilgileri";
            // 
            // lblAppointmentCheck
            // 
            this.lblAppointmentCheck.Location = new System.Drawing.Point(182, 225);
            this.lblAppointmentCheck.Name = "lblAppointmentCheck";
            this.lblAppointmentCheck.Size = new System.Drawing.Size(121, 32);
            this.lblAppointmentCheck.TabIndex = 10;
            // 
            // lblAppointmentCycle
            // 
            this.lblAppointmentCycle.AutoSize = true;
            this.lblAppointmentCycle.Location = new System.Drawing.Point(27, 225);
            this.lblAppointmentCycle.Name = "lblAppointmentCycle";
            this.lblAppointmentCycle.Size = new System.Drawing.Size(149, 24);
            this.lblAppointmentCycle.TabIndex = 9;
            this.lblAppointmentCycle.Text = "Otomatik Sorgu :";
            // 
            // lblNetStatus
            // 
            this.lblNetStatus.Location = new System.Drawing.Point(177, 176);
            this.lblNetStatus.Name = "lblNetStatus";
            this.lblNetStatus.Size = new System.Drawing.Size(117, 29);
            this.lblNetStatus.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Internet Durum :";
            // 
            // lblAuthExpiry
            // 
            this.lblAuthExpiry.Location = new System.Drawing.Point(149, 123);
            this.lblAuthExpiry.Name = "lblAuthExpiry";
            this.lblAuthExpiry.Size = new System.Drawing.Size(145, 29);
            this.lblAuthExpiry.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tekrar Giriş :";
            // 
            // lblAuthName
            // 
            this.lblAuthName.Location = new System.Drawing.Point(86, 74);
            this.lblAuthName.Name = "lblAuthName";
            this.lblAuthName.Size = new System.Drawing.Size(208, 24);
            this.lblAuthName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "İsim :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Information);
            this.groupBox3.Location = new System.Drawing.Point(15, 468);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(770, 459);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgilendirme";
            // 
            // lb_Information
            // 
            this.lb_Information.FormattingEnabled = true;
            this.lb_Information.ItemHeight = 24;
            this.lb_Information.Location = new System.Drawing.Point(9, 31);
            this.lb_Information.Name = "lb_Information";
            this.lb_Information.Size = new System.Drawing.Size(752, 412);
            this.lb_Information.TabIndex = 0;
            // 
            // appointmentCycle
            // 
            this.appointmentCycle.Tick += new System.EventHandler(this.appointmentCycle_Tick);
            // 
            // AppointmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 922);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AppointmentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MHRS Randevu Bilgilendirme";
            this.Load += new System.EventHandler(this.AppointmentPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinute)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHospitals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbClinics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDistricts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCycle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trackBarMinute;
        private System.Windows.Forms.Timer appointmentCycle;
        private System.Windows.Forms.ListBox lb_Information;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblAppointmentCheck;
        private System.Windows.Forms.Label lblAppointmentCycle;
        private System.Windows.Forms.Label lblNetStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAuthExpiry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAuthName;
        private System.Windows.Forms.Label label4;
    }
}