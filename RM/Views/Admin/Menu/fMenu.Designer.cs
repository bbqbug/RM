namespace RM.Views.Admin
{
    partial class fMenu
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_food5 = new System.Windows.Forms.ComboBox();
            this.cbb_food4 = new System.Windows.Forms.ComboBox();
            this.cbb_food3 = new System.Windows.Forms.ComboBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_food2 = new System.Windows.Forms.ComboBox();
            this.cbb_food1 = new System.Windows.Forms.ComboBox();
            this.btn_stop = new FontAwesome.Sharp.IconButton();
            this.btn_update = new FontAwesome.Sharp.IconButton();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nameMenu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_active = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Location = new System.Drawing.Point(364, 24);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(463, 25);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 59);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btn_add.Location = new System.Drawing.Point(853, 15);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(39, 41);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 527);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btn_active);
            this.panel2.Controls.Add(this.cbb_food5);
            this.panel2.Controls.Add(this.cbb_food4);
            this.panel2.Controls.Add(this.cbb_food3);
            this.panel2.Controls.Add(this.txt_mota);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbb_food2);
            this.panel2.Controls.Add(this.cbb_food1);
            this.panel2.Controls.Add(this.btn_stop);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_nameMenu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(642, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 527);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // cbb_food5
            // 
            this.cbb_food5.FormattingEnabled = true;
            this.cbb_food5.Location = new System.Drawing.Point(117, 343);
            this.cbb_food5.Name = "cbb_food5";
            this.cbb_food5.Size = new System.Drawing.Size(153, 25);
            this.cbb_food5.TabIndex = 8;
            // 
            // cbb_food4
            // 
            this.cbb_food4.FormattingEnabled = true;
            this.cbb_food4.Location = new System.Drawing.Point(117, 280);
            this.cbb_food4.Name = "cbb_food4";
            this.cbb_food4.Size = new System.Drawing.Size(153, 25);
            this.cbb_food4.TabIndex = 7;
            // 
            // cbb_food3
            // 
            this.cbb_food3.FormattingEnabled = true;
            this.cbb_food3.Location = new System.Drawing.Point(117, 215);
            this.cbb_food3.Name = "cbb_food3";
            this.cbb_food3.Size = new System.Drawing.Size(153, 25);
            this.cbb_food3.TabIndex = 6;
            // 
            // txt_mota
            // 
            this.txt_mota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mota.Location = new System.Drawing.Point(117, 391);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(153, 50);
            this.txt_mota.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mô tả:";
            // 
            // cbb_food2
            // 
            this.cbb_food2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_food2.FormattingEnabled = true;
            this.cbb_food2.Location = new System.Drawing.Point(117, 158);
            this.cbb_food2.Name = "cbb_food2";
            this.cbb_food2.Size = new System.Drawing.Size(153, 25);
            this.cbb_food2.TabIndex = 3;
            // 
            // cbb_food1
            // 
            this.cbb_food1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_food1.FormattingEnabled = true;
            this.cbb_food1.Location = new System.Drawing.Point(117, 95);
            this.cbb_food1.Name = "cbb_food1";
            this.cbb_food1.Size = new System.Drawing.Size(153, 25);
            this.cbb_food1.TabIndex = 3;
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(70)))), ((int)(((byte)(63)))));
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_stop.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_stop.IconColor = System.Drawing.Color.Black;
            this.btn_stop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stop.Location = new System.Drawing.Point(17, 490);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(89, 34);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Tạm ngưng";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_update.Location = new System.Drawing.Point(208, 452);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(62, 34);
            this.btn_update.TabIndex = 2;
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
            this.btn_save.Location = new System.Drawing.Point(17, 452);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(62, 34);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Thêm";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tráng Miệng:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Món Chính:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Món Chính:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Món Chính:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khai Vị:";
            // 
            // txt_nameMenu
            // 
            this.txt_nameMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameMenu.Location = new System.Drawing.Point(117, 37);
            this.txt_nameMenu.Name = "txt_nameMenu";
            this.txt_nameMenu.Size = new System.Drawing.Size(153, 25);
            this.txt_nameMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Menu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_active
            // 
            this.btn_active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(70)))), ((int)(((byte)(63)))));
            this.btn_active.FlatAppearance.BorderSize = 0;
            this.btn_active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_active.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_active.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_active.IconColor = System.Drawing.Color.Black;
            this.btn_active.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_active.Location = new System.Drawing.Point(181, 490);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(89, 34);
            this.btn_active.TabIndex = 9;
            this.btn_active.Text = "Mở lại";
            this.btn_active.UseVisualStyleBackColor = false;
            this.btn_active.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 589);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nameMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_stop;
        private FontAwesome.Sharp.IconButton btn_update;
        private System.Windows.Forms.ComboBox cbb_food2;
        private System.Windows.Forms.ComboBox cbb_food1;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_food5;
        private System.Windows.Forms.ComboBox cbb_food4;
        private System.Windows.Forms.ComboBox cbb_food3;
        private FontAwesome.Sharp.IconButton btn_active;
    }
}