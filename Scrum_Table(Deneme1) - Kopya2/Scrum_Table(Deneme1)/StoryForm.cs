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
    public partial class StoryForm : Form
    {
        public StoryForm()
        {
            InitializeComponent();
        }

        DBConnect connect = new DBConnect();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if ((txtKisi1.Text != "" && txtTaskAdi1.Text != "" && txtTask1.Text != "" && txtTaskTarih1.Text != "") ||
             (txtKisi2.Text != "" && txtTaskAdi2.Text != "" && txtTask2.Text != "" && txtTaskTarih2.Text != ""))
            {
                //StoryTable'a Story Ekleme
                connect.InsertStoryTable(txtAd.Text,txtYazar.Text,txtDescription.Text, txtTarih.Text);

                //TaskTable'a Task Ekleme
                connect.InsertTaskTable(txtKisi1.Text, txtTaskAdi1.Text, txtTask1.Text, txtTaskTarih1.Text, txtAd.Text);

                //TaskTable'a Task Ekleme
                connect.InsertTaskTable(txtKisi2.Text, txtTaskAdi2.Text, txtTask2.Text, txtTaskTarih2.Text, txtAd.Text);

                //ScrumTable'a Task Ekleme
                connect.InsertScrumTable(txtAd.Text, txtTaskAdi1.Text);

                //TaskTable'a Task Ekleme
                connect.InsertScrumTable("",txtTaskAdi2.Text);

                MessageBox.Show("Ekleme İşlemi Başarıyla Gerçekleşmiştir!");
            }
            else
                MessageBox.Show("Lütfen Task'ı eksiksiz ekleyiniz");

            ScrumForm scr = new ScrumForm();
            this.Hide();
            scr.Show();
           
        }      
    }
}
