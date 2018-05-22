using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrum_Table_Deneme1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void storieEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoryForm sfrm = new StoryForm();
            sfrm.Show();

        }

        private void pROJEYİGÖRÜNTÜLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScrumForm scrumform = new ScrumForm();
            scrumform.Show();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
