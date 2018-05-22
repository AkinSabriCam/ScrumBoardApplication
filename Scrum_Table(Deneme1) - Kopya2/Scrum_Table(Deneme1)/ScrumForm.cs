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
        FlowLayoutPanel StoryFlowPanel;
        FlowLayoutPanel NotFlowPanel;
        FlowLayoutPanel ProgressFlowPanel;
        FlowLayoutPanel DoneFlowPanel;


       // SqlConnection Baglanti = new SqlConnection("server=USER\\SQLEXPRESS;Database=ScrumBoard;Integrated Security=true");

        DBConnect connect = new DBConnect();

        public ScrumForm()
        {
            InitializeComponent();
        }

        private void ScrumForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = connect.ScrumTable("Story");

            int j = 0;
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
                    NotFlowPanel = new FlowLayoutPanel();
                    ProgressFlowPanel = new FlowLayoutPanel();
                    DoneFlowPanel = new FlowLayoutPanel();
                    StoryFlowPanel = new FlowLayoutPanel();

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

                    //NotFlowPanel.DragDrop +=NotFlow_DragDrop;
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


                    VeriCek("Not Started");
                    VeriCek("In Progress");
                    VeriCek("Done");
                }
            }
        }
        public void VeriCek(string name)
        {
            int j = 0;

            DataTable dt = new DataTable();

            dt = connect.ScrumTable(name);

            while (j < dt.Rows.Count)
            {
                Button btn = new Button();
                btn.BackColor = Color.Purple;
                btn.Name = "btntask" + name + j;
                btn.Text = dt.Rows[j][0].ToString();
                btn.Enabled = true;
                btn.Width = 174;
                btn.Height = 40;
                btn.Tag = j;
                btn.Click += new EventHandler(btn2_Click);
                btn.MouseUp += new MouseEventHandler(btn2_Up);
                btn.Location = new Point(0, 40 * j);
                switch (name)
                {
                    case "Not Started":
                        NotFlowPanel.Controls.Add(btn);
                        break;
                    case "In Progress":
                        ProgressFlowPanel.Controls.Add(btn);
                        break;
                    case "Done":
                        DoneFlowPanel.Controls.Add(btn);
                        break;
                    default:
                        break;
                }
                if (btn.Text == "")
                    btn.Visible = false;
                j++;
                if (j != 0 && j % 2 == 0)
                    break;
            }

        }

        void btn1_Click(object sender, EventArgs e)
        {
            //Buttonlara tıklandıkdan sonra story hakkında bilgi veriliyor.
           
            DataTable dt = connect.StoryTable(((Button)sender).Text);

            StoryBilgiFrm sbf = new StoryBilgiFrm();
            sbf.ad = dt.Rows[0][0].ToString();
            sbf.yazar = dt.Rows[0][1].ToString();
            sbf.tarih = dt.Rows[0][2].ToString();
            sbf.description = dt.Rows[0][3].ToString();

            sbf.Show();

            this.Hide();
        }
        void btn2_Click(object sender, EventArgs e)
        {
            // Buttonlara tıklandıkdan sonra task hakkında bilgi veriliyor.
            
            DataTable dt = connect.TaskTable(((Button)sender).Text);

            TaskBilgiFrm tbf = new TaskBilgiFrm();

            tbf.kisi = dt.Rows[0][0].ToString();
            tbf.ad = dt.Rows[0][1].ToString();
            tbf.task = dt.Rows[0][2].ToString();
            tbf.tarih= dt.Rows[0][4].ToString();
            tbf.Show();


           ((Button)sender).DoDragDrop(((Button)sender), DragDropEffects.Copy);

            this.Hide();
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
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void NotFlow_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void ProgressFlow_DragDrop(object sender, DragEventArgs e)
        {
            // DRAG DROP OLAYI İÇİN BUTTON YARATIYORUZ..
           
            FlowLayoutPanel ProgressFlow = (FlowLayoutPanel)sender;
            Control control = (Control)e.Data.GetData(typeof(Button)) ;

            if ((int)control.Tag  ==(int) ProgressFlow.Tag || (int)control.Tag==(int)(ProgressFlow.Tag)+1)
            {
                MessageBox.Show("Drag Drop olayı gerçekleşmiştir.");
                ProgressFlow.Controls.Add(control);

                connect.DragDrop("In Progress",control.Text);
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
                MessageBox.Show("Drag Drop olayı gerçekleşmiştir.");
                DoneLayout.Controls.Add(control);

                connect.DragDrop("Done", control.Text);
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
