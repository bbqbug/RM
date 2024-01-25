namespace RM.Views
{
    partial class fBooking
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
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.dt_time = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_checkkv = new System.Windows.Forms.Button();
            this.check_tt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flow_area = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_booking = new FontAwesome.Sharp.IconButton();
            this.flow_billofday = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_areaofday = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_date
            // 
            this.dt_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_date.CustomFormat = "dd-MM-yyyy";
            this.dt_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_date.Location = new System.Drawing.Point(117, 131);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(123, 20);
            this.dt_date.TabIndex = 1;
            // 
            // dt_time
            // 
            this.dt_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_time.CustomFormat = "HH:mm";
            this.dt_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_time.Location = new System.Drawing.Point(117, 188);
            this.dt_time.Name = "dt_time";
            this.dt_time.Size = new System.Drawing.Size(123, 20);
            this.dt_time.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_checkkv);
            this.groupBox1.Controls.Add(this.check_tt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dt_time);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_date);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_fullname);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btn_checkkv
            // 
            this.btn_checkkv.Location = new System.Drawing.Point(87, 298);
            this.btn_checkkv.Name = "btn_checkkv";
            this.btn_checkkv.Size = new System.Drawing.Size(98, 23);
            this.btn_checkkv.TabIndex = 3;
            this.btn_checkkv.Text = "Xem Khu Vực";
            this.btn_checkkv.UseVisualStyleBackColor = true;
            this.btn_checkkv.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // check_tt
            // 
            this.check_tt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.check_tt.AutoSize = true;
            this.check_tt.Location = new System.Drawing.Point(29, 242);
            this.check_tt.Name = "check_tt";
            this.check_tt.Size = new System.Drawing.Size(61, 17);
            this.check_tt.TabIndex = 2;
            this.check_tt.Text = "Đã cọc";
            this.check_tt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giờ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điện thoại:";
            // 
            // txt_fullname
            // 
            this.txt_fullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_fullname.Location = new System.Drawing.Point(117, 85);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(123, 20);
            this.txt_fullname.TabIndex = 0;
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone.Location = new System.Drawing.Point(117, 38);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(123, 20);
            this.txt_phone.TabIndex = 0;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktraso);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(869, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 591);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.flow_area);
            this.panel3.Controls.Add(this.flow_menu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 218);
            this.panel3.TabIndex = 5;
            // 
            // flow_area
            // 
            this.flow_area.AutoSize = true;
            this.flow_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow_area.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_area.Location = new System.Drawing.Point(0, 4);
            this.flow_area.Name = "flow_area";
            this.flow_area.Size = new System.Drawing.Size(267, 4);
            this.flow_area.TabIndex = 1;
            // 
            // flow_menu
            // 
            this.flow_menu.AutoSize = true;
            this.flow_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_menu.Location = new System.Drawing.Point(0, 0);
            this.flow_menu.Name = "flow_menu";
            this.flow_menu.Size = new System.Drawing.Size(267, 4);
            this.flow_menu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_booking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 545);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 46);
            this.panel2.TabIndex = 4;
            // 
            // btn_booking
            // 
            this.btn_booking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_booking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btn_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_booking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_booking.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_booking.IconColor = System.Drawing.Color.Black;
            this.btn_booking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_booking.Location = new System.Drawing.Point(86, 6);
            this.btn_booking.Name = "btn_booking";
            this.btn_booking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_booking.Size = new System.Drawing.Size(99, 37);
            this.btn_booking.TabIndex = 0;
            this.btn_booking.Text = "Đặt";
            this.btn_booking.UseVisualStyleBackColor = false;
            this.btn_booking.Click += new System.EventHandler(this.btn_booking_Click);
            // 
            // flow_billofday
            // 
            this.flow_billofday.AutoScroll = true;
            this.flow_billofday.AutoSize = true;
            this.flow_billofday.BackColor = System.Drawing.SystemColors.Control;
            this.flow_billofday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_billofday.Location = new System.Drawing.Point(0, 0);
            this.flow_billofday.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.flow_billofday.Name = "flow_billofday";
            this.flow_billofday.Size = new System.Drawing.Size(869, 591);
            this.flow_billofday.TabIndex = 5;
            // 
            // flow_areaofday
            // 
            this.flow_areaofday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow_areaofday.Location = new System.Drawing.Point(0, 434);
            this.flow_areaofday.Name = "flow_areaofday";
            this.flow_areaofday.Size = new System.Drawing.Size(869, 157);
            this.flow_areaofday.TabIndex = 6;
            // 
            // fBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 591);
            this.Controls.Add(this.flow_areaofday);
            this.Controls.Add(this.flow_billofday);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBooking";
            this.Text = "fBooking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.DateTimePicker dt_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox check_tt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_booking;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flow_area;
        private System.Windows.Forms.FlowLayoutPanel flow_menu;
        private System.Windows.Forms.FlowLayoutPanel flow_billofday;
        private System.Windows.Forms.FlowLayoutPanel flow_areaofday;
        private System.Windows.Forms.Button btn_checkkv;
    }
}