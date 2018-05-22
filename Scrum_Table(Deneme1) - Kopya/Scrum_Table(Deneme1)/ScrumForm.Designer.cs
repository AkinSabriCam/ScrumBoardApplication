namespace Scrum_Table_Deneme1_
{
    partial class ScrumForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStory = new System.Windows.Forms.Button();
            this.btnNotStarted = new System.Windows.Forms.Button();
            this.btnInProgress = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.panelStory = new System.Windows.Forms.Panel();
            this.panelNot = new System.Windows.Forms.Panel();
            this.panelProgres = new System.Windows.Forms.Panel();
            this.panelDone = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStory);
            this.flowLayoutPanel1.Controls.Add(this.btnNotStarted);
            this.flowLayoutPanel1.Controls.Add(this.btnInProgress);
            this.flowLayoutPanel1.Controls.Add(this.btnDone);
            this.flowLayoutPanel1.Controls.Add(this.panelStory);
            this.flowLayoutPanel1.Controls.Add(this.panelNot);
            this.flowLayoutPanel1.Controls.Add(this.panelProgres);
            this.flowLayoutPanel1.Controls.Add(this.panelDone);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(73, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(982, 616);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnStory
            // 
            this.btnStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnStory.Enabled = false;
            this.btnStory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStory.Location = new System.Drawing.Point(3, 3);
            this.btnStory.Name = "btnStory";
            this.btnStory.Size = new System.Drawing.Size(237, 61);
            this.btnStory.TabIndex = 0;
            this.btnStory.Text = "STORY";
            this.btnStory.UseVisualStyleBackColor = false;
            // 
            // btnNotStarted
            // 
            this.btnNotStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNotStarted.Enabled = false;
            this.btnNotStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotStarted.Location = new System.Drawing.Point(246, 3);
            this.btnNotStarted.Name = "btnNotStarted";
            this.btnNotStarted.Size = new System.Drawing.Size(237, 61);
            this.btnNotStarted.TabIndex = 1;
            this.btnNotStarted.Text = "NOT STARTED";
            this.btnNotStarted.UseVisualStyleBackColor = false;
            // 
            // btnInProgress
            // 
            this.btnInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnInProgress.Enabled = false;
            this.btnInProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInProgress.Location = new System.Drawing.Point(489, 3);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Size = new System.Drawing.Size(237, 61);
            this.btnInProgress.TabIndex = 2;
            this.btnInProgress.Text = "IN PROGRESS";
            this.btnInProgress.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDone.Enabled = false;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDone.Location = new System.Drawing.Point(732, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(237, 61);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // panelStory
            // 
            this.panelStory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStory.Location = new System.Drawing.Point(3, 70);
            this.panelStory.Name = "panelStory";
            this.panelStory.Size = new System.Drawing.Size(237, 535);
            this.panelStory.TabIndex = 4;
            // 
            // panelNot
            // 
            this.panelNot.AllowDrop = true;
            this.panelNot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNot.Location = new System.Drawing.Point(246, 70);
            this.panelNot.Name = "panelNot";
            this.panelNot.Size = new System.Drawing.Size(237, 535);
            this.panelNot.TabIndex = 5;
            // 
            // panelProgres
            // 
            this.panelProgres.AllowDrop = true;
            this.panelProgres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgres.Location = new System.Drawing.Point(489, 70);
            this.panelProgres.Name = "panelProgres";
            this.panelProgres.Size = new System.Drawing.Size(237, 535);
            this.panelProgres.TabIndex = 5;
            // 
            // panelDone
            // 
            this.panelDone.AllowDrop = true;
            this.panelDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDone.Location = new System.Drawing.Point(732, 70);
            this.panelDone.Name = "panelDone";
            this.panelDone.Size = new System.Drawing.Size(237, 535);
            this.panelDone.TabIndex = 5;
            // 
            // ScrumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 653);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ScrumForm";
            this.Text = "ScrumForm";
            this.Load += new System.EventHandler(this.ScrumForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnStory;
        private System.Windows.Forms.Button btnNotStarted;
        private System.Windows.Forms.Button btnInProgress;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panelStory;
        private System.Windows.Forms.Panel panelNot;
        private System.Windows.Forms.Panel panelProgres;
        private System.Windows.Forms.Panel panelDone;
    }
}