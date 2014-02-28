namespace BFASS
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.helpText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // helpText
            // 
            this.helpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpText.Enabled = false;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.FormattingEnabled = true;
            this.helpText.ItemHeight = 18;
            this.helpText.Items.AddRange(new object[] {
            "For generate faults --> Right button Mouse Click on Zone ID"});
            this.helpText.Location = new System.Drawing.Point(0, 0);
            this.helpText.MultiColumn = true;
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(559, 164);
            this.helpText.TabIndex = 0;
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 164);
            this.Controls.Add(this.helpText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox helpText;
    }
}