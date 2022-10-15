
namespace Best_Quiz_App.Forms
{
    partial class ScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.home_button1 = new System.Windows.Forms.Button();
            this.question_correct_label1 = new System.Windows.Forms.Label();
            this.your_answear_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.score_label2 = new System.Windows.Forms.Label();
            this.back_panel1 = new System.Windows.Forms.Panel();
            this.back_panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_button1
            // 
            this.home_button1.BackColor = System.Drawing.Color.Red;
            this.home_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_button1.Location = new System.Drawing.Point(121, 268);
            this.home_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home_button1.Name = "home_button1";
            this.home_button1.Size = new System.Drawing.Size(278, 55);
            this.home_button1.TabIndex = 1;
            this.home_button1.Text = "Back to Home";
            this.home_button1.UseVisualStyleBackColor = false;
            this.home_button1.Click += new System.EventHandler(this.home_button1_Click);
            // 
            // question_correct_label1
            // 
            this.question_correct_label1.AutoSize = true;
            this.question_correct_label1.BackColor = System.Drawing.Color.Transparent;
            this.question_correct_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_correct_label1.ForeColor = System.Drawing.Color.White;
            this.question_correct_label1.Location = new System.Drawing.Point(180, 220);
            this.question_correct_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question_correct_label1.Name = "question_correct_label1";
            this.question_correct_label1.Size = new System.Drawing.Size(153, 20);
            this.question_correct_label1.TabIndex = 2;
            this.question_correct_label1.Text = "questions correct!";
            // 
            // your_answear_label1
            // 
            this.your_answear_label1.AutoSize = true;
            this.your_answear_label1.BackColor = System.Drawing.Color.Transparent;
            this.your_answear_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.your_answear_label1.ForeColor = System.Drawing.Color.White;
            this.your_answear_label1.Location = new System.Drawing.Point(198, 107);
            this.your_answear_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.your_answear_label1.Name = "your_answear_label1";
            this.your_answear_label1.Size = new System.Drawing.Size(125, 20);
            this.your_answear_label1.TabIndex = 3;
            this.your_answear_label1.Text = "your answered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Congratulations";
            // 
            // score_label2
            // 
            this.score_label2.AutoSize = true;
            this.score_label2.BackColor = System.Drawing.Color.Black;
            this.score_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label2.ForeColor = System.Drawing.Color.Red;
            this.score_label2.Location = new System.Drawing.Point(227, 158);
            this.score_label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.score_label2.Name = "score_label2";
            this.score_label2.Size = new System.Drawing.Size(61, 35);
            this.score_label2.TabIndex = 5;
            this.score_label2.Text = "5/5";
            // 
            // back_panel1
            // 
            this.back_panel1.BackColor = System.Drawing.Color.Black;
            this.back_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.back_panel1.Controls.Add(this.label1);
            this.back_panel1.Controls.Add(this.score_label2);
            this.back_panel1.Controls.Add(this.home_button1);
            this.back_panel1.Controls.Add(this.your_answear_label1);
            this.back_panel1.Controls.Add(this.question_correct_label1);
            this.back_panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_panel1.Location = new System.Drawing.Point(0, 0);
            this.back_panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_panel1.Name = "back_panel1";
            this.back_panel1.Size = new System.Drawing.Size(528, 353);
            this.back_panel1.TabIndex = 6;
            this.back_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.back_panel1_Paint);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 353);
            this.Controls.Add(this.back_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "ScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.back_panel1.ResumeLayout(false);
            this.back_panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button home_button1;
        private System.Windows.Forms.Label question_correct_label1;
        private System.Windows.Forms.Label your_answear_label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_label2;
        private System.Windows.Forms.Panel back_panel1;
    }
}