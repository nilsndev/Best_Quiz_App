using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Best_Quiz_App.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
      
     public  void  quizStart()
        {
            if (Best_Quiz_App.Properties.Settings.Default.WindowIsOpen)
            {

                return;
            }
            MainQuizForm mqf = new MainQuizForm();
            showForm(mqf);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
      
            Best_Quiz_App.Properties.Settings.Default.WindowIsOpen = false;
            
            quizStart();
        }

        private void minimize_button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

       

     

       
        

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

       
        public void showForm(Form f)
        {
            
            f.Dock = DockStyle.Fill;
            f.MdiParent = this;
            f.BringToFront();
            f.Show();
        }

       

        private void cloase_button_Click(object sender, EventArgs e)
        {
            Best_Quiz_App.Properties.Settings.Default.WindowIsOpen = false;
        }

       
       

       

       
        

      

       

      
       
    }
}
