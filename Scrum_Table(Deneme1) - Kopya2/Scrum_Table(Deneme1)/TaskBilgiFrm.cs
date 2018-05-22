using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Scrum_Table_Deneme1_
{
    public partial class TaskBilgiFrm : Form
    {
        public string kisi = "";
        public string ad = "";
        public string task = "";
        public string tarih = "";
        public TaskBilgiFrm()
        {
            InitializeComponent();
        }

        DBConnect connect = new DBConnect();

        private void TaskBilgiFrm_Load(object sender, EventArgs e)
        {
            this.txtKisitb.Text = kisi;
            this.txtTaskAdıtb.Text = ad;
            this.txtTasktb.Text = task;
            this.txtTaskTarih.Text = tarih;
        }

        private void taskGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGuncelle.Visible = true;
            btnSil.Visible = false;
        }

        private void taskSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSil.Visible = true;
            btnGuncelle.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connect.DeleteTaskTable(ad);

            MessageBox.Show("Silme İşlemi Gerçekleşmiştir.");
            this.Hide();
            ScrumForm scr = new ScrumForm();
            scr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //TaskTable'daki veriler güncelleniyor.
            connect.UpdateTaskTable(ad,txtTaskAdıtb.Text, txtKisitb.Text, txtTasktb.Text, txtTaskTarih.Text);

            //ScrumTable'daki tasklar güncelleniyor.
            connect.UpdateTask_inScrumTable(ad, txtTaskAdıtb.Text);

            MessageBox.Show("Güncelleme İşlemi Gerçekleşmiştir.");

            ScrumForm scr = new ScrumForm();
            this.Hide();    
            scr.Show();
        }
    }
}
