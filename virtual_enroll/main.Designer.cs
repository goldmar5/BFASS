namespace BFASS
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.PowerMaster10Button = new System.Windows.Forms.Button();
            this.PowerMaster30Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerMaster10Button
            // 
            this.PowerMaster10Button.Image = global::BFASS.Properties.Resources.PM10_300;
            this.PowerMaster10Button.Location = new System.Drawing.Point(3, 24);
            this.PowerMaster10Button.Name = "PowerMaster10Button";
            this.PowerMaster10Button.Size = new System.Drawing.Size(303, 284);
            this.PowerMaster10Button.TabIndex = 7;
            this.PowerMaster10Button.UseVisualStyleBackColor = true;
            this.PowerMaster10Button.Click += new System.EventHandler(this.PowerMaster10Button_Click);
            // 
            // PowerMaster30Button
            // 
            this.PowerMaster30Button.Image = global::BFASS.Properties.Resources.Master_30_300;
            this.PowerMaster30Button.Location = new System.Drawing.Point(312, 24);
            this.PowerMaster30Button.Name = "PowerMaster30Button";
            this.PowerMaster30Button.Size = new System.Drawing.Size(303, 284);
            this.PowerMaster30Button.TabIndex = 6;
            this.PowerMaster30Button.UseVisualStyleBackColor = true;
            this.PowerMaster30Button.Click += new System.EventHandler(this.PowerMaster30Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenu,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(52, 20);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 309);
            this.Controls.Add(this.PowerMaster10Button);
            this.Controls.Add(this.PowerMaster30Button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Power Master Suite";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PowerMaster30Button;
        private System.Windows.Forms.Button PowerMaster10Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
    }
}

