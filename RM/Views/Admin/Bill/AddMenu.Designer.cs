namespace RM.Views.Admin.Bill
{
    partial class AddMenu
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
            this.cbb_menu = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_menu
            // 
            this.cbb_menu.FormattingEnabled = true;
            this.cbb_menu.Location = new System.Drawing.Point(3, 12);
            this.cbb_menu.Name = "cbb_menu";
            this.cbb_menu.Size = new System.Drawing.Size(126, 21);
            this.cbb_menu.TabIndex = 1;
            this.cbb_menu.SelectedValueChanged += new System.EventHandler(this.cbb_menu_SelectedValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(151, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btn_delete.IconColor = System.Drawing.Color.Black;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.IconSize = 12;
            this.btn_delete.Location = new System.Drawing.Point(194, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 20);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // AddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbb_menu);
            this.Name = "AddMenu";
            this.Size = new System.Drawing.Size(220, 45);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_menu;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton btn_delete;
    }
}
