namespace RoundSolitareGame
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TopBar_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.TopBar_GenerateGame = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopBar_File,
            this.TopBar_GenerateGame});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TopBar_File
            // 
            this.TopBar_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TopBar_File.Image = ((System.Drawing.Image)(resources.GetObject("TopBar_File.Image")));
            this.TopBar_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopBar_File.Name = "TopBar_File";
            this.TopBar_File.Size = new System.Drawing.Size(43, 22);
            this.TopBar_File.Text = "Files";
            this.TopBar_File.ToolTipText = "Files";
            // 
            // TopBar_GenerateGame
            // 
            this.TopBar_GenerateGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TopBar_GenerateGame.Image = ((System.Drawing.Image)(resources.GetObject("TopBar_GenerateGame.Image")));
            this.TopBar_GenerateGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopBar_GenerateGame.Name = "TopBar_GenerateGame";
            this.TopBar_GenerateGame.Size = new System.Drawing.Size(92, 22);
            this.TopBar_GenerateGame.Text = "Generate Game";
            this.TopBar_GenerateGame.Click += new System.EventHandler(this.TopBar_GenerateGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton TopBar_File;
        private System.Windows.Forms.ToolStripButton TopBar_GenerateGame;
    }
}

