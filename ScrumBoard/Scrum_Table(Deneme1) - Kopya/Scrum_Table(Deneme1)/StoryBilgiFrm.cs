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
    public partial class StoryBilgiFrm : Form
    {
        public string ad = "";
        public string yazar = "";
        public string tarih = "";
        public string description = "";


        DBConnect connect = new DBConnect();

        public StoryBilgiFrm()
        {
            InitializeComponent();
        }

        private void StoryBilgiFrm_Load(object sender, EventArgs e)
        {
            txtAdst.Text = ad;
            txtYazarst.Text = yazar;
            txtTarihst.Text = tarih;
            txtDescriptionst.Text = description;
        }

        private void storyGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnGuncelle.Visible = true;
            btnSil.Visible = false;
        }

        private void storySilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSil.Visible = true;
            btnGuncelle.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e) 
        {
            btnGuncelle.Visible = false;
            btnSil.Visible = true;
            connect.DeleteStoryTable(ad);
            connect.DeleteScrumTable(ad);
            connect.DeleteTask_inScrumTable(ad);
            connect.DeleteStory_inTaskTable(ad);
            MessageBox.Show("Silme İşlemi Gerçekleşmiştir.");
            this.Hide();
            ScrumForm scr = new ScrumForm();
            scr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            btnGuncelle.Visible = true;
            btnSil.Visible = false;
            connect.UpdateStoryTable(ad,txtAdst.Text, txtYazarst.Text, txtTarihst.Text, txtDescriptionst.Text);
            connect.UpdateStory_inScrumTable(ad,txtAdst.Text);
            connect.UpdateStory_inTaskTable(ad);
            
            MessageBox.Show("Güncelleme İşlemi Gerçekleşmiştir.");
            this.Hide();
            ScrumForm scr = new ScrumForm();
            scr.Show();
        }
    }
}
