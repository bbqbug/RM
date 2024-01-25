namespace RM.Views
{
    partial class fMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_food = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_bill = new FontAwesome.Sharp.IconButton();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.btn_staff = new FontAwesome.Sharp.IconButton();
            this.btn_POS = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.icon_logo = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name_user = new System.Windows.Forms.Label();
            this.img_user = new System.Windows.Forms.PictureBox();
            this.lb_control = new System.Windows.Forms.Label();
            this.icon_control = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.btn_minimize = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_control)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btn_food);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btn_bill);
            this.panel1.Controls.Add(this.btn_menu);
            this.panel1.Controls.Add(this.btn_staff);
            this.panel1.Controls.Add(this.btn_POS);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 605);
            this.panel1.TabIndex = 0;
            // 
            // btn_food
            // 
            this.btn_food.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_food.FlatAppearance.BorderSize = 0;
            this.btn_food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_food.ForeColor = System.Drawing.Color.White;
            this.btn_food.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            this.btn_food.IconColor = System.Drawing.Color.White;
            this.btn_food.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_food.IconSize = 36;
            this.btn_food.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_food.Location = new System.Drawing.Point(0, 380);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(220, 60);
            this.btn_food.TabIndex = 6;
            this.btn_food.Text = "Món Ăn";
            this.btn_food.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_food.UseVisualStyleBackColor = true;
            this.btn_food.EnabledChanged += new System.EventHandler(this.btn_staff_EnabledChanged);
            this.btn_food.Click += new System.EventHandler(this.btn_food_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Red;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 24;
            this.iconButton1.Location = new System.Drawing.Point(38, 533);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(117, 43);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bill.ForeColor = System.Drawing.Color.White;
            this.btn_bill.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.btn_bill.IconColor = System.Drawing.Color.White;
            this.btn_bill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_bill.IconSize = 36;
            this.btn_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bill.Location = new System.Drawing.Point(0, 320);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(220, 60);
            this.btn_bill.TabIndex = 4;
            this.btn_bill.Text = "Hóa đơn";
            this.btn_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.EnabledChanged += new System.EventHandler(this.btn_staff_EnabledChanged);
            this.btn_bill.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btn_menu.IconColor = System.Drawing.Color.White;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 36;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(0, 260);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(220, 60);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.Text = "Thực Đơn";
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.EnabledChanged += new System.EventHandler(this.btn_staff_EnabledChanged);
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.ForeColor = System.Drawing.Color.White;
            this.btn_staff.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btn_staff.IconColor = System.Drawing.Color.White;
            this.btn_staff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_staff.IconSize = 36;
            this.btn_staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.Location = new System.Drawing.Point(0, 200);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(220, 60);
            this.btn_staff.TabIndex = 2;
            this.btn_staff.Text = "Nhân Viên";
            this.btn_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_staff.UseVisualStyleBackColor = true;
            this.btn_staff.EnabledChanged += new System.EventHandler(this.btn_staff_EnabledChanged);
            this.btn_staff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btn_POS
            // 
            this.btn_POS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_POS.FlatAppearance.BorderSize = 0;
            this.btn_POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_POS.ForeColor = System.Drawing.Color.White;
            this.btn_POS.IconChar = FontAwesome.Sharp.IconChar.Display;
            this.btn_POS.IconColor = System.Drawing.Color.White;
            this.btn_POS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_POS.IconSize = 36;
            this.btn_POS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_POS.Location = new System.Drawing.Point(0, 140);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(220, 60);
            this.btn_POS.TabIndex = 1;
            this.btn_POS.Text = "Đặt Chỗ";
            this.btn_POS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_POS.UseVisualStyleBackColor = true;
            this.btn_POS.Click += new System.EventHandler(this.btn_POS_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.icon_logo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 140);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Restaurant Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_logo
            // 
            this.icon_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.icon_logo.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.icon_logo.IconColor = System.Drawing.Color.White;
            this.icon_logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_logo.IconSize = 86;
            this.icon_logo.Location = new System.Drawing.Point(36, 12);
            this.icon_logo.Name = "icon_logo";
            this.icon_logo.Size = new System.Drawing.Size(150, 86);
            this.icon_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_logo.TabIndex = 0;
            this.icon_logo.TabStop = false;
            this.icon_logo.Click += new System.EventHandler(this.icon_logo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.name_user);
            this.panel2.Controls.Add(this.img_user);
            this.panel2.Controls.Add(this.lb_control);
            this.panel2.Controls.Add(this.icon_control);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 43);
            this.panel2.TabIndex = 1;
            // 
            // name_user
            // 
            this.name_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_user.AutoSize = true;
            this.name_user.ForeColor = System.Drawing.Color.White;
            this.name_user.Location = new System.Drawing.Point(602, 18);
            this.name_user.Name = "name_user";
            this.name_user.Size = new System.Drawing.Size(43, 17);
            this.name_user.TabIndex = 4;
            this.name_user.Text = "label2";
            // 
            // img_user
            // 
            this.img_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.img_user.Location = new System.Drawing.Point(561, 12);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(24, 23);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_user.TabIndex = 3;
            this.img_user.TabStop = false;
            // 
            // lb_control
            // 
            this.lb_control.AutoSize = true;
            this.lb_control.Location = new System.Drawing.Point(57, 18);
            this.lb_control.Name = "lb_control";
            this.lb_control.Size = new System.Drawing.Size(0, 17);
            this.lb_control.TabIndex = 2;
            // 
            // icon_control
            // 
            this.icon_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.icon_control.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icon_control.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icon_control.IconColor = System.Drawing.SystemColors.ControlText;
            this.icon_control.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_control.IconSize = 23;
            this.icon_control.Location = new System.Drawing.Point(23, 17);
            this.icon_control.Name = "icon_control";
            this.icon_control.Size = new System.Drawing.Size(28, 23);
            this.icon_control.TabIndex = 1;
            this.icon_control.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btn_exit);
            this.panel4.Controls.Add(this.btn_minimize);
            this.panel4.Location = new System.Drawing.Point(722, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(105, 37);
            this.panel4.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_exit.IconColor = System.Drawing.Color.Black;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 16;
            this.btn_exit.Location = new System.Drawing.Point(64, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(190)))), ((int)(((byte)(198)))));
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimize.IconColor = System.Drawing.Color.Black;
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.IconSize = 16;
            this.btn_minimize.Location = new System.Drawing.Point(20, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(38, 23);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fMain";
            this.Text = "fMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_control)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_minimize;
        private FontAwesome.Sharp.IconButton btn_exit;
        private FontAwesome.Sharp.IconButton btn_POS;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btn_menu;
        private FontAwesome.Sharp.IconButton btn_staff;
        private FontAwesome.Sharp.IconButton btn_bill;
        private System.Windows.Forms.Label lb_control;
        private FontAwesome.Sharp.IconPictureBox icon_control;
        private FontAwesome.Sharp.IconPictureBox icon_logo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_food;
        private System.Windows.Forms.PictureBox img_user;
        private System.Windows.Forms.Label name_user;
    }
}