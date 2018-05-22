namespace Scrum_Table_Deneme1_
{
    partial class StoryForm
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTaskTarih2 = new System.Windows.Forms.TextBox();
            this.txtTaskTarih1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTaskAdi2 = new System.Windows.Forms.TextBox();
            this.txtTaskAdi1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTask2 = new System.Windows.Forms.TextBox();
            this.txtKisi2 = new System.Windows.Forms.TextBox();
            this.txtTask1 = new System.Windows.Forms.TextBox();
            this.txtKisi1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEkle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Linen;
            this.btnEkle.Location = new System.Drawing.Point(323, 475);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 59);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Story Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtYazar);
            this.groupBox1.Controls.Add(this.txtTarih);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 294);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Story Bilgileri";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 141);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(617, 134);
            this.txtDescription.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(93, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Açıklama:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(205, 56);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(188, 27);
            this.txtYazar.TabIndex = 13;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(205, 88);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(188, 27);
            this.txtTarih.TabIndex = 12;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(205, 24);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(188, 27);
            this.txtAd.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Story Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(73, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Story Yazarı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Story Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTaskTarih2);
            this.groupBox2.Controls.Add(this.txtTaskTarih1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTaskAdi2);
            this.groupBox2.Controls.Add(this.txtTaskAdi1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTask2);
            this.groupBox2.Controls.Add(this.txtKisi2);
            this.groupBox2.Controls.Add(this.txtTask1);
            this.groupBox2.Controls.Add(this.txtKisi1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 142);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task Bilgileri";
            // 
            // txtTaskTarih2
            // 
            this.txtTaskTarih2.Location = new System.Drawing.Point(756, 96);
            this.txtTaskTarih2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskTarih2.Multiline = true;
            this.txtTaskTarih2.Name = "txtTaskTarih2";
            this.txtTaskTarih2.Size = new System.Drawing.Size(143, 27);
            this.txtTaskTarih2.TabIndex = 32;
            // 
            // txtTaskTarih1
            // 
            this.txtTaskTarih1.Location = new System.Drawing.Point(756, 57);
            this.txtTaskTarih1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskTarih1.Multiline = true;
            this.txtTaskTarih1.Name = "txtTaskTarih1";
            this.txtTaskTarih1.Size = new System.Drawing.Size(143, 27);
            this.txtTaskTarih1.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(769, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Tarih";
            // 
            // txtTaskAdi2
            // 
            this.txtTaskAdi2.Location = new System.Drawing.Point(161, 96);
            this.txtTaskAdi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskAdi2.Multiline = true;
            this.txtTaskAdi2.Name = "txtTaskAdi2";
            this.txtTaskAdi2.Size = new System.Drawing.Size(143, 27);
            this.txtTaskAdi2.TabIndex = 29;
            // 
            // txtTaskAdi1
            // 
            this.txtTaskAdi1.Location = new System.Drawing.Point(161, 57);
            this.txtTaskAdi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaskAdi1.Multiline = true;
            this.txtTaskAdi1.Name = "txtTaskAdi1";
            this.txtTaskAdi1.Size = new System.Drawing.Size(143, 27);
            this.txtTaskAdi1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(188, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Task Adı";
            // 
            // txtTask2
            // 
            this.txtTask2.Location = new System.Drawing.Point(311, 96);
            this.txtTask2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTask2.Name = "txtTask2";
            this.txtTask2.Size = new System.Drawing.Size(439, 27);
            this.txtTask2.TabIndex = 26;
            // 
            // txtKisi2
            // 
            this.txtKisi2.Location = new System.Drawing.Point(14, 96);
            this.txtKisi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKisi2.Multiline = true;
            this.txtKisi2.Name = "txtKisi2";
            this.txtKisi2.Size = new System.Drawing.Size(141, 27);
            this.txtKisi2.TabIndex = 25;
            // 
            // txtTask1
            // 
            this.txtTask1.BackColor = System.Drawing.Color.White;
            this.txtTask1.Location = new System.Drawing.Point(311, 57);
            this.txtTask1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTask1.Name = "txtTask1";
            this.txtTask1.Size = new System.Drawing.Size(439, 27);
            this.txtTask1.TabIndex = 24;
            // 
            // txtKisi1
            // 
            this.txtKisi1.Location = new System.Drawing.Point(14, 57);
            this.txtKisi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKisi1.Multiline = true;
            this.txtKisi1.Name = "txtKisi1";
            this.txtKisi1.Size = new System.Drawing.Size(141, 27);
            this.txtKisi1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(471, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tasks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kişiler";
            // 
            // StoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(945, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StoryForm";
            this.Text = "StoryForm";
            this.Load += new System.EventHandler(this.StoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTaskTarih2;
        private System.Windows.Forms.TextBox txtTaskTarih1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTaskAdi2;
        private System.Windows.Forms.TextBox txtTaskAdi1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTask2;
        private System.Windows.Forms.TextBox txtKisi2;
        private System.Windows.Forms.TextBox txtTask1;
        private System.Windows.Forms.TextBox txtKisi1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}