namespace Scrum_Table_Deneme1_
{
    partial class TaskBilgiFrm
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
            this.txtTaskAdıtb = new System.Windows.Forms.TextBox();
            this.txtTasktb = new System.Windows.Forms.TextBox();
            this.txtKisitb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskTarih = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taskGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTaskAdıtb
            // 
            this.txtTaskAdıtb.Location = new System.Drawing.Point(189, 110);
            this.txtTaskAdıtb.Multiline = true;
            this.txtTaskAdıtb.Name = "txtTaskAdıtb";
            this.txtTaskAdıtb.Size = new System.Drawing.Size(143, 22);
            this.txtTaskAdıtb.TabIndex = 20;
            // 
            // txtTasktb
            // 
            this.txtTasktb.Location = new System.Drawing.Point(189, 217);
            this.txtTasktb.Multiline = true;
            this.txtTasktb.Name = "txtTasktb";
            this.txtTasktb.Size = new System.Drawing.Size(464, 84);
            this.txtTasktb.TabIndex = 19;
            // 
            // txtKisitb
            // 
            this.txtKisitb.Location = new System.Drawing.Point(189, 65);
            this.txtKisitb.Name = "txtKisitb";
            this.txtKisitb.Size = new System.Drawing.Size(143, 22);
            this.txtKisitb.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "KiŞİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "TASK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "TASK ADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "TARİH:";
            // 
            // txtTaskTarih
            // 
            this.txtTaskTarih.Location = new System.Drawing.Point(189, 162);
            this.txtTaskTarih.Multiline = true;
            this.txtTaskTarih.Name = "txtTaskTarih";
            this.txtTaskTarih.Size = new System.Drawing.Size(143, 22);
            this.txtTaskTarih.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskGüncelleToolStripMenuItem,
            this.taskSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taskGüncelleToolStripMenuItem
            // 
            this.taskGüncelleToolStripMenuItem.Name = "taskGüncelleToolStripMenuItem";
            this.taskGüncelleToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.taskGüncelleToolStripMenuItem.Text = "Task Güncelle";
            this.taskGüncelleToolStripMenuItem.Click += new System.EventHandler(this.taskGüncelleToolStripMenuItem_Click);
            // 
            // taskSilToolStripMenuItem
            // 
            this.taskSilToolStripMenuItem.Name = "taskSilToolStripMenuItem";
            this.taskSilToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.taskSilToolStripMenuItem.Text = "Task Sil";
            this.taskSilToolStripMenuItem.Click += new System.EventHandler(this.taskSilToolStripMenuItem_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(273, 352);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(134, 41);
            this.btnGuncelle.TabIndex = 27;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(273, 352);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 41);
            this.btnSil.TabIndex = 28;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // TaskBilgiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtTaskTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaskAdıtb);
            this.Controls.Add(this.txtTasktb);
            this.Controls.Add(this.txtKisitb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TaskBilgiFrm";
            this.Text = "TaskBilgiFrm";
            this.Load += new System.EventHandler(this.TaskBilgiFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaskAdıtb;
        private System.Windows.Forms.TextBox txtTasktb;
        private System.Windows.Forms.TextBox txtKisitb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskTarih;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taskGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskSilToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}