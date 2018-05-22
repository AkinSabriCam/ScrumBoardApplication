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
    public partial class ScrumForm : Form
    {
        FlowLayoutPanel StoryFlowPanel = new FlowLayoutPanel();
        FlowLayoutPanel NotFlowPanel = new FlowLayoutPanel();
        FlowLayoutPanel ProgressFlowPanel = new FlowLayoutPanel();
        FlowLayoutPanel DoneFlowPanel = new FlowLayoutPanel();

    
       
         
        public ScrumForm()
        {
            InitializeComponent();
        }

        private void ScrumForm_Load(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection("server=AKıN;Database=ScrumBoard;Integrated Security=true");
            Baglanti.Open();

            SqlCommand StoryKomut = new SqlCommand  //Scrum_Table tablosunun Story kolonundaki tüm verileri çekiyor.
                ("SELECT  Story FROM Scrum_Table", Baglanti);
            SqlDataAdapter da = new SqlDataAdapter(StoryKomut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StoryKomut.ExecuteNonQuery();

            SqlCommand StartedKomut = new SqlCommand // Scrum_Table tablosunun [Not Started] kolonundaki tüm verileri çekiyor.
                ("SELECT  [Not Started] FROM Scrum_Table", Baglanti);
            SqlDataAdapter daa = new SqlDataAdapter(StartedKomut);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            StartedKomut.ExecuteNonQuery();

            SqlCommand ProgressKomut = new SqlCommand // Scrum_Table tablosunun [Not Started] kolonundaki tüm verileri çekiyor.
                ("SELECT  [In Progress] FROM Scrum_Table", Baglanti);
            SqlDataAdapter data_adapter = new SqlDataAdapter(ProgressKomut);
            DataTable data_table = new DataTable();
            data_adapter.Fill(data_table);
            ProgressKomut.ExecuteNonQuery();

            SqlCommand DoneKomut = new SqlCommand // Scrum_Table tablosunun [Not Started] kolonundaki tüm verileri çekiyor.
                ("SELECT  [Done] FROM Scrum_Table", Baglanti);
            SqlDataAdapter data_adapter1 = new SqlDataAdapter(DoneKomut);
            DataTable data_table1 = new DataTable();
            data_adapter1.Fill(data_table1);
            DoneKomut.ExecuteNonQuery();



            int j = 0,a=0,b=0;
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                Button btn1 = new Button();
                btn1.BackColor = Color.Purple;
                btn1.Name = "btnstory" + i;
                btn1.Text = dt.Rows[i][0].ToString();
                btn1.Enabled = true;
                btn1.Width = 174;
                btn1.Height = 40;
                if (btn1.Text == "")
                    btn1.Visible = false;
                btn1.Click += new EventHandler(btn1_Click);
                btn1.Location = new Point(0, 40 * i);

                if (btn1.Text != "")
                {
                    FlowLayoutPanel NotFlowPanel = new FlowLayoutPanel();
                    FlowLayoutPanel ProgressFlowPanel = new FlowLayoutPanel();
                    FlowLayoutPanel DoneFlowPanel = new FlowLayoutPanel();
                    FlowLayoutPanel StoryFlowPanel = new FlowLayoutPanel();
                    StoryFlowPanel.Width = 180;
                    StoryFlowPanel.Height = 45 * 2;
                    StoryFlowPanel.Name = "StoryFlowPanel" + i;
                    StoryFlowPanel.AllowDrop = true;
                    if (i != 0)
                    {
                        StoryFlowPanel.Location = new Point(0, ((i) / 2 * 95));
                        NotFlowPanel.Location = new Point(0, (i / 2 * 95));
                        ProgressFlowPanel.Location = new Point(0, (i / 2 * 95));
                        DoneFlowPanel.Location = new Point(0, (i / 2 * 95));

                    }
                    else
                    {
                        StoryFlowPanel.Location = new Point(0, (i * 95));
                        NotFlowPanel.Location = new Point(0, (i * 95));
                        ProgressFlowPanel.Location = new Point(0, (i  * 95));
                        DoneFlowPanel.Location = new Point(0, (i  * 95));
                    }
                    StoryFlowPanel.Controls.Add(btn1);//OLUŞTURULAN STORY PANELİNE STORY BUTTONLARINI ATTIK
                    panelStory.Controls.Add(StoryFlowPanel);

                    NotFlowPanel.Name = "NotFlowPanel" + i;
                    ProgressFlowPanel.Name = "ProgressFlowPanel" + i;
                    DoneFlowPanel.Name = "DoneFlowPanel" + i;
                    NotFlowPanel.Tag = i;
                    ProgressFlowPanel.Tag = i;
                    DoneFlowPanel.Tag = i;
                    NotFlowPanel.Width = 180;
                    NotFlowPanel.Height = 45 * 2;
                    ProgressFlowPanel.Width = 180;
                    ProgressFlowPanel.Height = 45 * 2;
                    DoneFlowPanel.Width = 180;
                    DoneFlowPanel.Height = 45 * 2;

                    NotFlowPanel.AllowDrop = true;
                    ProgressFlowPanel.AllowDrop = true;
                    DoneFlowPanel.AllowDrop = true;

                    //  NotFlowPanel.DragDrop +=NotFlow_DragDrop;
                    //NotFlowPanel.DragEnter += NotFlow_DragEnter;
                    //NotFlowPanel.DragOver += NotFlow_DragOver;
                    ProgressFlowPanel.DragDrop += ProgressFlow_DragDrop;
                    ProgressFlowPanel.DragEnter += ProgressFlow_DragEnter;
                    ProgressFlowPanel.DragOver += ProgressFlow_DragOver;
                    DoneFlowPanel.DragDrop += DoneFlow_DragDrop;
                    DoneFlowPanel.DragEnter += DoneFlow_DragEnter;
                    DoneFlowPanel.DragOver += DoneFlow_DragOver;

                   

                    // YUKARIDA 4 GRUP İÇİN FLOW LAYOUT PANELLERİMİZİ OLUŞTURDUK!

                    panelNot.Controls.Add(NotFlowPanel);
                    panelProgres.Controls.Add(ProgressFlowPanel);
                    panelDone.Controls.Add(DoneFlowPanel);
                    // yukarıda flow layout panellerimizi 4 gruba ayrılan panellerimize ayrı ayrı ekledik

                    while (j < dtt.Rows.Count)
                    {
                       Button btn = new Button();
                        btn.BackColor = Color.Purple;
                        btn.Name = "btntask" + j;
                        btn.Text = dtt.Rows[j][0].ToString();
                        btn.Enabled = true;
                        btn.Width = 174;
                        btn.Height = 40;
                        btn.Tag = j;
                        btn.Click += new EventHandler(btn2_Click);
                        btn.MouseUp += new MouseEventHandler(btn2_Up);
                        btn.Location = new Point(0, 40 * j);
                        NotFlowPanel.Controls.Add(btn);
                        if (btn.Text == "")
                            btn.Visible = false;
                         j++;
                        if (j != 0 && j % 2 == 0)
                            break;
                    }

                    while (a < data_table.Rows.Count)
                    {   // ın progresdeki verilerin çekildiği döngü
                        Button btn = new Button();
                        btn.BackColor = Color.Purple;
                        btn.Name = "btntaskin" + a;
                        btn.Text = data_table.Rows[a][0].ToString();
                        btn.Enabled = true;
                        btn.Width = 174;
                        btn.Height = 40;
                        btn.Tag = a;
                        btn.Click += new EventHandler(btn2_Click);
                        btn.MouseUp += new MouseEventHandler(btn2_Up);
                        btn.Location = new Point(0, 40 * a);
                        if (btn.Text == "")
                            btn.Visible = false;
                        ProgressFlowPanel.Controls.Add(btn);
                      
                        a++;
                        if (a != 0 && a % 2 == 0)
                            break;
                    }
                    while (b < data_table1.Rows.Count)
                    {    // Done column daki verilerin çekildiği döngü
                        Button btn = new Button();
                        btn.BackColor = Color.Purple;
                        btn.Name = "btntaskdone" + b;
                        btn.Text = data_table1.Rows[b][0].ToString();
                        btn.Enabled = true;
                        btn.Width = 174;
                        btn.Height = 40;
                        btn.Tag = b;
                        btn.Click += new EventHandler(btn2_Click);
                        btn.MouseUp += new MouseEventHandler(btn2_Up);
                        btn.Location = new Point(0, 40 * b);
                        DoneFlowPanel.Controls.Add(btn);
                        if (btn.Text == "")
                            btn.Visible = false;
                        b++;
                        if (b != 0 && b % 2 == 0)
                            break;
                    }




                }
            }

            Baglanti.Close();
        }

        void btn1_Click(object sender, EventArgs e)
        {
            //Button lara tıklandıkdan sonra story hakkında bilgi verilen click eventi nin içerisidir.
            SqlConnection baglanti = new SqlConnection("server=AKıN;DataBase=ScrumBoard;Integrated Security=true");
            baglanti.Open();
            if (((Button)sender).Text == "SORT")
                ((Button)sender).Text = "ARAMA";
            SqlCommand Komut = new SqlCommand
             ("Select *from Story_Table where Ad='"+ ((Button)sender).Text+"'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            Komut.ExecuteNonQuery();
            StoryBilgiFrm sbf = new StoryBilgiFrm();
            sbf.ad = dt.Rows[0][0].ToString();
            sbf.yazar = dt.Rows[0][1].ToString();
            sbf.tarih = dt.Rows[0][2].ToString();
            sbf.description = dt.Rows[0][3].ToString();

            sbf.Show();

            baglanti.Close();
        }
        void btn2_Click(object sender, EventArgs e)
        {
            // Button lara tıklandıkdan sonra  task hakkında bilgi verilen click eventinin içerisidir..
            SqlConnection baglanti = new SqlConnection("server=AKıN;DataBase=ScrumBoard;Integrated Security=true");
            baglanti.Open();
            SqlCommand Komut = new SqlCommand
             ("Select *from Task_Table where [Task Adı]='" + ((Button)sender).Text + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(Komut);
            DataTable dt = new DataTable();
            Komut.ExecuteNonQuery();
            da.Fill(dt);
            Komut.ExecuteNonQuery();

            TaskBilgiFrm tbf = new TaskBilgiFrm();
              tbf.kisi = dt.Rows[0][0].ToString();
            tbf.ad = dt.Rows[0][1].ToString();
            tbf.task = dt.Rows[0][2].ToString();
            tbf.tarih= dt.Rows[0][4].ToString();
            tbf.Show();


           ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Copy);
            baglanti.Close();
    
        }
       
        void btn2_Up( object sender, MouseEventArgs e)
        {
            
            ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Copy);

        }

     
        private void NotFlow_DragDrop(object sender, DragEventArgs e)
        {
            // DRAG DROP OLAYI İÇİN BUTTON YARATIYORUZ..
            Button btn;
            btn = ((Button)e.Data.GetData(typeof(Button)));

            if (btn.Text == "")
                btn.Visible = false;
           
            NotFlowPanel.Controls.Add(btn);
        
        }
        private void NotFlow_DragEnter(object sender, DragEventArgs e)
        {e.Effect =DragDropEffects.Copy;
        }
        private void NotFlow_DragOver(object sender, DragEventArgs e)
        {e.Effect = DragDropEffects.Copy;
        }
        private void ProgressFlow_DragDrop(object sender, DragEventArgs e)
        {
            // DRAG DROP OLAYI İÇİN BUTTON YARATIYORUZ..
           
            FlowLayoutPanel ProgressFlow = (FlowLayoutPanel)sender;
            Control control = (Control)e.Data.GetData(typeof(Button)) ;

            if ((int)control.Tag  ==(int) ProgressFlow.Tag || (int)control.Tag==(int)(ProgressFlow.Tag)+1)
            {
                ProgressFlow.Controls.Add(control);
                SqlConnection bag = new SqlConnection("server=AKıN;DataBase=ScrumBoard; Integrated Security=true");
                bag.Open();
                SqlCommand Komut = new SqlCommand
                 ("UPDATE  Scrum_Table SET [In Progress]='"+control.Text+"',[Not Started]=NULL where [Not Started]='" + control.Text + "'", bag);
                SqlCommand Komut1 = new SqlCommand
                 ("UPDATE  Scrum_Table SET [In Progress]='" + control.Text + "',Done=NULL where Done='" + control.Text + "'", bag);

                Komut1.ExecuteNonQuery();
                Komut.ExecuteNonQuery();
                bag.Close();



            }
        }
        private void ProgressFlow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void ProgressFlow_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void DoneFlow_DragDrop(object sender, DragEventArgs e)
        {
            // DRAG DROP OLAYI İÇİN BUTTON YARATIYORUZ..
            FlowLayoutPanel DoneLayout = (FlowLayoutPanel)sender;
            Control control = (Control)e.Data.GetData(typeof(Button));
            if ((int)DoneLayout.Tag == (int)control.Tag || (int)control.Tag == (int)(DoneLayout.Tag) + 1)
            {
                DoneLayout.Controls.Add(control);
                SqlConnection bag = new SqlConnection("server=AKıN;DataBase=ScrumBoard; Integrated Security=true");
                bag.Open();
                SqlCommand Komut = new SqlCommand
                 ("UPDATE  Scrum_Table SET Done='" + control.Text + "',[Not Started]=NULL,[In Progress]=NULL where [In Progress]='" + control.Text + "'", bag);
                Komut.ExecuteNonQuery();
                bag.Close();
                // Not started'den gelen verinin kontrolü yapılmamıştır
                // In progressden gelen verinin kontrolü yapılmıştır.. (gerekli kontrolü yap!)

            }
        }
        private void DoneFlow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void DoneFlow_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

      
    }
}
