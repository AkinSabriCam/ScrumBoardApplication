namespace Scrum_Table_Deneme1_
{
    partial class StoryBilgiFrm
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
            this.storyGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storySilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescriptionst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarst = new System.Windows.Forms.TextBox();
            this.txtTarihst = new System.Windows.Forms.TextBox();
            this.txtAdst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storyGüncelleToolStripMenuItem,
            this.storySilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storyGüncelleToolStripMenuItem
            // 
            this.storyGüncelleToolStripMenuItem.Name = "storyGüncelleToolStripMenuItem";
            this.storyGüncelleToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.storyGüncelleToolStripMenuItem.Text = "Story Güncelle";
            this.storyGüncelleToolStripMenuItem.Click += new System.EventHandler(this.storyGüncelleToolStripMenuItem_Click);
            // 
            // storySilToolStripMenuItem
            // 
            this.storySilToolStripMenuItem.Name = "storySilToolStripMenuItem";
            this.storySilToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.storySilToolStripMenuItem.Text = "Story Sil";
            this.storySilToolStripMenuItem.Click += new System.EventHandler(this.storySilToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Linen;
            this.btnGuncelle.Location = new System.Drawing.Point(394, 399);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(146, 55);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSil.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Linen;
            this.btnSil.Location = new System.Drawing.Point(394, 399);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(146, 55);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescriptionst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYazarst);
            this.groupBox1.Controls.Add(this.txtTarihst);
            this.groupBox1.Controls.Add(this.txtAdst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(51, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 303);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Story Bilgileri";
            // 
            // txtDescriptionst
            // 
            this.txtDescriptionst.Location = new System.Drawing.Point(195, 182);
            this.txtDescriptionst.Multiline = true;
            this.txtDescriptionst.Name = "txtDescriptionst";
            this.txtDescriptionst.Size = new System.Drawing.Size(608, 111);
            this.txtDescriptionst.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(77, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Description:";
            // 
            // txtYazarst
            // 
            this.txtYazarst.Location = new System.Drawing.Point(204, 68);
            this.txtYazarst.Name = "txtYazarst";
            this.txtYazarst.Size = new System.Drawing.Size(154, 27);
            this.txtYazarst.TabIndex = 31;
            // 
            // txtTarihst
            // 
            this.txtTarihst.Location = new System.Drawing.Point(204, 101);
            this.txtTarihst.Name = "txtTarihst";
            this.txtTarihst.Size = new System.Drawing.Size(154, 27);
            this.txtTarihst.TabIndex = 30;
            // 
            // txtAdst
            // 
            this.txtAdst.Location = new System.Drawing.Point(204, 33);
            this.txtAdst.Name = "txtAdst";
            this.txtAdst.Size = new System.Drawing.Size(154, 27);
            this.txtAdst.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Story Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Story Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Story Adı:";
            // 
            // StoryBilgiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(944, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StoryBilgiFrm";
            this.Text = "StoryBilgiFrm";
            this.Load += new System.EventHandler(this.StoryBilgiFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storyGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storySilToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescriptionst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazarst;
        private System.Windows.Forms.TextBox txtTarihst;
        private System.Windows.Forms.TextBox txtAdst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}