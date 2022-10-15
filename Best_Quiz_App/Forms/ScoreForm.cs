using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Best_Quiz_App.Class;

namespace Best_Quiz_App.Forms
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

     

        private void ScoreForm_Load(object sender, EventArgs e){
            this.score_label2.Text = Settings.ScoreCount.ToString() +"/"+Settings.allowedCount.ToString();
        }

        private void home_button1_Click(object sender, EventArgs e){
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void back_panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
