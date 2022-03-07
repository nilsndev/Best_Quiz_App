using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Best_Quiz_App.Forms
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

     

        private void ScoreForm_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i <= Best_Quiz_App.Properties.Settings.Default.score; i++)
            {

                this.score_label2.Text = $"{i}/5";
            }
        }

        private void home_button1_Click(object sender, EventArgs e)
        {

            this.Close();
           
            Best_Quiz_App.Properties.Settings.Default.checkMainMenu = 1;
          
        }

        private void back_panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
