using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Scrum_Table_Deneme1_
{
    public class DBConnect
    {
        SqlConnection Baglanti = new SqlConnection("server=AKıN;Database=ScrumBoard;Integrated Security=true");
        SqlCommand cmd;

        public DataTable ScrumTable(string name)    //ScrumTable'daki veriler çekiliyor.
        {

            Baglanti.Open();
            switch (name)
            {
                case "Story":
                    cmd = new SqlCommand
                        ("SELECT Story FROM Scrum_Table", Baglanti);  //Scrum_Table tablosunun Story kolonundaki tüm verileri çekiyor.
                    break;
                case "Not Started":
                    cmd = new SqlCommand
                        ("SELECT [Not Started] FROM Scrum_Table", Baglanti);  //Scrum_Table tablosunun Story kolonundaki tüm verileri çekiyor.
                    break;
                case "In Progress":
                    cmd = new SqlCommand
                        ("SELECT [In Progress] FROM Scrum_Table", Baglanti);  //Scrum_Table tablosunun Story kolonundaki tüm verileri çekiyor.
                    break;
                case "Done":
                    cmd = new SqlCommand
                        ("SELECT Done FROM Scrum_Table", Baglanti);  //Scrum_Table tablosunun Story kolonundaki tüm verileri çekiyor.
                    break;
                default :
                    break;
            }
         
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            return dt;


        }
        public DataTable StoryTable(string buttonText)  //StoryTable'daki veriler çekiliyor.
        {
            Baglanti.Open();
            cmd = new SqlCommand
                ("SELECT *FROM Story_Table WHERE Ad='" + buttonText + "'", Baglanti);  //Story_Table'dan adı buttonText olanları çekiyoruz. 

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            return dt;


        }
        public DataTable TaskTable(string buttonText) //TaskTable'daki veriler çekiliyor.
        {
            Baglanti.Open();
            cmd = new SqlCommand
                ("SELECT *FROM Task_Table WHERE [Task Adı]='" + buttonText + "'", Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            return dt;

        }
        public void DragDrop(string name,string controlText)    //Sürükle-Bırak işlemlerinin güncellenmesi yapılıyor.
        {
            Baglanti.Open();
            switch (name)
            {
                case "In Progress":
                    cmd = new SqlCommand
                        ("UPDATE  Scrum_Table SET [In Progress]='" + controlText + "',[Not Started]=NULL WHERE [Not Started]='" + controlText + "'", Baglanti);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand
                        ("UPDATE  Scrum_Table SET [In Progress]='" + controlText + "',Done=NULL WHERE Done='" + controlText + "'", Baglanti);
                    cmd.ExecuteNonQuery();
                    break;

                case "Done":
                    cmd = new SqlCommand
                        ("UPDATE  Scrum_Table SET Done='" + controlText + "',[Not Started]=NULL,[In Progress]=NULL WHERE [In Progress]='" + controlText + "'", Baglanti);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand
                        ("UPDATE  Scrum_Table SET Done='" + controlText + "',[Not Started]=NULL,[In Progress]=NULL WHERE [Not Started]='" + controlText + "'", Baglanti);
                    cmd.ExecuteNonQuery();
                    break;
            }
            Baglanti.Close();
        }

        //STORY TABLE GÜNCELLE SİL İŞLEMLERİ
        public void DeleteStoryTable(string ad) //StoryTable'dan veri siliniyor.
        {
            Baglanti.Open();

            cmd=new SqlCommand
                ("DELETE FROM Story_Table WHERE Ad='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void DeleteScrumTable(string ad) //ScrumTable'dan Story siliniyor.
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("DELETE FROM Scrum_Table WHERE Story='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void DeleteTask_inScrumTable(string ad)  //TaskTable'dan Story Adına göre veriler çekilip ScrumTable'dan siliniyor.
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("SELECT *FROM Task_Table WHERE [Story Adı]='" + ad + "'", Baglanti);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand
                   ("DELETE FROM Scrum_Table WHERE [Not Started]='" + dt.Rows[i][1].ToString() + "' OR  [In Progress]='" + dt.Rows[i][1].ToString() + "'OR Done='" + dt.Rows[i][1].ToString() + "' ", Baglanti);

                cmd.ExecuteNonQuery();
            }

            Baglanti.Close();
        }
        public void DeleteStory_inTaskTable(string ad)  //TaskTable'dan Story siliniyor.
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("DELETE FROM Task_Table WHERE [Story Adı]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void UpdateStoryTable(string ad,string yeniStoryAd, string yeniYazar, string yeniDescription, string yeniTarih)   //StoryTable'daki veriler güncelleniyor.
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("UPDATE Story_Table SET Ad=@ad,Yazar=@yazar,Tarih=@tarih,Açıklama=@aciklama WHERE Ad='" + ad + "'", Baglanti);
            cmd.Parameters.AddWithValue("@ad", yeniStoryAd);
            cmd.Parameters.AddWithValue("@yazar", yeniYazar);
            cmd.Parameters.AddWithValue("@tarih", yeniTarih);
            cmd.Parameters.AddWithValue("@aciklama", yeniDescription);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
         }
        public void UpdateStory_inScrumTable(string EskiAd,string YeniAd)   //ScrumTable'daki Story Adları güncelleniyor.
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("UPDATE Scrum_Table SET Story=@ad WHERE Story='" + EskiAd + "'", Baglanti);
            cmd.Parameters.AddWithValue("@ad", YeniAd);

            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void UpdateStory_inTaskTable(string ad)    //TaskTable'daki Story Adları güncelleniyor
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("UPDATE Task_Table SET [Story Adı]=@ad WHERE [Story Adı]='" + ad + "'", Baglanti);
            cmd.Parameters.AddWithValue("@ad", ad);

            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }

        //TASK TABLE GÜNCELLE SİL İŞLEMLERİ 
        public void UpdateTaskTable(string eskiAd,string yeniAd,string yeniKisi, string yeniTasBilgi, string yeniTarih)    //TaskTable'daki Tasklar günccelleniyor.
        {
            Baglanti.Open();

            cmd= new SqlCommand
                ("UPDATE Task_Table SET Kisi=@kisi,[Task Adı]=@ad,[Task Bilgisi]=@bilgi,Tarih=@tarih  WHERE [Task Adı]='" + eskiAd + "'", Baglanti);
            cmd.Parameters.AddWithValue("@ad", yeniAd);
            cmd.Parameters.AddWithValue("@bilgi", yeniTasBilgi);
            cmd.Parameters.AddWithValue("@kisi", yeniKisi);
            cmd.Parameters.AddWithValue("@tarih", yeniTarih);
            
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void UpdateTask_inScrumTable(string ad,string yeniTaskAdi) //ScrumTable'daki Tasklar günccelleniyor.
        {                                                                //Tasklar güncellendiği zaman Not Started bölmesine alınıyor.
            Baglanti.Open();

            cmd = new SqlCommand
                ("UPDATE Scrum_Table SET [Not Started]='" + yeniTaskAdi + "'  WHERE [Not Started]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand
                ("UPDATE Scrum_Table SET [Not Started]='" + yeniTaskAdi+ "',[In Progress]=Null WHERE [In Progress]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand
                 ("UPDATE Scrum_Table SET [Not Started]='" + yeniTaskAdi + "',Done=NULL  WHERE Done='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void DeleteTaskTable(string ad)
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("DELETE FROM Task_Table WHERE [Task Adı]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();
  
            cmd = new SqlCommand
                ("UPDATE Scrum_Table  SET [Not Started]=Null   WHERE  [Not Started]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand
                ("UPDATE Scrum_Table  SET [In Progress]=Null   WHERE  [In Progress]='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand
                ("UPDATE Scrum_Table  SET Done=Null   WHERE  Done='" + ad + "'", Baglanti);
            cmd.ExecuteNonQuery();
           

            cmd = new SqlCommand // scrum tabledan silme komutudur..
          ("DELETE FROM Scrum_Table WHERE Story is Null AND [Not Started] is Null  AND [In Progress] is Null AND Done is Null  ", Baglanti);
            cmd.ExecuteNonQuery();

           cmd = new SqlCommand// silenecek story nin adının çekilmesi için komut oluşturduk
                ("SELECT Story FROM Scrum_Table WHERE [Not Started] is null AND [In Progress] is null AND Done is null ", Baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand
                ("DELETE FROM Scrum_Table WHERE [Not Started] is null AND [In Progress] is null AND Done is null ",Baglanti);
            cmd.ExecuteNonQuery();

            Baglanti.Close();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DeleteStoryTable(dt.Rows[i][0].ToString()); 
            }


           
        }




        //STORY EKLEME İŞLEMLERİ
        public void InsertStoryTable(string yeniStoryAd,string yeniYazar, string yeniDescription, string yeniTarih)
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("INSERT INTO Story_Table(Ad,Yazar,Tarih,Açıklama) values(@ad,@yazar,@tarih,@aciklama) ", Baglanti);
            cmd.Parameters.AddWithValue("@ad", yeniStoryAd);
            cmd.Parameters.AddWithValue("@yazar", yeniYazar);
            cmd.Parameters.AddWithValue("@tarih",yeniTarih);
            cmd.Parameters.AddWithValue("@aciklama", yeniDescription);

            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void InsertTaskTable(string yeniKisi, string yeniTask, string yeniTasBilgi, string yeniTarih,string yeniStoryAd)
        {
            Baglanti.Open();

            cmd = new SqlCommand
                ("INSERT INTO Task_Table( Kisi,[Task Adı],[Task Bilgisi],Tarih,[Story Adı] ) values(@kisi,@taskadi,@taskbilgi,@tar,@storyad) ", Baglanti);
            cmd.Parameters.AddWithValue("@kisi", yeniKisi);
            cmd.Parameters.AddWithValue("@taskadi", yeniTask);
            cmd.Parameters.AddWithValue("@taskbilgi", yeniTasBilgi);
            cmd.Parameters.AddWithValue("@tar", yeniTarih);
            cmd.Parameters.AddWithValue("@storyad", yeniStoryAd);
            cmd.ExecuteNonQuery();

            Baglanti.Close();
        }
        public void InsertScrumTable(string yeniStoryAd,string yeniTaskAd)
        {
            Baglanti.Open();

            if (yeniStoryAd != "")
            {
                cmd = new SqlCommand
                    ("INSERT INTO Scrum_Table(Story,[Not Started]) values(@story,@not) ", Baglanti);
                cmd.Parameters.AddWithValue("@story", yeniStoryAd);
                cmd.Parameters.AddWithValue("@not", yeniTaskAd);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand
                    ("INSERT INTO Scrum_Table(Story,[Not Started]) values(NULL,@not) ", Baglanti);
                cmd.Parameters.AddWithValue("@not", yeniTaskAd);
                cmd.ExecuteNonQuery();
            }
            Baglanti.Close();
        }
    }
}
