namespace RM.Views.Admin.Food
{
    partial class fFood
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
            this.pn_monchinh = new System.Windows.Forms.Panel();
            this.lb_monchinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pn_khaivi = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_khaivi = new System.Windows.Forms.Label();
            this.pn_infor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flow_componentAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.flow_component = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.btn_update = new FontAwesome.Sharp.IconButton();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_srcimage = new System.Windows.Forms.Label();
            this.btn_loadimage = new FontAwesome.Sharp.IconButton();
            this.img_food = new System.Windows.Forms.PictureBox();
            this.cbb_dm = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pn_trangmieng = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_trangmieng = new System.Windows.Forms.Label();
            this.flow_food = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.pn_total = new System.Windows.Forms.Panel();
            this.lb_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pn_monchinh.SuspendLayout();
            this.pn_khaivi.SuspendLayout();
            this.pn_infor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_food)).BeginInit();
            this.pn_trangmieng.SuspendLayout();
            this.pn_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_monchinh
            // 
            this.pn_monchinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_monchinh.Controls.Add(this.lb_monchinh);
            this.pn_monchinh.Controls.Add(this.label5);
            this.pn_monchinh.Location = new System.Drawing.Point(183, 23);
            this.pn_monchinh.Name = "pn_monchinh";
            this.pn_monchinh.Size = new System.Drawing.Size(133, 59);
            this.pn_monchinh.TabIndex = 0;
            this.pn_monchinh.Click += new System.EventHandler(this.pn_monchinh_Click);
            // 
            // lb_monchinh
            // 
            this.lb_monchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monchinh.Location = new System.Drawing.Point(0, 30);
            this.lb_monchinh.Name = "lb_monchinh";
            this.lb_monchinh.Size = new System.Drawing.Size(133, 29);
            this.lb_monchinh.TabIndex = 1;
            this.lb_monchinh.Text = "label6";
            this.lb_monchinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Món Chính";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_khaivi
            // 
            this.pn_khaivi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_khaivi.Controls.Add(this.label8);
            this.pn_khaivi.Controls.Add(this.lb_khaivi);
            this.pn_khaivi.Location = new System.Drawing.Point(349, 23);
            this.pn_khaivi.Name = "pn_khaivi";
            this.pn_khaivi.Size = new System.Drawing.Size(139, 59);
            this.pn_khaivi.TabIndex = 1;
            this.pn_khaivi.Click += new System.EventHandler(this.pn_khaivi_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Khai Vị";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_khaivi
            // 
            this.lb_khaivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khaivi.Location = new System.Drawing.Point(3, 27);
            this.lb_khaivi.Name = "lb_khaivi";
            this.lb_khaivi.Size = new System.Drawing.Size(133, 32);
            this.lb_khaivi.TabIndex = 3;
            this.lb_khaivi.Text = "label7";
            this.lb_khaivi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_infor
            // 
            this.pn_infor.Controls.Add(this.panel1);
            this.pn_infor.Controls.Add(this.panel3);
            this.pn_infor.Controls.Add(this.groupBox1);
            this.pn_infor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_infor.Location = new System.Drawing.Point(1076, 0);
            this.pn_infor.Name = "pn_infor";
            this.pn_infor.Size = new System.Drawing.Size(294, 570);
            this.pn_infor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flow_componentAdd);
            this.panel1.Controls.Add(this.flow_component);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 163);
            this.panel1.TabIndex = 2;
            // 
            // flow_componentAdd
            // 
            this.flow_componentAdd.AutoSize = true;
            this.flow_componentAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_componentAdd.Location = new System.Drawing.Point(0, 0);
            this.flow_componentAdd.Name = "flow_componentAdd";
            this.flow_componentAdd.Size = new System.Drawing.Size(294, 0);
            this.flow_componentAdd.TabIndex = 1;
            // 
            // flow_component
            // 
            this.flow_component.AutoScroll = true;
            this.flow_component.AutoSize = true;
            this.flow_component.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_component.Location = new System.Drawing.Point(0, 0);
            this.flow_component.Name = "flow_component";
            this.flow_component.Size = new System.Drawing.Size(294, 0);
            this.flow_component.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.btn_save);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 65);
            this.panel3.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(70)))), ((int)(((byte)(63)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_delete.IconColor = System.Drawing.Color.Black;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.Location = new System.Drawing.Point(211, 15);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(62, 34);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_update.Location = new System.Drawing.Point(126, 15);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(62, 34);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(176)))), ((int)(((byte)(155)))));
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_save.IconColor = System.Drawing.Color.Black;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.Location = new System.Drawing.Point(39, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(62, 34);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Thêm";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_srcimage);
            this.groupBox1.Controls.Add(this.btn_loadimage);
            this.groupBox1.Controls.Add(this.img_food);
            this.groupBox1.Controls.Add(this.cbb_dm);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_dvt);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Hình ảnh:";
            // 
            // lb_srcimage
            // 
            this.lb_srcimage.AutoSize = true;
            this.lb_srcimage.Location = new System.Drawing.Point(171, 306);
            this.lb_srcimage.Name = "lb_srcimage";
            this.lb_srcimage.Size = new System.Drawing.Size(63, 13);
            this.lb_srcimage.TabIndex = 10;
            this.lb_srcimage.Text = "lb_srcimage";
            this.lb_srcimage.Visible = false;
            // 
            // btn_loadimage
            // 
            this.btn_loadimage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_loadimage.IconColor = System.Drawing.Color.Black;
            this.btn_loadimage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_loadimage.Location = new System.Drawing.Point(110, 224);
            this.btn_loadimage.Name = "btn_loadimage";
            this.btn_loadimage.Size = new System.Drawing.Size(58, 45);
            this.btn_loadimage.TabIndex = 9;
            this.btn_loadimage.Text = "Chọn ảnh";
            this.btn_loadimage.UseVisualStyleBackColor = true;
            this.btn_loadimage.Click += new System.EventHandler(this.btn_loadimage_Click);
            // 
            // img_food
            // 
            this.img_food.Location = new System.Drawing.Point(174, 224);
            this.img_food.Name = "img_food";
            this.img_food.Size = new System.Drawing.Size(82, 79);
            this.img_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_food.TabIndex = 8;
            this.img_food.TabStop = false;
            // 
            // cbb_dm
            // 
            this.cbb_dm.FormattingEnabled = true;
            this.cbb_dm.Location = new System.Drawing.Point(110, 169);
            this.cbb_dm.Name = "cbb_dm";
            this.cbb_dm.Size = new System.Drawing.Size(146, 21);
            this.cbb_dm.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(110, 124);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(146, 20);
            this.txt_price.TabIndex = 6;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(110, 79);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(146, 20);
            this.txt_dvt.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(110, 34);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(146, 37);
            this.txt_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh mục:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên món ăn:";
            // 
            // pn_trangmieng
            // 
            this.pn_trangmieng.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_trangmieng.Controls.Add(this.label10);
            this.pn_trangmieng.Controls.Add(this.lb_trangmieng);
            this.pn_trangmieng.Location = new System.Drawing.Point(520, 23);
            this.pn_trangmieng.Name = "pn_trangmieng";
            this.pn_trangmieng.Size = new System.Drawing.Size(150, 59);
            this.pn_trangmieng.TabIndex = 2;
            this.pn_trangmieng.Click += new System.EventHandler(this.pn_trangmieng_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tráng Miệng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_trangmieng
            // 
            this.lb_trangmieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trangmieng.Location = new System.Drawing.Point(0, 30);
            this.lb_trangmieng.Name = "lb_trangmieng";
            this.lb_trangmieng.Size = new System.Drawing.Size(150, 29);
            this.lb_trangmieng.TabIndex = 3;
            this.lb_trangmieng.Text = "label9";
            this.lb_trangmieng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flow_food
            // 
            this.flow_food.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flow_food.AutoScroll = true;
            this.flow_food.Location = new System.Drawing.Point(12, 102);
            this.flow_food.Name = "flow_food";
            this.flow_food.Size = new System.Drawing.Size(1058, 456);
            this.flow_food.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(858, 23);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(163, 38);
            this.txt_search.TabIndex = 4;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btn_add.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(194)))), ((int)(((byte)(178)))));
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 36;
            this.btn_add.Location = new System.Drawing.Point(1027, 23);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(39, 41);
            this.btn_add.TabIndex = 5;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pn_total
            // 
            this.pn_total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_total.Controls.Add(this.lb_total);
            this.pn_total.Controls.Add(this.label9);
            this.pn_total.Location = new System.Drawing.Point(12, 23);
            this.pn_total.Name = "pn_total";
            this.pn_total.Size = new System.Drawing.Size(133, 59);
            this.pn_total.TabIndex = 2;
            // 
            // lb_total
            // 
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(0, 30);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(133, 29);
            this.lb_total.TabIndex = 1;
            this.lb_total.Text = "label6";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 570);
            this.Controls.Add(this.pn_total);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.flow_food);
            this.Controls.Add(this.pn_trangmieng);
            this.Controls.Add(this.pn_infor);
            this.Controls.Add(this.pn_khaivi);
            this.Controls.Add(this.pn_monchinh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fFood";
            this.Text = "fFood";
            this.pn_monchinh.ResumeLayout(false);
            this.pn_khaivi.ResumeLayout(false);
            this.pn_infor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_food)).EndInit();
            this.pn_trangmieng.ResumeLayout(false);
            this.pn_total.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_monchinh;
        private System.Windows.Forms.Panel pn_khaivi;
        private System.Windows.Forms.Panel pn_infor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_trangmieng;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_update;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.FlowLayoutPanel flow_food;
        private System.Windows.Forms.ComboBox cbb_dm;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label lb_monchinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_khaivi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_trangmieng;
        private System.Windows.Forms.FlowLayoutPanel flow_component;
        private System.Windows.Forms.FlowLayoutPanel flow_componentAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_srcimage;
        private FontAwesome.Sharp.IconButton btn_loadimage;
        private System.Windows.Forms.PictureBox img_food;
        private System.Windows.Forms.Panel pn_total;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label9;
    }
}