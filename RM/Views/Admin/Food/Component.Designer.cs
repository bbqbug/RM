namespace RM.Views.Admin.Food
{
    partial class Component
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_dvt = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lb_dvt
            // 
            this.lb_dvt.AutoSize = true;
            this.lb_dvt.Location = new System.Drawing.Point(109, 15);
            this.lb_dvt.Name = "lb_dvt";
            this.lb_dvt.Size = new System.Drawing.Size(36, 13);
            this.lb_dvt.TabIndex = 1;
            this.lb_dvt.Text = "lb_dvt";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(150, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
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
            this.btn_delete.Location = new System.Drawing.Point(210, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(25, 20);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lb_dvt);
            this.Controls.Add(this.comboBox1);
            this.Name = "Component";
            this.Size = new System.Drawing.Size(242, 42);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_dvt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private FontAwesome.Sharp.IconButton btn_delete;
    }
}
