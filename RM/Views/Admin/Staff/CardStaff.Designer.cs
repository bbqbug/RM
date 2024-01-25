namespace RM.Views.Admin.Staff
{
    partial class CardStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_hoten = new System.Windows.Forms.Label();
            this.lb_bophan = new System.Windows.Forms.Label();
            this.lb_chucvu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(102, 11);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(74, 13);
            this.lb_manv.TabIndex = 0;
            this.lb_manv.Text = "Mã Nhân viên";
            // 
            // lb_hoten
            // 
            this.lb_hoten.AutoSize = true;
            this.lb_hoten.Location = new System.Drawing.Point(14, 40);
            this.lb_hoten.Name = "lb_hoten";
            this.lb_hoten.Size = new System.Drawing.Size(37, 13);
            this.lb_hoten.TabIndex = 1;
            this.lb_hoten.Text = "họ tên";
            // 
            // lb_bophan
            // 
            this.lb_bophan.AutoSize = true;
            this.lb_bophan.Location = new System.Drawing.Point(14, 79);
            this.lb_bophan.Name = "lb_bophan";
            this.lb_bophan.Size = new System.Drawing.Size(46, 13);
            this.lb_bophan.TabIndex = 1;
            this.lb_bophan.Text = "bộ phận";
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.AutoSize = true;
            this.lb_chucvu.Location = new System.Drawing.Point(14, 113);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(47, 13);
            this.lb_chucvu.TabIndex = 1;
            this.lb_chucvu.Text = "Chức vụ";
            // 
            // CardStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_chucvu);
            this.Controls.Add(this.lb_bophan);
            this.Controls.Add(this.lb_hoten);
            this.Controls.Add(this.lb_manv);
            this.Name = "CardStaff";
            this.Size = new System.Drawing.Size(270, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_hoten;
        private System.Windows.Forms.Label lb_bophan;
        private System.Windows.Forms.Label lb_chucvu;
    }
}
