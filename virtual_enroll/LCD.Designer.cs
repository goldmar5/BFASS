namespace BFASS
{
    partial class LCD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCD));
            this.LCDlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LCDlabel
            // 
            this.LCDlabel.AutoSize = true;
            this.LCDlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCDlabel.Font = new System.Drawing.Font("OCR A Extended", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDlabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LCDlabel.Image = global::BFASS.Properties.Resources.pm30_LCDnew;
            this.LCDlabel.Location = new System.Drawing.Point(0, 0);
            this.LCDlabel.MinimumSize = new System.Drawing.Size(395, 95);
            this.LCDlabel.Name = "LCDlabel";
            this.LCDlabel.Size = new System.Drawing.Size(395, 95);
            this.LCDlabel.TabIndex = 433;
            this.LCDlabel.Text = "Unavailable.....";
            this.LCDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 96);
            this.Controls.Add(this.LCDlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LCD";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCDlabel;
        private System.Windows.Forms.Timer timer1;
    }
}