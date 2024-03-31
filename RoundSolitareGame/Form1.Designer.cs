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
            this.TopBar = new System.Windows.Forms.ToolStrip();
            this.TopBar_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.TopBar_GenerateGame = new System.Windows.Forms.ToolStripButton();
            this.MainLayoutParent = new System.Windows.Forms.TableLayoutPanel();
            this.RightLayoutParent = new System.Windows.Forms.TableLayoutPanel();
            this.LBLTimer = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            this.MainLayoutParent.SuspendLayout();
            this.RightLayoutParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TopBar_File,
            this.TopBar_GenerateGame});
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(800, 25);
            this.TopBar.TabIndex = 0;
            this.TopBar.Text = "toolStrip1";
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
            // MainLayoutParent
            // 
            this.MainLayoutParent.ColumnCount = 2;
            this.MainLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayoutParent.Controls.Add(this.RightLayoutParent, 1, 0);
            this.MainLayoutParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutParent.Location = new System.Drawing.Point(0, 25);
            this.MainLayoutParent.Name = "MainLayoutParent";
            this.MainLayoutParent.RowCount = 1;
            this.MainLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 425F));
            this.MainLayoutParent.Size = new System.Drawing.Size(800, 425);
            this.MainLayoutParent.TabIndex = 1;
            // 
            // RightLayoutParent
            // 
            this.RightLayoutParent.ColumnCount = 1;
            this.RightLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RightLayoutParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RightLayoutParent.Controls.Add(this.LBLTimer, 0, 0);
            this.RightLayoutParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLayoutParent.Location = new System.Drawing.Point(643, 3);
            this.RightLayoutParent.Name = "RightLayoutParent";
            this.RightLayoutParent.RowCount = 2;
            this.RightLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02387F));
            this.RightLayoutParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.97614F));
            this.RightLayoutParent.Size = new System.Drawing.Size(154, 419);
            this.RightLayoutParent.TabIndex = 0;
            // 
            // LBLTimer
            // 
            this.LBLTimer.AutoSize = true;
            this.LBLTimer.Location = new System.Drawing.Point(3, 0);
            this.LBLTimer.Name = "LBLTimer";
            this.LBLTimer.Size = new System.Drawing.Size(35, 13);
            this.LBLTimer.TabIndex = 0;
            this.LBLTimer.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLayoutParent);
            this.Controls.Add(this.TopBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.MainLayoutParent.ResumeLayout(false);
            this.RightLayoutParent.ResumeLayout(false);
            this.RightLayoutParent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopBar;
        private System.Windows.Forms.ToolStripDropDownButton TopBar_File;
        private System.Windows.Forms.ToolStripButton TopBar_GenerateGame;
        private System.Windows.Forms.TableLayoutPanel MainLayoutParent;
        private System.Windows.Forms.TableLayoutPanel RightLayoutParent;
        private System.Windows.Forms.Label LBLTimer;
    }
}

