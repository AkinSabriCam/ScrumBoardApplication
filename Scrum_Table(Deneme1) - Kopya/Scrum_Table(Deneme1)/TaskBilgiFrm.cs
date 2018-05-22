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

            SqlConnection Baglanti = new SqlConnection("server=AKıN;Database=ScrumBoard;Integrated Security=true");
            Baglanti.Open();
            SqlCommand Komut = new SqlCommand
           ("Delete from Task_Table where [Task Adı]='" + ad + "'", Baglanti);
            Komut.ExecuteNonQuery();

            SqlCommand Komut1 = new SqlCommand
           ("Update Scrum_Table  Set [Not Started]=Null   where  [Not Started]='" + ad + "'", Baglanti);
            SqlCommand Komut2 = new SqlCommand
           ("Update Scrum_Table  Set [In Progress]=Null   where  [In Progress]='" + ad + "'", Baglanti);
            SqlCommand Komut3 = new SqlCommand
         ("Update Scrum_Table  Set Done=Null   where  Done='" + ad + "'", Baglanti);
            Komut1.ExecuteNonQuery();
            Komut2.ExecuteNonQuery();
            Komut3.ExecuteNonQuery();

            Baglanti.Close();

            MessageBox.Show("Task Silme  işlemi tamamlanmıştır..");
            ScrumForm sfrm = new ScrumForm();
            sfrm.Show();
            this.Hide();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection("server=AKıN;Database=ScrumBoard;Integrated security=true");
            Baglanti.Open();
            SqlCommand Komut = new SqlCommand
            ("Update Task_Table Set Kisi=@kisi,[Task Adı]=@ad,[Task Bilgisi]=@bilgi,Tarih=@tarih  where [Task Adı]='" + ad + "'", Baglanti);
            Komut.Parameters.AddWithValue("@ad", txtTaskAdıtb.Text);
            Komut.Parameters.AddWithValue("@bilgi", txtTasktb.Text);
            Komut.Parameters.AddWithValue("@kisi", txtKisitb.Text);
            Komut.Parameters.AddWithValue("@tarih", txtTaskTarih.Text);
            Komut.ExecuteNonQuery();
            // Task_Table daki bilgileri update etmiştir yukarıdaki komut!!


            SqlCommand Komut1 = new SqlCommand
                 ("Update Scrum_Table Set [Not Started]='" + txtTaskAdıtb.Text + "'  where [Not Started]='" + ad + "'", Baglanti);
            SqlCommand Komut2 = new SqlCommand
                 ("Update Scrum_Table Set [Not Started]='" + txtTaskAdıtb.Text + "',[In Progress]=Null where [In Progress]='" + ad + "'", Baglanti);
            SqlCommand Komut3 = new SqlCommand
                 ("Update Scrum_Table Set [Not Started]='" + txtTaskAdıtb.Text + "',Done=NULL  where Done='" + ad + "'", Baglanti);
            Komut1.ExecuteNonQuery();
            Komut2.ExecuteNonQuery();
            Komut3.ExecuteNonQuery();
            // Yukarıdaki komutlar  Task'ın scrum table daki bulunduğu konuma göre sorgu yapıp ismini update etmiştir

            Baglanti.Close();
            MessageBox.Show("Task Güncelleme  işlemi tamamlanmıştır..");
            ScrumForm sfrm = new ScrumForm();
            sfrm.Show();
            this.Hide();


        }
    }
}
