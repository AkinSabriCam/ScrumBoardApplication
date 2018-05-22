namespace Scrum_Table_Deneme1_
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pROJEOLUŞTURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storieEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROJEOLUŞTURToolStripMenuItem,
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pROJEOLUŞTURToolStripMenuItem
            // 
            this.pROJEOLUŞTURToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storieEkleToolStripMenuItem});
            this.pROJEOLUŞTURToolStripMenuItem.Name = "pROJEOLUŞTURToolStripMenuItem";
            this.pROJEOLUŞTURToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.pROJEOLUŞTURToolStripMenuItem.Text = "PROJE OLUŞTUR";
            // 
            // storieEkleToolStripMenuItem
            // 
            this.storieEkleToolStripMenuItem.Name = "storieEkleToolStripMenuItem";
            this.storieEkleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.storieEkleToolStripMenuItem.Text = "Story Ekle";
            this.storieEkleToolStripMenuItem.Click += new System.EventHandler(this.storieEkleToolStripMenuItem_Click);
            // 
            // pROJEYİGÖRÜNTÜLEToolStripMenuItem
            // 
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem.Name = "pROJEYİGÖRÜNTÜLEToolStripMenuItem";
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem.Text = "PROJEYİ GÖRÜNTÜLE";
            this.pROJEYİGÖRÜNTÜLEToolStripMenuItem.Click += new System.EventHandler(this.pROJEYİGÖRÜNTÜLEToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(489, 227);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pROJEOLUŞTURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storieEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJEYİGÖRÜNTÜLEToolStripMenuItem;
    }
}

