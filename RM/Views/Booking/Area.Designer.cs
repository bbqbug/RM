namespace RM.Views.Booking
{
    partial class Area
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
            this.lb_timeofarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_timeofarea
            // 
            this.lb_timeofarea.AutoSize = true;
            this.lb_timeofarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeofarea.Location = new System.Drawing.Point(46, 22);
            this.lb_timeofarea.Name = "lb_timeofarea";
            this.lb_timeofarea.Size = new System.Drawing.Size(57, 24);
            this.lb_timeofarea.TabIndex = 0;
            this.lb_timeofarea.Text = "Time";
            // 
            // Area
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lb_timeofarea);
            this.ForeColor = System.Drawing.Color.SeaGreen;
            this.Name = "Area";
            this.Size = new System.Drawing.Size(150, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_timeofarea;
    }
}
