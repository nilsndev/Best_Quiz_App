using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Best_Quiz_App.Class;

namespace Best_Quiz_App.Forms
{
    public partial class MainQuizForm : Form{
        string filter = "";
        int count = 5;
        int quizCount = 0;
        int randomQuizIndex;


 
        List<long> alreadyIndex= new List<long>();
        Random random = new Random();
        public MainQuizForm(){
            InitializeComponent();
            Settings.QuizIndex = 1;
        }
        private void MainQuizForm_Load(object sender, EventArgs e){
            // TODO: Diese Codezeile lädt Daten in die Tabelle "quiz_DS.quiz_value_table". Sie können sie bei Bedarf verschieben oder entfernen.
            this.quiz_value_tableTableAdapter.Fill(this.quiz_DS.quiz_value_table);
        }
        private void button1_Click(object sender, EventArgs e){
            filter = "";
            buttonClick();
        }
        void buttonClick(){
            setValues();
            this.score_tabControl.SelectedIndex = 1;
        }
        private void exit_button1_Click(object sender, EventArgs e){
            Application.Exit();
        }
        void setValues(){
            if (quizCount == Settings.allowedCount && Settings.allowedCount != 0){
                gameOver();
            }
            if (filter == ""){
                this.quiz_value_tableBindingSource.Filter = "ID ='" + Settings.QuizIndex + "'";
                Settings.maxCount = this.quiz_DS.quiz_value_table.Rows.Count;
                Settings.allowedCount = 40;
                defineRandomIndex();
            }
            else{
                this.quiz_value_tableBindingSource.Filter = "category = '" + filter + "'";
                Settings.maxCount = quiz_value_tableBindingSource.Count;
                Settings.allowedCount = 10;
                defineRandomIndex();
                this.quiz_value_tableBindingSource.Filter = "id_of_group ='" + Settings.QuizIndex.ToString() + "' And category = '" + filter + "'";
            }
            quizCount++;
            this.quiz_index_label1.Text = quizCount.ToString() + "/"+ Settings.allowedCount + "";
        }
        void defineRandomIndex(){
            do{
                Settings.QuizIndex = random.Next(1, Settings.maxCount);
            } while(alreadyIndex.Contains(Settings.QuizIndex));
            alreadyIndex.Add(Settings.QuizIndex);
        }
        void gameOver(){
            alreadyIndex.Clear();
            quizCount = 0;
            ScoreForm sf = new ScoreForm();
            sf.ShowDialog();
            if (sf.DialogResult == DialogResult.OK){
            this.score_tabControl.SelectedIndex = 0;
                Settings.ScoreCount = 0;
            }

        }
        private void question_button_click(object sender, EventArgs e){
            if((sender as Button).Text.TrimStart() == correctAnswearLabel1.Text.TrimStart() && correctAnswearLabel1.Text != ""){
                Settings.ScoreCount++;
            }
            Settings.QuizIndex = random.Next(1,Settings.maxCount);
            setValues();
        }
 
        private void QuizPage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e){
            this.quiz_value_tableBindingSource.Filter = "ID =" + Convert.ToInt64(textBox1.Text);
            openFileDialog1.ShowDialog();
            this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            this.quiz_value_tableTableAdapter.Update(quiz_DS.quiz_value_table);
            this.quiz_value_tableBindingSource.EndEdit();
            openFileDialog1.Dispose();
            
        }

        private void homeScreen_page1_Click(object sender, EventArgs e)
        {

        }

        private void water_category_button2_Click(object sender, EventArgs e){
            filter = "Water";
            buttonClick();
        }

        private void Air_category_button3_Click(object sender, EventArgs e){
            filter = "Air";
            buttonClick();
        }

        private void rainforest_category_button2_Click(object sender, EventArgs e){
            filter = "Rainforest";
            buttonClick();
        }

        private void desert_button1_Click(object sender, EventArgs e){
            filter = "Desert";
            buttonClick();
        }

        private void exit_button2_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void savanne_button4_Click(object sender, EventArgs e){
            filter = "Savanne";
            buttonClick();
        }

        private void snow_button3_Click(object sender, EventArgs e){
            filter = "Snow";
            buttonClick();
        }

        private void forest_button3_Click(object sender, EventArgs e){
            filter = "Forest";
            buttonClick();
        }

        private void goBack_button2_Click(object sender, EventArgs e){
            this.score_tabControl.SelectedIndex = 0;
            alreadyIndex.Clear();
            Settings.QuizIndex = 1;
            quizCount = 0;

        }

        private void minimize_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
