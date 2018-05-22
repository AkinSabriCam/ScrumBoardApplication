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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        { if ((txtKisi1.Text != "" && txtTaskAdi1.Text != "" && txtTask1.Text != "" && txtTaskTarih1.Text != "") ||
             (txtKisi2.Text != "" && txtTaskAdi2.Text != "" && txtTask2.Text != "" && txtTaskTarih2.Text != ""))
            {

                SqlConnection Baglanti = new SqlConnection("server=AKıN;Database=ScrumBoard;Integrated Security=true");
                Baglanti.Open();
                SqlCommand Komut = new SqlCommand
                    ("INSERT INTO Story_Table(Ad,Yazar,Tarih,Açıklama) values(@ad,@yazar,@tarih,@aciklama) ", Baglanti);
                Komut.Parameters.AddWithValue("@ad", txtAd.Text);
                Komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                Komut.Parameters.AddWithValue("@tarih", txtTarih.Text);
                Komut.Parameters.AddWithValue("@aciklama", txtDescription.Text);
                Komut.ExecuteNonQuery();


                SqlCommand Komut1 = new SqlCommand
                    ("INSERT INTO Task_Table( Kisi,[Task Adı],[Task Bilgisi],Tarih,[Story Adı]) values(@kisi,@taskadi,@taskbilgi,@tar,@storyad) ", Baglanti);
                Komut1.Parameters.AddWithValue("@kisi", txtKisi1.Text);
                Komut1.Parameters.AddWithValue("@taskadi", txtTaskAdi1.Text);
                Komut1.Parameters.AddWithValue("@taskbilgi", txtTask1.Text);
                Komut1.Parameters.AddWithValue("@tar", txtTaskTarih1.Text);
                Komut1.Parameters.AddWithValue("@storyad", txtAd.Text);
                Komut1.ExecuteNonQuery();

                SqlCommand Komut2 = new SqlCommand
                    ("INSERT INTO Task_Table(Kisi,[Task Adı],[Task Bilgisi],Tarih,[Story Adı]) values(@kisi,@taskadi,@taskbilgi,@tar,@storyadi) ", Baglanti);
                Komut2.Parameters.AddWithValue("@kisi", txtKisi2.Text);
                Komut2.Parameters.AddWithValue("@taskadi", txtTaskAdi2.Text);
                Komut2.Parameters.AddWithValue("@taskbilgi", txtTask2.Text);
                Komut2.Parameters.AddWithValue("@tar", txtTaskTarih2.Text);
                Komut2.Parameters.AddWithValue("@storyadi", txtAd.Text);
                Komut2.ExecuteNonQuery();

                SqlCommand Komut3 = new SqlCommand
                    ("INSERT INTO Scrum_Table(Story,[Not Started]) values(@story,@not) ", Baglanti);
                Komut3.Parameters.AddWithValue("@story", txtAd.Text);
                Komut3.Parameters.AddWithValue("@not", txtTaskAdi1.Text);
                Komut3.ExecuteNonQuery();

                SqlCommand Komut4 = new SqlCommand
                        ("INSERT INTO Scrum_Table(Story,[Not Started]) values(NULL,@not) ", Baglanti);
                Komut4.Parameters.AddWithValue("@not", txtTaskAdi2.Text);
                Komut4.ExecuteNonQuery();


                Baglanti.Close();
            }
            else
                MessageBox.Show("Lütfen Task'ı eksiksiz ekleyiniz");

            MessageBox.Show("Story Ekleme İşlemi Tamamlanmıştır..");
            ScrumForm scrfrm = new ScrumForm();
            scrfrm.Show();
            this.Hide();

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
