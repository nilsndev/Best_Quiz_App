using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Best_Quiz_App.Forms
{
    public partial class MainQuizForm : Form
    {
        public int index = 0;
        public int first_index = 0;
        public int copyIndex = 0;
        bool alredy = false;
        Random ran = new Random();

        int score = 0;
        string image_Path = @"C:\Users\Nils\source\repos\cs_programming\Projects_cs\Best_Quiz_App\Best_Quiz_App";
        public MainQuizForm()
        {
            InitializeComponent();
        }

        private void MainQuizForm_Load(object sender, EventArgs e)

        {
        
            this.quiz_category_panel3.Dock = DockStyle.Fill;
            Best_Quiz_App.Properties.Settings.Default.WindowIsOpen = true;
            
        }
        private void Check_Quiz_End()
        {
            Best_Quiz_App.Properties.Settings.Default.checkMainMenu = 0;
            if (index == 5)
                {
               
                ScoreForm sf = new ScoreForm();
                Best_Quiz_App.Properties.Settings.Default.score = score;
               
              sf.ShowDialog();

              
                Best_Quiz_App.Properties.Settings.Default.WindowIsOpen = false;
                Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 0;
                Best_Quiz_App.Properties.Settings.Default.score = 0;
               
                
                Best_Quiz_App.Properties.Settings.Default.Save();
                visivle_Controls(true);

                copyIndex = 0;
                index = 0;
                score = 0;

            }
        }
      private void checkIndex()
        {
            if (copyIndex == first_index)
            {
                while (first_index == copyIndex)
                {
                    copyIndex = ran.Next(1, 11);
                }
            }
        }

        public void LoadAnimalINfos()
        {


            Check_Quiz_End();

            
           
            copyIndex++;
            index++;
           
            this.question_index_label1.Text = $"{index}/5";

          
            string question = "What is the name of this animal?";
            switch (copyIndex)
            {
               
                case 1:
                  
                    test_image_pictureBox1.Image = Image.FromFile( image_Path + @"\Images_Animal\tapir.jfif");
                   loadQuestion("Giant wild boar", "Tapir", "Ox", "Wild boar", question);
                    
                    

                    break;
                case 2:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\riesenhai.jfif");
                   
                    loadQuestion("Whale shark", "Bowhead whale", "Basking shark", "Dolphin", question);


                    break;
                case 3:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\roter_panda.jfif");
                    loadQuestion("Red Panda", "Wild cat", "Tiger", "Monkey", question);


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\elch.jfif");
               
                    loadQuestion("Elk", "Moose", "Mouse", "Reindeer", question);
                    break;

                case 5:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\Otter.jpg");

                    loadQuestion("Otter", "Weasel", "Beaver", "Sperm whale", question);
                    break;
                case 6:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\walhai.jfif");

                    loadQuestion("Whale shark", "Basking shark", "Orca", "Sardine", question);
                    break;
                case 7:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\ameisenbär.jpg");

                    loadQuestion("Aardvark", "Tapir", "Pig", "Anteater", question);
                    break;
                case 8:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\belugawal.jpg");

                    loadQuestion("Narwal", "Belugawal", "Grönlandwal", "Dolphin", question);
                    break;
                case 9:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\blue_whale.jpg");

                    loadQuestion("Blue whale", "Sperm whale", "Bowhead whale", "Orca", question);
                    break;
                case 10:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\See_elefant.jpg");

                    loadQuestion("Sea lion", "Sea elephant", "Sea leopard", "Blue whale", question);
                    break;
                case 11:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\See_elefant.jpg");

                    loadQuestion("Cat", "Dog", "Rabbit", "Bunny", question);
                    break;
                case 12:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\See_elefant.jpg");

                    loadQuestion("Dog", "Cat", "Pig", "Bunny", question);
                    break;
                case 13:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Animal\See_elefant.jpg");

                   loadQuestion("Orca", "Dolphin", "Sea lion", "Sea Leopard", question);
                    break;

            }


        }
        public void LoadICTINfos()
        {


            Check_Quiz_End();

            copyIndex++;
            index++;
            
            
            this.question_index_label1.Text = $"{index}/5";
            switch (copyIndex)
            {
                case 1:
                    
                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\fortnite_logo.png");
                    loadQuestion("C++", "C#", "C", "Assembler", "Which programming language was used to program Fortnite?");
                   

                    break;
                case 2:
                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\microsoft_logo.jfif");
                    loadQuestion("Bill Gates", "Steve Jobs", "Kevin Mitnick", "Mark Zuckerberg", "What is the name of the founder of Microsoft?");

                  
                   break;
                case 3:
                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\facebook_logo.jfif");
                    loadQuestion("Mark Zuckerberg", "Markus Persson", "Thomas Gotschalk", "Dieter Bohlen", "What is the name of the founder of Facebook?");
                    

                    break;
                case 4:
                  
                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\konrad_zuse_pc.jfif");
                   
                    loadQuestion("Kevin Mitnick", "Konrad Zuse", "Markus Persson", "Stevan Hawking", "Who invented the computer?");
                    break;
                case 5:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\minecraft.jfif");

                    loadQuestion("C++", "C", "Java", "C#", "Which programming language was used to program Minecraft?");
                    break;

                case 6:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\ios_app.jfif");

                    loadQuestion("Kotlin", "Swift", "Java", "Delphi", "Which programming language is mainly used for IOS apps?");
                    break;
                case 7:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\android_app.jfif");

                    loadQuestion("Fortran", "Swift", "Typescript", "Kotlin", "Which programming language is mainly used for android apps?");
                    break;
                case 8:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\linux_logo.jfif");

                    loadQuestion("Kevin Mitnick", "Linus Torvalds", "Bill Gates", "Steve Jobs", "Who invented Linux?");
                    break;
                case 9:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\amazon_logo.jpg");

                    loadQuestion("Jeff Bezos", "Linus Torvalds ","Kevin Mitnick", "Bjarne Stroustrup", "Who invented Amazon?");
                    break;
                case 10:

                    this.test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_ICT\c++.png");

                    loadQuestion("Linus Torvalds", "Jeff Bezos", "Kevin Mitnick", "Bjarne Stroustrup", "What is the name of the inventor of the programming language C++?");
                    break;

            }


        }
       public void LoadCapitalCityINfos()
        {
           


            Check_Quiz_End();
            
            copyIndex++;

            index++;
           
             this.question_index_label1.Text = $"{index}/5";
            switch (copyIndex)
            {
                case 1:

                    test_image_pictureBox1.Image = Best_Quiz_App.Properties.Resources.brasilien;
                    loadQuestion("Rio", "Brasilia", "Belo Horizonte", "Santiago", "What is the capital of Brasil called?");
                    break;
                case 2:
                    test_image_pictureBox1.Image = Best_Quiz_App.Properties.Resources.Spanien;
                    loadQuestion("Brussels", "Barcelona", "Madrid", "Berlin", "What is the capital of Spain called?");


                    break;
                case 3:
                    test_image_pictureBox1.Image = Best_Quiz_App.Properties.Resources.swissflag;
                    loadQuestion("Basel", "Bern", "Zurich", "Lucerne", "What is the capital of Switzerland called?");


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\poland_flag.png");


                    //loadQuestion("Beijing", "Hong Kong", "Tel Aviv", "Warsaw", "What is the capital of Poland called?");
                    break;
                case 5:

                    test_image_pictureBox1.Image = Best_Quiz_App.Properties.Resources.deutschland;

                    loadQuestion("Berlin", "München", "Bremen", "Düsseldorf", "What is the capital of Germany called?");
                    break;
                case 6:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\russia_flag.png");

                    loadQuestion("Vladivostok", "Moscow", "St Petersburg", "Volgograd", "What is the capital of Russia called?");
                    break;
                case 7:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\usa_flag.jpg");
                    loadQuestion("Florida", "Los Angeles", "New York City", "Washington DC", "What is the capital of the USA called?");
                    break;
                case 8:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\south_africa.jfif");

                    loadQuestion("West London", "East London", "Cape Town", "Johannesburg", "What is the capital of South Africa called?");
                    break;
                case 9:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\canada_flag.jfif");

                    loadQuestion("Calgery", "Vancouver", "Toronto", "Ottawa", "What is the capital of Canada called?");
                    break;
                case 10:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\new_zeeland.png");

                    loadQuestion("Darwin", "Sydney", "Auckland", "Wellington", "What is the capital of New Zeeland called?");
                    break;
                case 11:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\australia_flag.jfif");

                    loadQuestion("Wellington", "Sydney", "Darwin", "Camberra", "What is the capital of Australia called?");
                    break;
                case 12:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\austria_flag.jfif");

                    loadQuestion("Vaduz", "Salzburg", "Zurich", "Vienna", "What is the capital of Austria called?");
                    break;
                case 13:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\japan_flag.png");

                    loadQuestion("Shanghai", "Nagasaki", "Hiroshima", "Tokyo", "What is the capital of Japan called?");
                    break;
                case 14:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\belarus_flag.jpg");

                    loadQuestion("Kiev", "Minsk", "Volgograd", "Moscow", "What is the capital of Belarus called?");
                    break;
                case 15:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_City\serbia_flag.png");

                    loadQuestion("Belgrade", "Sarajevo", "Zagreb", "Tirana", "What is the capital of Serbia called?");
                    break;
            }


        }

        void loadQuestion(string button1Text, string button2Text, string button3Text, string button4Text, string questionText)
        {
            button1.Text = button1Text;
            button2.Text = button2Text;
            button3.Text = button3Text;
            button4.Text = button4Text;
            questionlabel1.Text = questionText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 1)
            {
                if (copyIndex == 1 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 2 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 3 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 4 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 5 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 6 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 7 && sender == button4)
                {
                    score++;
                }
                if (copyIndex == 8 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 9 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 10 && sender == button4)
                {
                    score++;
                }
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 2)
            {
                if (copyIndex == 1 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 2 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 3 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 4 && sender == button4)
                {
                    score++;
                }

                if (copyIndex == 5 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 6 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 7 && sender == button4)
                {
                    score++;
                }
                if (copyIndex == 8 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 9 && sender == button4)
                {
                    score++;
                }
                if (copyIndex == 10 && sender == button4)
                {
                    score++;
                }
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 3)
            {
                if (copyIndex == 1 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 2 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 3 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 4 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 5 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 6 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 7 && sender == button4)
                {
                    score++;
                }
                if (copyIndex == 8 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 9 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 10 && sender == button2)
                {
                    score++;
                }
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 4)
            {
                if (copyIndex == 1 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 2 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 3 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 4 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 5 && sender == button4)
                {
                    score++;
                }
            }
                if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 5)
                {
                    if (copyIndex == 1 && sender == button3)
                    {
                        score++;
                    }
                    if (copyIndex == 2 && sender == button1)
                    {
                        score++;
                    }
                    if (copyIndex == 3 && sender == button4)
                    {
                        score++;
                    }
                    if (copyIndex == 4 && sender == button2)
                    {
                        score++;
                    }
                    if (copyIndex == 5 && sender == button2)
                    {
                        score++;
                    }
                if (copyIndex == 6 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 7 && sender == button4)
                {
                    score++;
                }
                if (copyIndex == 8 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 9 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 10 && sender == button1)
                {
                    score++;
                }
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 6)
            {
                if (copyIndex == 1 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 2 && sender == button3)
                {
                    score++;
                }
                if (copyIndex == 3 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 4 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 5 && sender == button1)
                {
                    score++;
                }
                if (copyIndex == 6 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 7 && sender == button2)
                {
                    score++;
                }
                if (copyIndex == 8 && sender == button4)
                {
                    score++;
                }
               
            }
                if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 7)
                {
                    if (copyIndex == 1 && sender == button1)
                    {
                        score++;
                    }
                    if (copyIndex == 2 && sender == button2)
                    {
                        score++;
                    }
                    if (copyIndex == 3 && sender == button4)
                    {
                        score++;
                    }
                    if (copyIndex == 4 && sender == button1)
                    {
                        score++;
                    }
                    if (copyIndex == 5 && sender == button1 || copyIndex == 5 && sender == button3)
                    {
                        score++;
                    }
                }


            checkForm();
        }
        public void LoadPlants()
        {



            Check_Quiz_End();
            copyIndex++;
            index++;
            this.question_index_label1.Text = $"{index}/5";
            string question = "What is the name of this plant?";
            switch (copyIndex)
            {
                case 1:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\bogenhanf.png");
                    loadQuestion("Dill", "Aloe Vera", "Bow hemp", "Peperomia", question);
                    break;
                case 2:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Lavendel.jpg");
                    loadQuestion("Lavender", "Streptocarpus", "Astilbe", "Cyclamen", question);


                    break;
                case 3:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\farn.jfif");
                    loadQuestion("Ivy", "Succulents", "Shell flower", "Fern", question);


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\fichte.jpg");

                    loadQuestion("Echeveria", "Spruce", "Succulents", "Ivy", question);
                    break;
                case 5:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\monstera.jfif");
                    loadQuestion("Dragon tree", "Monstera", "Succulents", "Aloe Vera", question);
                    break;
                case 6:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Poinsettia_Image.jfif");
                    loadQuestion("Poinsettia", "Forget-me-not", "Water-Plants", "Monstera", question);
                    break;
                case 7:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Zamioculcas_image.jfif");
                    loadQuestion("Monstera", "Veronica", "Forget-me-not", "Zamioculcas", question);
                    break;
                case 8:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\tagetes_image.jfif");
                    loadQuestion("Aloe Vera", "Veronica", "Tagetes", "Sedge", question);
                    break;
                case 9:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Rhododendron_image.jfif");
                    loadQuestion("Dragon tree", "Rudbeckia", "Rhododendron", "Aloe Vera", question);
                    break;
                case 10:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Pinapple_image.jfif");
                    loadQuestion("Pineapple", "Monstera", "Succulents", "Aloe Vera", question);
                    break;

            }


        }
        public void LoadCarINfos()
        {



            Check_Quiz_End();


            copyIndex++;
            index++;
            this.question_index_label1.Text = $"{index}/5";
            string question = "What is the name of this car?";
            switch (copyIndex)
            {
                case 1:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\lamborghini_huracan.jpg");
                    loadQuestion("lamborghini urus", "lamborghini huracan", "lamborghini aventador", "lamborghini miura", question);
                    break;
                case 2:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Ford_Mustang.jfif");
                    loadQuestion("ford puma", "bobby car", "ford mustang", "ford kunga", question);


                    break;
                case 3:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\mercedes_amg_gt.jfif");
                    loadQuestion("mercedes amg gt", "mercedes amg s63", "mercedes a 200", "mercedes b 200", question);


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\toyota_mirai.jpg");

                    loadQuestion("Toyota Mirai", "Toyota Rav4", "Toyota Yaris", "Toyota Tundra", question);
                    break;
                case 5:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\Ferrari_F8.jfif");

                    loadQuestion("Ferrari FXX", "Ferrari", "Ferrari GT", "Ferrari f8", question);
                    break;
                case 6:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Car\Audi_R8_blue_image.jpg");

                    loadQuestion("Audi R8||", "Audi A7", "Audi A3", "Audi R4", question);
                    break;
                case 7:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Car\lambo_urus.jpg");

                    loadQuestion("Lamborghini Huracan", "Lamborghini Aventador", "Lamborghini Miura", "Lamborghini Urus|¦", question);
                    break;
                case 8:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Car\smart_image.jpg");

                    loadQuestion("Audi A7", "Ford Mustang", "Smart¦¦", "Lamborghini Huracan", question);
                    break;
                case 9:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Car\tesla_model_x.jpg");

                    loadQuestion("Tesla Model 3", "Tesla Model Y", "Tesla Model X||", "Tesla Model T", question);
                    break;
                case 10:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Car\rolls_royce_ghost.jfif");

                    loadQuestion("Rolls Royce Wraith", "Rolls Royce Ghost||", "Ford Mustang", "Smart", question);
                    break;

            }


        }
        public void LoadSpaceINfos()
        {



            Check_Quiz_End();
           
            copyIndex++;
            
            index++;
            this.question_index_label1.Text = $"{index}/5";
           string question = "What is the name of this planet?";
            switch (copyIndex)
            {
                case 1:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\neptune.jpg");
                    loadQuestion("Uranus", "Neptune", "Jupiter", "Saturn", question);
                    break;
                case 2:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\saturn.jfif");
                    loadQuestion("Neptune", "Jupiter", "Saturn", "Mars", question);


                    break;
                case 3:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\mars.jpg");
                    loadQuestion("Mars", "Venus", "Saturn", "Mercury", question);


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\venus.jpg");

                    loadQuestion("Venus", "Mercury", "Earth", "Mars", question);
                    break;
                case 5:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\erde.jpg");

                    loadQuestion("Earth", "Mars", "Uranus", "Neptune", question);
                    break;
                case 6:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Space\mercury_planet.jfif");

                    loadQuestion("Mars", "Mercury", "Venus", "Jupiter", question);
                    break;
                case 7:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Space\uranus_planet.jpg");

                    loadQuestion("Neptune", "Uranus", "Mercury", "Jupiter", question);
                    break;
                case 8:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Space\jupiter_planet.jpg");

                    loadQuestion("Mars", "Mercury", "Venus", "Jupiter", question);
                    break;
             

            }


        }
        public void LoadSportINfos()
        {



            Check_Quiz_End();
           
            copyIndex++;
            

            index++;
            
            this.question_index_label1.Text = $"{index}/5";
           
           
         
            switch (copyIndex)
            {
                case 1:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images_Sport\champions_league.jfif");
                    loadQuestion("Real Madrid", "Liverpool", "Bayern Munich", "Barcelona", "Which football club has the most Champions League victories?");
                    break;
                case 2:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\world_cup.jpg");
                    loadQuestion("Italy", "Brasil", "Argentina", "Germany", "Which country has won the most Fifa World Cup titles?");


                    break;
                case 3:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\confed_cup.jfif");
                    loadQuestion("France", "Italy", "Germany", "Brasil", "Which country has won the most Fifa Confed Cup titles?");


                    break;
                case 4:
                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\fussball.jfif");

                    loadQuestion("31:0", "19:0", "40:5", "29:2", "What was the highest win in national football matches?");
                    break;
                case 5:

                    test_image_pictureBox1.Image = Image.FromFile(image_Path + @"\Images\em_2021.jfif");

                    loadQuestion("Germany", "Italy", "Spain", "France", "Which country has the most European Championship titles?");
                    break;

            }


        }

        private void checkForm()
        {
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 1)
            {
                LoadICTINfos();
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 2)
            {
                LoadCapitalCityINfos();
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 3)
            {
                LoadAnimalINfos();
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 4)
            {
                LoadCarINfos();
             }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 5)
            {
                LoadPlants();
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 6)
            {
                LoadSpaceINfos();
            }
            if (Best_Quiz_App.Properties.Settings.Default.settings_quiz_index == 7)
            {
                LoadSportINfos();
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void exit_button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
          
            Best_Quiz_App.Properties.Settings.Default.WindowIsOpen = false;
            this.Close();
            
        }

        private void animal_button6_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);
            copyIndex = 0;
            index = 0;
          
            LoadAnimalINfos();

            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 3;
        }

        private void ict_button8_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);

            index = 0;
            copyIndex = 0;
            LoadICTINfos();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 1;
        }

        

        private void quiz_category_panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void visivle_Controls(bool check)
        {
            this.quiz_category_panel3.Visible = check;
            this.ict_button8.Visible = check;
            this.capital_city_button7.Visible = check;
            this.car_button5.Visible = check;
            this.quiz_label3.Visible = check;
            this.animal_button6.Visible = check;
        }

        private void capital_city_button7_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);
           copyIndex = 0;
            index = 0;
            LoadCapitalCityINfos();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 2;
        }

        private void car_button5_Click(object sender, EventArgs e)
        {
            copyIndex = 0;
            index = 0;
            visivle_Controls(false);
            LoadCarINfos();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 4;
        }

        private void plants_button5_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);
            copyIndex = 0;
            index = 0;
            LoadPlants();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 5;
        }

        private void space_button6_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);
            copyIndex = 0;
            index = 0;
            LoadSpaceINfos();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 6;
        }

      

       
        private void random_button7_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int random = r.Next(1,8);
            visivle_Controls(false);
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = random;
            copyIndex = 0;
            index = 0;
            checkForm();
            
           
        }

        private void sport_button5_Click(object sender, EventArgs e)
        {
            visivle_Controls(false);
            copyIndex = 0;
            index = 0;
           LoadSportINfos();
            Best_Quiz_App.Properties.Settings.Default.settings_quiz_index = 7;
        }

        private void question_index_label1_Click(object sender, EventArgs e)
        {

        }

        private void test_image_pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
