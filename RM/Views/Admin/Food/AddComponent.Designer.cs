namespace RM.Views.Admin.Food
{
    partial class AddComponent
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.num_qtt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.num_qtt)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Location = new System.Drawing.Point(3, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // num_qtt
            // 
            this.num_qtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_qtt.Location = new System.Drawing.Point(203, 21);
            this.num_qtt.Name = "num_qtt";
            this.num_qtt.Size = new System.Drawing.Size(44, 20);
            this.num_qtt.TabIndex = 2;
            this.num_qtt.ValueChanged += new System.EventHandler(this.num_qtt_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị tính:";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dvt.Location = new System.Drawing.Point(122, 21);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(56, 20);
            this.txt_dvt.TabIndex = 5;
            this.txt_dvt.TextChanged += new System.EventHandler(this.txt_dvt_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_delete.IconColor = System.Drawing.Color.Black;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.IconSize = 12;
            this.btn_delete.Location = new System.Drawing.Point(253, 21);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 20);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // AddComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_qtt);
            this.Controls.Add(this.txt_name);
            this.Name = "AddComponent";
            this.Size = new System.Drawing.Size(282, 49);
            ((System.ComponentModel.ISupportInitialize)(this.num_qtt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown num_qtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dvt;
        private FontAwesome.Sharp.IconButton btn_delete;
    }
}
