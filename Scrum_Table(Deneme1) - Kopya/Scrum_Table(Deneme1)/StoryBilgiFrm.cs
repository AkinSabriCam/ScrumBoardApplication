﻿using System;
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
        SqlConnection Baglanti = new SqlConnection("server=AKıN;DataBase=ScrumBoard; Integrated Security=true");
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
            Baglanti.Open();
            SqlCommand Komut = new SqlCommand //Story Table dan veri silinmesi işlemi yapılan komut
                ("Delete from Story_Table where Ad='" + ad + "'", Baglanti);
            Komut.ExecuteNonQuery();

            //yukarıda story table dan istenilen veriyi sildi yukarıda işimiz yok..


             SqlCommand Komut1 = new SqlCommand//Scrum_Table dan story'nin bulunduğu satırın silme işlemi yapılan komut
                ("Delete from Scrum_Table where Story='" + ad + "'", Baglanti);
            Komut1.ExecuteNonQuery();

            SqlCommand TaskKomut = new SqlCommand
                ("Select *from Task_Table where [Story Adı]='"+ad+"'", Baglanti);
            SqlDataAdapter da = new SqlDataAdapter(TaskKomut);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            TaskKomut.ExecuteNonQuery();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SqlCommand Kom = new SqlCommand
           ("Delete from Scrum_Table where [Not Started]='" + dt.Rows[i][1].ToString() + "' OR  [In Progress]='" + dt.Rows[i][1].ToString() + "'OR Done='" + dt.Rows[i][1].ToString() + "' ", Baglanti);
                Kom.ExecuteNonQuery();
            }     
                
            
            // yukarıda task_table dan tüm verileri çektik ve story ad larını karşılaştırdık  ve scrum tabledan taskları sildik



            SqlCommand TaskSilmeKomut = new SqlCommand
                ("Delete from Task_Table where [Story Adı]='" + ad + "'", Baglanti);
            TaskSilmeKomut.ExecuteNonQuery();
            // task_Table

            Baglanti.Close();
            MessageBox.Show("Story Silme  işlemi tamamlanmıştır..");
            ScrumForm sfrm = new ScrumForm();
            sfrm.Show();
            this.Hide();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand Komut = new SqlCommand
            ("Update Story_Table SET Ad=@ad,Yazar=@yazar,Tarih=@tarih,Açıklama=@aciklama Where Ad='"+ad+"'", Baglanti);

            Komut.Parameters.AddWithValue("@ad", txtAdst.Text);
            Komut.Parameters.AddWithValue("@yazar",txtYazarst.Text);
            Komut.Parameters.AddWithValue("@tarih", txtTarihst.Text);
            Komut.Parameters.AddWithValue("@aciklama", txtDescriptionst.Text);
            Komut.ExecuteNonQuery();
            //Story_Table güncellenmektedir

            SqlCommand Komut1 = new SqlCommand
                ("Update Scrum_Table Set Story=@ad where Story='"+ad+"'", Baglanti);
            Komut1.Parameters.AddWithValue("@ad", txtAdst.Text);
            Komut1.ExecuteNonQuery();
            // Scrum_Table daki story ler bölümündeki story adı güncellenmektedi


            SqlCommand Komut2 = new SqlCommand
                ("Update Task_Table Set [Story Adı]=@ad where [Story Adı]='" + ad + "'", Baglanti);
            Komut2.Parameters.AddWithValue("@ad", txtAdst.Text);
            //Task_Table daki story adı güncellenmektedir

            Komut2.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Story Güncelleme  işlemi tamamlanmıştır..");
            ScrumForm sfrm = new ScrumForm();
            sfrm.Show();
            this.Hide();


        }
    }
}
