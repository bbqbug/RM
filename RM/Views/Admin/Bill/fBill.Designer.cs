namespace RM.Views.Admin.Bill
{
    partial class fBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBill));
            this.timestart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeend = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_total = new System.Windows.Forms.Panel();
            this.lb_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_done = new System.Windows.Forms.Panel();
            this.lb_done = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_cancel = new System.Windows.Forms.Panel();
            this.lb_cancle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_no_done = new System.Windows.Forms.Panel();
            this.lb_no_done = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flow_area = new System.Windows.Forms.FlowLayoutPanel();
            this.flowdetail = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_print = new FontAwesome.Sharp.IconButton();
            this.btn_update = new FontAwesome.Sharp.IconButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.lb_area = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pn_now = new System.Windows.Forms.Panel();
            this.lb_dangdr = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_doanhthu = new FontAwesome.Sharp.IconButton();
            this.pn_total.SuspendLayout();
            this.pn_done.SuspendLayout();
            this.pn_cancel.SuspendLayout();
            this.pn_no_done.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pn_now.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timestart
            // 
            this.timestart.CustomFormat = "dd-MM-yyyy";
            this.timestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestart.Location = new System.Drawing.Point(169, 19);
            this.timestart.Name = "timestart";
            this.timestart.Size = new System.Drawing.Size(116, 25);
            this.timestart.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "từ:";
            // 
            // timeend
            // 
            this.timeend.CustomFormat = "dd-MM-yyyy";
            this.timeend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeend.Location = new System.Drawing.Point(358, 19);
            this.timeend.Name = "timeend";
            this.timeend.Size = new System.Drawing.Size(116, 25);
            this.timeend.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "đến:";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(1211, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 25);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1142, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tìm kiếm:";
            // 
            // pn_total
            // 
            this.pn_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pn_total.Controls.Add(this.lb_total);
            this.pn_total.Controls.Add(this.label5);
            this.pn_total.Location = new System.Drawing.Point(38, 61);
            this.pn_total.Name = "pn_total";
            this.pn_total.Size = new System.Drawing.Size(158, 77);
            this.pn_total.TabIndex = 6;
            this.pn_total.Click += new System.EventHandler(this.pn_total_Click);
            // 
            // lb_total
            // 
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_total.Location = new System.Drawing.Point(0, 41);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(158, 17);
            this.lb_total.TabIndex = 1;
            this.lb_total.Text = "50";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_done
            // 
            this.pn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.pn_done.Controls.Add(this.lb_done);
            this.pn_done.Controls.Add(this.label6);
            this.pn_done.Location = new System.Drawing.Point(237, 61);
            this.pn_done.Name = "pn_done";
            this.pn_done.Size = new System.Drawing.Size(158, 77);
            this.pn_done.TabIndex = 6;
            this.pn_done.Click += new System.EventHandler(this.pn_done_Click);
            // 
            // lb_done
            // 
            this.lb_done.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_done.Location = new System.Drawing.Point(0, 41);
            this.lb_done.Name = "lb_done";
            this.lb_done.Size = new System.Drawing.Size(158, 17);
            this.lb_done.TabIndex = 1;
            this.lb_done.Text = "40";
            this.lb_done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(0, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đã diễn ra";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_cancel
            // 
            this.pn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.pn_cancel.Controls.Add(this.lb_cancle);
            this.pn_cancel.Controls.Add(this.label7);
            this.pn_cancel.Location = new System.Drawing.Point(437, 61);
            this.pn_cancel.Name = "pn_cancel";
            this.pn_cancel.Size = new System.Drawing.Size(158, 77);
            this.pn_cancel.TabIndex = 6;
            this.pn_cancel.Click += new System.EventHandler(this.pn_cancel_Click);
            // 
            // lb_cancle
            // 
            this.lb_cancle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cancle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_cancle.Location = new System.Drawing.Point(0, 41);
            this.lb_cancle.Name = "lb_cancle";
            this.lb_cancle.Size = new System.Drawing.Size(158, 17);
            this.lb_cancle.TabIndex = 1;
            this.lb_cancle.Text = "9";
            this.lb_cancle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hủy";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_no_done
            // 
            this.pn_no_done.BackColor = System.Drawing.Color.Gray;
            this.pn_no_done.Controls.Add(this.lb_no_done);
            this.pn_no_done.Controls.Add(this.label8);
            this.pn_no_done.Location = new System.Drawing.Point(636, 61);
            this.pn_no_done.Name = "pn_no_done";
            this.pn_no_done.Size = new System.Drawing.Size(158, 77);
            this.pn_no_done.TabIndex = 6;
            this.pn_no_done.Click += new System.EventHandler(this.pn_no_done_Click);
            // 
            // lb_no_done
            // 
            this.lb_no_done.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no_done.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_no_done.Location = new System.Drawing.Point(0, 41);
            this.lb_no_done.Name = "lb_no_done";
            this.lb_no_done.Size = new System.Drawing.Size(158, 17);
            this.lb_no_done.TabIndex = 1;
            this.lb_no_done.Text = "1";
            this.lb_no_done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(0, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chưa diễn ra";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search
            // 
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_search.IconColor = System.Drawing.Color.Black;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.Location = new System.Drawing.Point(524, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(80, 36);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "Xem";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 363);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1145, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 560);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.flow_area);
            this.panel3.Controls.Add(this.flowdetail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 212);
            this.panel3.TabIndex = 6;
            // 
            // flow_area
            // 
            this.flow_area.AutoSize = true;
            this.flow_area.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flow_area.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_area.Location = new System.Drawing.Point(0, 4);
            this.flow_area.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flow_area.Name = "flow_area";
            this.flow_area.Size = new System.Drawing.Size(296, 4);
            this.flow_area.TabIndex = 4;
            // 
            // flowdetail
            // 
            this.flowdetail.AutoSize = true;
            this.flowdetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowdetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowdetail.Location = new System.Drawing.Point(0, 0);
            this.flowdetail.Name = "flowdetail";
            this.flowdetail.Size = new System.Drawing.Size(296, 4);
            this.flowdetail.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_payment);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 104);
            this.panel2.TabIndex = 5;
            // 
            // btn_payment
            // 
            this.btn_payment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Location = new System.Drawing.Point(102, 60);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(86, 31);
            this.btn_payment.TabIndex = 12;
            this.btn_payment.Text = "Thanh Toán";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Gray;
            this.btn_print.FlatAppearance.BorderSize = 0;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btn_print.IconColor = System.Drawing.Color.White;
            this.btn_print.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_print.IconSize = 28;
            this.btn_print.Location = new System.Drawing.Point(124, 11);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(64, 31);
            this.btn_print.TabIndex = 11;
            this.btn_print.Text = "In";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(188)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_update.IconColor = System.Drawing.Color.Black;
            this.btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_update.Location = new System.Drawing.Point(21, 11);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(62, 31);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(70)))), ((int)(((byte)(63)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(215, 11);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(67, 31);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tongtien);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lb_phone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lb_fullname);
            this.groupBox1.Controls.Add(this.lb_area);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_time);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lb_date);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Location = new System.Drawing.Point(122, 73);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(88, 17);
            this.lb_phone.TabIndex = 0;
            this.lb_phone.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số điện thoại:";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(121, 39);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(67, 17);
            this.lb_fullname.TabIndex = 0;
            this.lb_fullname.Text = "Họ và tên:";
            // 
            // lb_area
            // 
            this.lb_area.AutoSize = true;
            this.lb_area.Location = new System.Drawing.Point(122, 184);
            this.lb_area.Name = "lb_area";
            this.lb_area.Size = new System.Drawing.Size(57, 17);
            this.lb_area.TabIndex = 0;
            this.lb_area.Text = "Khu vực:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ và tên:";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(122, 149);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(31, 17);
            this.lb_time.TabIndex = 0;
            this.lb_time.Text = "Giờ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Khu vực:";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(122, 111);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(42, 17);
            this.lb_date.TabIndex = 0;
            this.lb_date.Text = "Ngày:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Giờ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ngày:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pn_now
            // 
            this.pn_now.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(168)))), ((int)(((byte)(55)))));
            this.pn_now.Controls.Add(this.lb_dangdr);
            this.pn_now.Controls.Add(this.label15);
            this.pn_now.Location = new System.Drawing.Point(836, 61);
            this.pn_now.Name = "pn_now";
            this.pn_now.Size = new System.Drawing.Size(158, 77);
            this.pn_now.TabIndex = 11;
            this.pn_now.Click += new System.EventHandler(this.pn_now_Click);
            // 
            // lb_dangdr
            // 
            this.lb_dangdr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dangdr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_dangdr.Location = new System.Drawing.Point(0, 41);
            this.lb_dangdr.Name = "lb_dangdr";
            this.lb_dangdr.Size = new System.Drawing.Size(158, 17);
            this.lb_dangdr.TabIndex = 1;
            this.lb_dangdr.Text = "1";
            this.lb_dangdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(0, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Đang diễn ra";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Enabled = false;
            this.lb_tongtien.Location = new System.Drawing.Point(122, 221);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(16, 17);
            this.lb_tongtien.TabIndex = 1;
            this.lb_tongtien.Text = "tt";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 17);
            this.label16.TabIndex = 2;
            this.label16.Text = "Tổng tiền:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.lb_doanhthu);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(38, 153);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 77);
            this.panel4.TabIndex = 7;
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_doanhthu.Location = new System.Drawing.Point(0, 41);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(200, 17);
            this.lb_doanhthu.TabIndex = 1;
            this.lb_doanhthu.Text = "50";
            this.lb_doanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(0, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Doanh Thu:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_doanhthu.IconColor = System.Drawing.Color.Black;
            this.btn_doanhthu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_doanhthu.Location = new System.Drawing.Point(636, 12);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(113, 36);
            this.btn_doanhthu.TabIndex = 12;
            this.btn_doanhthu.Text = "Xem doanh thu";
            this.btn_doanhthu.UseVisualStyleBackColor = true;
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 650);
            this.Controls.Add(this.btn_doanhthu);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pn_now);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.pn_no_done);
            this.Controls.Add(this.pn_cancel);
            this.Controls.Add(this.pn_done);
            this.Controls.Add(this.pn_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeend);
            this.Controls.Add(this.timestart);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fBill";
            this.Text = "++++++++++++++";
            this.pn_total.ResumeLayout(false);
            this.pn_done.ResumeLayout(false);
            this.pn_cancel.ResumeLayout(false);
            this.pn_no_done.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_now.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker timestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_total;
        private System.Windows.Forms.Panel pn_done;
        private System.Windows.Forms.Panel pn_cancel;
        private System.Windows.Forms.Panel pn_no_done;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_done;
        private System.Windows.Forms.Label lb_cancle;
        private System.Windows.Forms.Label lb_no_done;
        private FontAwesome.Sharp.IconButton btn_search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowdetail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.Label lb_area;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flow_area;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private FontAwesome.Sharp.IconButton btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Panel pn_now;
        private System.Windows.Forms.Label lb_dangdr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton btn_doanhthu;
        //        private FontAwesome.Sharp.IconButton btn_addmenu;
        //        private FontAwesome.Sharp.IconButton iconButton1;
    }
}