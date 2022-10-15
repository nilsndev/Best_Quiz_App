
namespace Best_Quiz_App.Forms
{
    partial class MainQuizForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label text1Label;
            System.Windows.Forms.Label text2Label;
            System.Windows.Forms.Label text4Label;
            System.Windows.Forms.Label text3Label;
            System.Windows.Forms.Button minimize_button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainQuizForm));
            this.quiz_value_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiz_DS = new Best_Quiz_App.DS.Quiz_DS();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.quiz_value_tableTableAdapter = new Best_Quiz_App.DS.Quiz_DSTableAdapters.quiz_value_tableTableAdapter();
            this.tableAdapterManager = new Best_Quiz_App.DS.Quiz_DSTableAdapters.TableAdapterManager();
            this.QuizPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBack_button2 = new System.Windows.Forms.Button();
            this.text3Label1 = new System.Windows.Forms.Label();
            this.text4Label1 = new System.Windows.Forms.Label();
            this.text2Label1 = new System.Windows.Forms.Label();
            this.text1Label1 = new System.Windows.Forms.Label();
            this.quiz_index_label1 = new System.Windows.Forms.Label();
            this.correctAnswearLabel1 = new System.Windows.Forms.Label();
            this.quiz_button3 = new System.Windows.Forms.Button();
            this.quiz_button1 = new System.Windows.Forms.Button();
            this.quiz_button4 = new System.Windows.Forms.Button();
            this.quiz_button2 = new System.Windows.Forms.Button();
            this.test_image_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeScreen_page1 = new System.Windows.Forms.TabPage();
            this.header_label1 = new System.Windows.Forms.Label();
            this.forest_button3 = new System.Windows.Forms.Button();
            this.snow_button3 = new System.Windows.Forms.Button();
            this.savanne_button4 = new System.Windows.Forms.Button();
            this.desert_button1 = new System.Windows.Forms.Button();
            this.exit_button2 = new System.Windows.Forms.Button();
            this.rainforest_category_button2 = new System.Windows.Forms.Button();
            this.Air_category_button3 = new System.Windows.Forms.Button();
            this.water_category_button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animal_button6 = new System.Windows.Forms.Button();
            this.score_tabControl = new System.Windows.Forms.TabControl();
            text1Label = new System.Windows.Forms.Label();
            text2Label = new System.Windows.Forms.Label();
            text4Label = new System.Windows.Forms.Label();
            text3Label = new System.Windows.Forms.Label();
            minimize_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_value_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_DS)).BeginInit();
            this.QuizPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_image_pictureBox1)).BeginInit();
            this.homeScreen_page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.score_tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // text1Label
            // 
            text1Label.AutoSize = true;
            text1Label.BackColor = System.Drawing.Color.Black;
            text1Label.ForeColor = System.Drawing.Color.White;
            text1Label.Location = new System.Drawing.Point(128, 229);
            text1Label.Name = "text1Label";
            text1Label.Size = new System.Drawing.Size(33, 13);
            text1Label.TabIndex = 56;
            text1Label.Text = "text1:";
            // 
            // text2Label
            // 
            text2Label.AutoSize = true;
            text2Label.BackColor = System.Drawing.Color.Black;
            text2Label.ForeColor = System.Drawing.Color.White;
            text2Label.Location = new System.Drawing.Point(128, 264);
            text2Label.Name = "text2Label";
            text2Label.Size = new System.Drawing.Size(33, 13);
            text2Label.TabIndex = 57;
            text2Label.Text = "text2:";
            // 
            // text4Label
            // 
            text4Label.AutoSize = true;
            text4Label.BackColor = System.Drawing.Color.Black;
            text4Label.ForeColor = System.Drawing.Color.White;
            text4Label.Location = new System.Drawing.Point(128, 353);
            text4Label.Name = "text4Label";
            text4Label.Size = new System.Drawing.Size(33, 13);
            text4Label.TabIndex = 58;
            text4Label.Text = "text4:";
            // 
            // text3Label
            // 
            text3Label.AutoSize = true;
            text3Label.BackColor = System.Drawing.Color.Black;
            text3Label.ForeColor = System.Drawing.Color.White;
            text3Label.Location = new System.Drawing.Point(128, 313);
            text3Label.Name = "text3Label";
            text3Label.Size = new System.Drawing.Size(33, 13);
            text3Label.TabIndex = 59;
            text3Label.Text = "text3:";
            // 
            // minimize_button1
            // 
            minimize_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            minimize_button1.BackColor = System.Drawing.Color.Black;
            minimize_button1.BackgroundImage = global::Best_Quiz_App.Properties.Resources.minimize_button;
            minimize_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            minimize_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            minimize_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            minimize_button1.ForeColor = System.Drawing.Color.White;
            minimize_button1.Location = new System.Drawing.Point(1708, 18);
            minimize_button1.Margin = new System.Windows.Forms.Padding(2);
            minimize_button1.Name = "minimize_button1";
            minimize_button1.Size = new System.Drawing.Size(87, 75);
            minimize_button1.TabIndex = 78;
            minimize_button1.UseVisualStyleBackColor = false;
            minimize_button1.Click += new System.EventHandler(this.minimize_button1_Click);
            // 
            // quiz_value_tableBindingSource
            // 
            this.quiz_value_tableBindingSource.DataMember = "quiz_value_table";
            this.quiz_value_tableBindingSource.DataSource = this.quiz_DS;
            // 
            // quiz_DS
            // 
            this.quiz_DS.DataSetName = "Quiz_DS";
            this.quiz_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // quiz_value_tableTableAdapter
            // 
            this.quiz_value_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.quiz_value_tableTableAdapter = this.quiz_value_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Best_Quiz_App.DS.Quiz_DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // QuizPage
            // 
            this.QuizPage.BackColor = System.Drawing.Color.Black;
            this.QuizPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuizPage.Controls.Add(this.panel1);
            this.QuizPage.Controls.Add(this.goBack_button2);
            this.QuizPage.Controls.Add(text3Label);
            this.QuizPage.Controls.Add(this.text3Label1);
            this.QuizPage.Controls.Add(text4Label);
            this.QuizPage.Controls.Add(this.text4Label1);
            this.QuizPage.Controls.Add(text2Label);
            this.QuizPage.Controls.Add(this.text2Label1);
            this.QuizPage.Controls.Add(text1Label);
            this.QuizPage.Controls.Add(this.text1Label1);
            this.QuizPage.Controls.Add(this.quiz_index_label1);
            this.QuizPage.Controls.Add(this.quiz_button3);
            this.QuizPage.Controls.Add(this.quiz_button1);
            this.QuizPage.Controls.Add(this.quiz_button4);
            this.QuizPage.Controls.Add(this.quiz_button2);
            this.QuizPage.Controls.Add(this.test_image_pictureBox1);
            this.QuizPage.Controls.Add(this.correctAnswearLabel1);
            this.QuizPage.ForeColor = System.Drawing.Color.Transparent;
            this.QuizPage.Location = new System.Drawing.Point(4, 4);
            this.QuizPage.Name = "QuizPage";
            this.QuizPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuizPage.Size = new System.Drawing.Size(1912, 1077);
            this.QuizPage.TabIndex = 2;
            this.QuizPage.Text = "QuizPage";
            this.QuizPage.Click += new System.EventHandler(this.QuizPage_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(66, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 231);
            this.panel1.TabIndex = 62;
            // 
            // goBack_button2
            // 
            this.goBack_button2.BackColor = System.Drawing.Color.Black;
            this.goBack_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goBack_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBack_button2.Location = new System.Drawing.Point(66, 29);
            this.goBack_button2.Name = "goBack_button2";
            this.goBack_button2.Size = new System.Drawing.Size(160, 71);
            this.goBack_button2.TabIndex = 61;
            this.goBack_button2.Text = "BackToHome";
            this.goBack_button2.UseVisualStyleBackColor = false;
            this.goBack_button2.Click += new System.EventHandler(this.goBack_button2_Click);
            // 
            // text3Label1
            // 
            this.text3Label1.BackColor = System.Drawing.Color.Black;
            this.text3Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text3", true));
            this.text3Label1.ForeColor = System.Drawing.Color.White;
            this.text3Label1.Location = new System.Drawing.Point(167, 313);
            this.text3Label1.Name = "text3Label1";
            this.text3Label1.Size = new System.Drawing.Size(100, 23);
            this.text3Label1.TabIndex = 60;
            this.text3Label1.Text = "label1";
            // 
            // text4Label1
            // 
            this.text4Label1.BackColor = System.Drawing.Color.Black;
            this.text4Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text4", true));
            this.text4Label1.ForeColor = System.Drawing.Color.White;
            this.text4Label1.Location = new System.Drawing.Point(167, 353);
            this.text4Label1.Name = "text4Label1";
            this.text4Label1.Size = new System.Drawing.Size(100, 23);
            this.text4Label1.TabIndex = 59;
            this.text4Label1.Text = "label1";
            // 
            // text2Label1
            // 
            this.text2Label1.BackColor = System.Drawing.Color.Black;
            this.text2Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text2", true));
            this.text2Label1.ForeColor = System.Drawing.Color.White;
            this.text2Label1.Location = new System.Drawing.Point(167, 264);
            this.text2Label1.Name = "text2Label1";
            this.text2Label1.Size = new System.Drawing.Size(100, 23);
            this.text2Label1.TabIndex = 58;
            this.text2Label1.Text = "label1";
            // 
            // text1Label1
            // 
            this.text1Label1.BackColor = System.Drawing.Color.Black;
            this.text1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text1", true));
            this.text1Label1.ForeColor = System.Drawing.Color.White;
            this.text1Label1.Location = new System.Drawing.Point(167, 229);
            this.text1Label1.Name = "text1Label1";
            this.text1Label1.Size = new System.Drawing.Size(100, 23);
            this.text1Label1.TabIndex = 57;
            this.text1Label1.Text = "label1";
            // 
            // quiz_index_label1
            // 
            this.quiz_index_label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quiz_index_label1.AutoSize = true;
            this.quiz_index_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_index_label1.ForeColor = System.Drawing.Color.White;
            this.quiz_index_label1.Location = new System.Drawing.Point(891, 57);
            this.quiz_index_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quiz_index_label1.Name = "quiz_index_label1";
            this.quiz_index_label1.Size = new System.Drawing.Size(118, 54);
            this.quiz_index_label1.TabIndex = 55;
            this.quiz_index_label1.Text = "1/11";
            // 
            // correctAnswearLabel1
            // 
            this.correctAnswearLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "correctAnswear", true));
            this.correctAnswearLabel1.Location = new System.Drawing.Point(1439, 547);
            this.correctAnswearLabel1.Name = "correctAnswearLabel1";
            this.correctAnswearLabel1.Size = new System.Drawing.Size(100, 23);
            this.correctAnswearLabel1.TabIndex = 56;
            this.correctAnswearLabel1.Text = "label1";
            // 
            // quiz_button3
            // 
            this.quiz_button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quiz_button3.BackColor = System.Drawing.Color.Gray;
            this.quiz_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_button3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text3", true));
            this.quiz_button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quiz_button3.FlatAppearance.BorderSize = 10;
            this.quiz_button3.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_button3.ForeColor = System.Drawing.Color.White;
            this.quiz_button3.Image = global::Best_Quiz_App.Properties.Resources.number3;
            this.quiz_button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button3.Location = new System.Drawing.Point(348, 748);
            this.quiz_button3.Margin = new System.Windows.Forms.Padding(2);
            this.quiz_button3.Name = "quiz_button3";
            this.quiz_button3.Size = new System.Drawing.Size(1211, 81);
            this.quiz_button3.TabIndex = 53;
            this.quiz_button3.Text = "Text1";
            this.quiz_button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quiz_button3.UseVisualStyleBackColor = false;
            this.quiz_button3.Click += new System.EventHandler(this.question_button_click);
            // 
            // quiz_button1
            // 
            this.quiz_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quiz_button1.BackColor = System.Drawing.Color.Gray;
            this.quiz_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quiz_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_button1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text1", true));
            this.quiz_button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quiz_button1.FlatAppearance.BorderSize = 10;
            this.quiz_button1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_button1.ForeColor = System.Drawing.Color.White;
            this.quiz_button1.Image = ((System.Drawing.Image)(resources.GetObject("quiz_button1.Image")));
            this.quiz_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button1.Location = new System.Drawing.Point(348, 530);
            this.quiz_button1.Margin = new System.Windows.Forms.Padding(2);
            this.quiz_button1.Name = "quiz_button1";
            this.quiz_button1.Size = new System.Drawing.Size(1211, 81);
            this.quiz_button1.TabIndex = 52;
            this.quiz_button1.Text = "Text1";
            this.quiz_button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quiz_button1.UseVisualStyleBackColor = false;
            this.quiz_button1.Click += new System.EventHandler(this.question_button_click);
            // 
            // quiz_button4
            // 
            this.quiz_button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quiz_button4.BackColor = System.Drawing.Color.Gray;
            this.quiz_button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_button4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text4", true));
            this.quiz_button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quiz_button4.FlatAppearance.BorderSize = 10;
            this.quiz_button4.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_button4.ForeColor = System.Drawing.Color.White;
            this.quiz_button4.Image = global::Best_Quiz_App.Properties.Resources.number4;
            this.quiz_button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button4.Location = new System.Drawing.Point(348, 859);
            this.quiz_button4.Margin = new System.Windows.Forms.Padding(2);
            this.quiz_button4.Name = "quiz_button4";
            this.quiz_button4.Size = new System.Drawing.Size(1211, 81);
            this.quiz_button4.TabIndex = 51;
            this.quiz_button4.Text = "Text1";
            this.quiz_button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quiz_button4.UseVisualStyleBackColor = false;
            this.quiz_button4.Click += new System.EventHandler(this.question_button_click);
            // 
            // quiz_button2
            // 
            this.quiz_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.quiz_button2.BackColor = System.Drawing.Color.Gray;
            this.quiz_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quiz_button2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quiz_value_tableBindingSource, "text2", true));
            this.quiz_button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quiz_button2.FlatAppearance.BorderSize = 10;
            this.quiz_button2.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_button2.ForeColor = System.Drawing.Color.White;
            this.quiz_button2.Image = global::Best_Quiz_App.Properties.Resources.number2;
            this.quiz_button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button2.Location = new System.Drawing.Point(348, 641);
            this.quiz_button2.Margin = new System.Windows.Forms.Padding(2);
            this.quiz_button2.Name = "quiz_button2";
            this.quiz_button2.Size = new System.Drawing.Size(1211, 81);
            this.quiz_button2.TabIndex = 50;
            this.quiz_button2.Text = "Text1";
            this.quiz_button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quiz_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.quiz_button2.UseVisualStyleBackColor = false;
            this.quiz_button2.Click += new System.EventHandler(this.question_button_click);
            // 
            // test_image_pictureBox1
            // 
            this.test_image_pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.test_image_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.test_image_pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.quiz_value_tableBindingSource, "image", true));
            this.test_image_pictureBox1.Location = new System.Drawing.Point(693, 147);
            this.test_image_pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.test_image_pictureBox1.Name = "test_image_pictureBox1";
            this.test_image_pictureBox1.Size = new System.Drawing.Size(532, 309);
            this.test_image_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.test_image_pictureBox1.TabIndex = 49;
            this.test_image_pictureBox1.TabStop = false;
            // 
            // homeScreen_page1
            // 
            this.homeScreen_page1.BackColor = System.Drawing.Color.Black;
            this.homeScreen_page1.Controls.Add(minimize_button1);
            this.homeScreen_page1.Controls.Add(this.header_label1);
            this.homeScreen_page1.Controls.Add(this.forest_button3);
            this.homeScreen_page1.Controls.Add(this.snow_button3);
            this.homeScreen_page1.Controls.Add(this.savanne_button4);
            this.homeScreen_page1.Controls.Add(this.desert_button1);
            this.homeScreen_page1.Controls.Add(this.exit_button2);
            this.homeScreen_page1.Controls.Add(this.rainforest_category_button2);
            this.homeScreen_page1.Controls.Add(this.Air_category_button3);
            this.homeScreen_page1.Controls.Add(this.water_category_button2);
            this.homeScreen_page1.Controls.Add(this.textBox1);
            this.homeScreen_page1.Controls.Add(this.button1);
            this.homeScreen_page1.Controls.Add(this.pictureBox1);
            this.homeScreen_page1.Controls.Add(this.animal_button6);
            this.homeScreen_page1.ForeColor = System.Drawing.Color.White;
            this.homeScreen_page1.Location = new System.Drawing.Point(4, 4);
            this.homeScreen_page1.Name = "homeScreen_page1";
            this.homeScreen_page1.Padding = new System.Windows.Forms.Padding(3);
            this.homeScreen_page1.Size = new System.Drawing.Size(1912, 1077);
            this.homeScreen_page1.TabIndex = 1;
            this.homeScreen_page1.Text = "HomeScreen";
            this.homeScreen_page1.Click += new System.EventHandler(this.homeScreen_page1_Click);
            // 
            // header_label1
            // 
            this.header_label1.AutoSize = true;
            this.header_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label1.ForeColor = System.Drawing.Color.White;
            this.header_label1.Location = new System.Drawing.Point(567, 56);
            this.header_label1.Name = "header_label1";
            this.header_label1.Size = new System.Drawing.Size(792, 152);
            this.header_label1.TabIndex = 77;
            this.header_label1.Text = "Animal Quiz";
            // 
            // forest_button3
            // 
            this.forest_button3.BackColor = System.Drawing.Color.Silver;
            this.forest_button3.BackgroundImage = global::Best_Quiz_App.Properties.Resources.forest;
            this.forest_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forest_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forest_button3.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forest_button3.ForeColor = System.Drawing.Color.White;
            this.forest_button3.Location = new System.Drawing.Point(1431, 651);
            this.forest_button3.Margin = new System.Windows.Forms.Padding(2);
            this.forest_button3.Name = "forest_button3";
            this.forest_button3.Size = new System.Drawing.Size(400, 300);
            this.forest_button3.TabIndex = 76;
            this.forest_button3.Text = "Forest";
            this.forest_button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.forest_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.forest_button3.UseVisualStyleBackColor = false;
            this.forest_button3.Click += new System.EventHandler(this.forest_button3_Click);
            // 
            // snow_button3
            // 
            this.snow_button3.BackColor = System.Drawing.Color.Silver;
            this.snow_button3.BackgroundImage = global::Best_Quiz_App.Properties.Resources.snow;
            this.snow_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snow_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snow_button3.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snow_button3.ForeColor = System.Drawing.Color.Black;
            this.snow_button3.Location = new System.Drawing.Point(1431, 263);
            this.snow_button3.Margin = new System.Windows.Forms.Padding(2);
            this.snow_button3.Name = "snow_button3";
            this.snow_button3.Size = new System.Drawing.Size(400, 300);
            this.snow_button3.TabIndex = 75;
            this.snow_button3.Text = "Snow";
            this.snow_button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.snow_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.snow_button3.UseVisualStyleBackColor = false;
            this.snow_button3.Click += new System.EventHandler(this.snow_button3_Click);
            // 
            // savanne_button4
            // 
            this.savanne_button4.BackColor = System.Drawing.Color.Silver;
            this.savanne_button4.BackgroundImage = global::Best_Quiz_App.Properties.Resources.savanne;
            this.savanne_button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.savanne_button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savanne_button4.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savanne_button4.ForeColor = System.Drawing.Color.White;
            this.savanne_button4.Location = new System.Drawing.Point(982, 651);
            this.savanne_button4.Margin = new System.Windows.Forms.Padding(2);
            this.savanne_button4.Name = "savanne_button4";
            this.savanne_button4.Size = new System.Drawing.Size(400, 300);
            this.savanne_button4.TabIndex = 74;
            this.savanne_button4.Text = "Savanne";
            this.savanne_button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.savanne_button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savanne_button4.UseVisualStyleBackColor = false;
            this.savanne_button4.Click += new System.EventHandler(this.savanne_button4_Click);
            // 
            // desert_button1
            // 
            this.desert_button1.BackColor = System.Drawing.Color.Silver;
            this.desert_button1.BackgroundImage = global::Best_Quiz_App.Properties.Resources.desert;
            this.desert_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.desert_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.desert_button1.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desert_button1.ForeColor = System.Drawing.Color.White;
            this.desert_button1.Location = new System.Drawing.Point(982, 263);
            this.desert_button1.Margin = new System.Windows.Forms.Padding(2);
            this.desert_button1.Name = "desert_button1";
            this.desert_button1.Size = new System.Drawing.Size(400, 300);
            this.desert_button1.TabIndex = 73;
            this.desert_button1.Text = "Desert";
            this.desert_button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.desert_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.desert_button1.UseVisualStyleBackColor = false;
            this.desert_button1.Click += new System.EventHandler(this.desert_button1_Click);
            // 
            // exit_button2
            // 
            this.exit_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_button2.BackgroundImage = global::Best_Quiz_App.Properties.Resources.exit;
            this.exit_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button2.Location = new System.Drawing.Point(1808, 18);
            this.exit_button2.Margin = new System.Windows.Forms.Padding(2);
            this.exit_button2.Name = "exit_button2";
            this.exit_button2.Size = new System.Drawing.Size(87, 75);
            this.exit_button2.TabIndex = 72;
            this.exit_button2.UseVisualStyleBackColor = false;
            this.exit_button2.Click += new System.EventHandler(this.exit_button2_Click);
            // 
            // rainforest_category_button2
            // 
            this.rainforest_category_button2.BackColor = System.Drawing.Color.Silver;
            this.rainforest_category_button2.BackgroundImage = global::Best_Quiz_App.Properties.Resources.rainforest;
            this.rainforest_category_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rainforest_category_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rainforest_category_button2.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainforest_category_button2.ForeColor = System.Drawing.Color.White;
            this.rainforest_category_button2.Location = new System.Drawing.Point(524, 651);
            this.rainforest_category_button2.Margin = new System.Windows.Forms.Padding(2);
            this.rainforest_category_button2.Name = "rainforest_category_button2";
            this.rainforest_category_button2.Size = new System.Drawing.Size(400, 300);
            this.rainforest_category_button2.TabIndex = 71;
            this.rainforest_category_button2.Text = "Rainforest";
            this.rainforest_category_button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rainforest_category_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rainforest_category_button2.UseVisualStyleBackColor = false;
            this.rainforest_category_button2.Click += new System.EventHandler(this.rainforest_category_button2_Click);
            // 
            // Air_category_button3
            // 
            this.Air_category_button3.BackColor = System.Drawing.Color.Silver;
            this.Air_category_button3.BackgroundImage = global::Best_Quiz_App.Properties.Resources.air_image;
            this.Air_category_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Air_category_button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Air_category_button3.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Air_category_button3.ForeColor = System.Drawing.Color.White;
            this.Air_category_button3.Location = new System.Drawing.Point(65, 651);
            this.Air_category_button3.Margin = new System.Windows.Forms.Padding(2);
            this.Air_category_button3.Name = "Air_category_button3";
            this.Air_category_button3.Size = new System.Drawing.Size(400, 300);
            this.Air_category_button3.TabIndex = 70;
            this.Air_category_button3.Text = "Air";
            this.Air_category_button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Air_category_button3.UseVisualStyleBackColor = false;
            this.Air_category_button3.Click += new System.EventHandler(this.Air_category_button3_Click);
            // 
            // water_category_button2
            // 
            this.water_category_button2.BackColor = System.Drawing.Color.Silver;
            this.water_category_button2.BackgroundImage = global::Best_Quiz_App.Properties.Resources.water_image;
            this.water_category_button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water_category_button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water_category_button2.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water_category_button2.ForeColor = System.Drawing.Color.Black;
            this.water_category_button2.Location = new System.Drawing.Point(524, 263);
            this.water_category_button2.Margin = new System.Windows.Forms.Padding(2);
            this.water_category_button2.Name = "water_category_button2";
            this.water_category_button2.Size = new System.Drawing.Size(400, 300);
            this.water_category_button2.TabIndex = 69;
            this.water_category_button2.Text = "Water";
            this.water_category_button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.water_category_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.water_category_button2.UseVisualStyleBackColor = false;
            this.water_category_button2.Click += new System.EventHandler(this.water_category_button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1264, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 68;
            this.textBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1264, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 67;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.quiz_value_tableBindingSource, "image", true));
            this.pictureBox1.Location = new System.Drawing.Point(1159, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 67);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // animal_button6
            // 
            this.animal_button6.BackColor = System.Drawing.Color.Black;
            this.animal_button6.BackgroundImage = global::Best_Quiz_App.Properties.Resources.earth_image;
            this.animal_button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.animal_button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animal_button6.Font = new System.Drawing.Font("Corbel", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animal_button6.ForeColor = System.Drawing.Color.White;
            this.animal_button6.Location = new System.Drawing.Point(65, 263);
            this.animal_button6.Margin = new System.Windows.Forms.Padding(2);
            this.animal_button6.Name = "animal_button6";
            this.animal_button6.Size = new System.Drawing.Size(400, 300);
            this.animal_button6.TabIndex = 59;
            this.animal_button6.Text = "All Animals";
            this.animal_button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.animal_button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.animal_button6.UseVisualStyleBackColor = false;
            this.animal_button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // score_tabControl
            // 
            this.score_tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.score_tabControl.Controls.Add(this.homeScreen_page1);
            this.score_tabControl.Controls.Add(this.QuizPage);
            this.score_tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.score_tabControl.Location = new System.Drawing.Point(0, 0);
            this.score_tabControl.Name = "score_tabControl";
            this.score_tabControl.SelectedIndex = 0;
            this.score_tabControl.Size = new System.Drawing.Size(1920, 1103);
            this.score_tabControl.TabIndex = 57;
            // 
            // MainQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1100);
            this.Controls.Add(this.score_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainQuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainQuizForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainQuizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quiz_value_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_DS)).EndInit();
            this.QuizPage.ResumeLayout(false);
            this.QuizPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test_image_pictureBox1)).EndInit();
            this.homeScreen_page1.ResumeLayout(false);
            this.homeScreen_page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.score_tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DS.Quiz_DS quiz_DS;
        private System.Windows.Forms.BindingSource quiz_value_tableBindingSource;
        private DS.Quiz_DSTableAdapters.quiz_value_tableTableAdapter quiz_value_tableTableAdapter;
        private DS.Quiz_DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage QuizPage;
        private System.Windows.Forms.Button goBack_button2;
        private System.Windows.Forms.Label text3Label1;
        private System.Windows.Forms.Label text4Label1;
        private System.Windows.Forms.Label text2Label1;
        private System.Windows.Forms.Label text1Label1;
        private System.Windows.Forms.Label quiz_index_label1;
        public System.Windows.Forms.Button quiz_button3;
        public System.Windows.Forms.Button quiz_button1;
        public System.Windows.Forms.Button quiz_button4;
        public System.Windows.Forms.Button quiz_button2;
        private System.Windows.Forms.Label correctAnswearLabel1;
        private System.Windows.Forms.PictureBox test_image_pictureBox1;
        private System.Windows.Forms.TabPage homeScreen_page1;
        private System.Windows.Forms.Label header_label1;
        public System.Windows.Forms.Button forest_button3;
        public System.Windows.Forms.Button snow_button3;
        public System.Windows.Forms.Button savanne_button4;
        public System.Windows.Forms.Button desert_button1;
        private System.Windows.Forms.Button exit_button2;
        public System.Windows.Forms.Button rainforest_category_button2;
        public System.Windows.Forms.Button Air_category_button3;
        public System.Windows.Forms.Button water_category_button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button animal_button6;
        private System.Windows.Forms.TabControl score_tabControl;
        private System.Windows.Forms.Panel panel1;
    }
}