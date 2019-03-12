using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BecomeRich
{
    public partial class Form1 : Form
    {
    
        int score;
        int iSlide = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if(button1.Text == "0")
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            else
            {
                pictureBox1.Image = imageList1.Images[2];
               
            }

            if(button1.Text == "1")
            {
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "2")
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "3")
            {
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "4")
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "5")
            {
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "6")
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;       
            }

            if (button1.Text == "7")
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "8")
            {
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "9")
            {
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "10")
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "11")
            {
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "12")
            {
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "13")
            {
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "14")
            {
                radioButton1.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "15")
            {
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

            if (button1.Text == "16")
            {
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                pictureBox1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


         
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;

            radioButton1.BackColor = Color.Black;
            radioButton2.BackColor = Color.Black;
            radioButton3.BackColor = Color.Black;
            radioButton4.BackColor = Color.Black;

            iSlide = iSlide + 1;
            {
                switch (iSlide)
                {
                    case 1:
                        Question1();
                        iSlide = 1;
                        button1.Text = Convert.ToString(iSlide);
                        Question1();
                        iSlide = 1;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[9];
                        button1.Enabled = false;
                        label2.Text = "Score: ";

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;

                    radioButton1.BackColor = Color.Black;
                    radioButton2.BackColor = Color.Black;
                    radioButton3.BackColor = Color.Black;
                    radioButton4.BackColor = Color.Black;
                        break;
                    case 2:
                        Question2();
                        iSlide = 2;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[10];
                        button1.Enabled = false;

                        
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        pictureBox5.Image = imageList1.Images[10];
                        button1.Enabled = false;

                        pictureBox5.Image = imageList1.Images[10];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 3:
                        Question3();
                        iSlide = 3;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[11];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 4:
                        Question4();
                        iSlide = 4;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[12];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 5:
                        Question5();
                        iSlide = 5;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[13];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 6:
                        Question6();
                        iSlide = 6;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[14];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 7:
                        Question7();
                        iSlide = 7;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[15];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 8:
                        Question8();
                        iSlide = 8;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[16];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 9:
                        Question9();
                        iSlide = 9;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[17];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 10:
                        Question10();
                        iSlide = 10;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[18];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;
                    case 11:
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[19];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 12:
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[20];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 13:
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[21];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 14:
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[22];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 15:
                    
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[23];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;

                    case 16:
                        Question11();
                        iSlide = 11;
                        button1.Text = Convert.ToString(iSlide);
                        pictureBox5.Image = imageList1.Images[24];
                        button1.Enabled = false;

                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;

                        radioButton1.BackColor = Color.Black;
                        radioButton2.BackColor = Color.Black;
                        radioButton3.BackColor = Color.Black;
                        radioButton4.BackColor = Color.Black;
                        break;
                    
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(score);
            pictureBox1.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[3];
            pictureBox2.Image = imageList1.Images[5];
            pictureBox5.Image = imageList1.Images[8];

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            //Timer MyTimer = new Timer();
            //MyTimer.Interval = (60 * 60 * 1000); // 60 mins
            //MyTimer.Tick += new EventHandler(MyTimer_Tick);
            //MyTimer.Start();

        }

        private void Question1()
        {
            label1.Text = "What is 2+2 ?";
            radioButton1.Text = "A: 4";
            radioButton2.Text = "C: 2";
            radioButton3.Text = "B: 22";
            radioButton4.Text = "D: -4";
            //answer A
        }

        private void Question2()
        {
            label1.Text = "What is normal to drink on friday nights?";
            radioButton1.Text = "A: Nothing";
            radioButton2.Text = "B: Vodka";
            radioButton3.Text = "C: Alchohol";
            radioButton4.Text = "D: Wata";
            //answer C

        }

        private void Question3()
        {
            label1.Text = "What is GUI?";
            radioButton1.Text = "A: Graphiсal User Interface";
            radioButton2.Text = "B: Someting";
            radioButton3.Text = "C: A guy";
            radioButton4.Text = "D: go6o";
            //answer A
        }

        private void Question4()
        {
            label1.Text = "How many teenagers are believed to self-harm in the UK?";
            radioButton1.Text = "A: 1 in 5";
            radioButton2.Text = "B: 1 in 15";
            radioButton3.Text = "C: 1 in 25";
            radioButton4.Text = "D: 1 in 35";
            //answer B
        }

        private void Question5()
        {
            label1.Text = "Which is the capital of Bulgaria?";
            radioButton1.Text = "A: Пловдив";
            radioButton2.Text = "B: Майна таун";
            radioButton3.Text = "C: София";
            radioButton4.Text = "D: Перник";
            //answer C
        }

        private void Question6()
        {
            label1.Text = "At which year is Bulgaria created?";
            radioButton1.Text = "A: 681";
            radioButton2.Text = "B: 1681";
            radioButton3.Text = "C: 11681";
            radioButton4.Text = "D: 181";
            //answer A
        }

        private void Question7()
        {
            label1.Text = "Which of theese symptoms can happen if you are depressed?";
            radioButton1.Text = "A: Dont feel hungry";
            radioButton2.Text = "B: Hungry all the time";
            radioButton3.Text = "C: Always tired";
            radioButton4.Text = "D: Any of above";
            //answer D
        }

        private void Question8()
        {
            label1.Text = "It is estimated that since 1985 suicides by young men have ...?";
            radioButton1.Text = "A: Increased by 10%";
            radioButton2.Text = "B: Decreased by 19%";
            radioButton3.Text = "C: Stayed the same";
            radioButton4.Text = "D: Increased by 170%";
            //answer D
        }

        private void Question9()
        {
            label1.Text = "Which of the following people has not experienced serious mental health problems?";
            radioButton1.Text = "A: J.K Rowling";
            radioButton2.Text = "B: Donald Trump";
            radioButton3.Text = "C: Catherine Tate";
            radioButton4.Text = "D: Robbie Williams";
            //answer C
        }

        private void Question10()
        {
            label1.Text = "Which of theese are possible trigger for a psychotic episode?";
            radioButton1.Text = "A: Taking drugs";
            radioButton2.Text = "B: Going to school";
            radioButton3.Text = "C: Going shopping";
            radioButton4.Text = "D: All of the above";
            //answer A
        }

        private void Question11()
        {
            label1.Text = "Which of the following are considered to be real medical conditions?";
            radioButton1.Text = "A: Diabetes";
            radioButton2.Text = "B: Anxiety disorders";
            radioButton3.Text = "C: High blood pressure";
            radioButton4.Text = "D: All of the above";
            //answer D
        }

        private void Question12()
        {
            label1.Text = "In the children's book series, where is Paddington Bear originally from?";
            radioButton1.Text = "A: India";
            radioButton2.Text = "B: Canada";
            radioButton3.Text = "C: Peru";
            radioButton4.Text = "D: Iceland";
            //answer C
        }

        private void Question13()
        {
            label1.Text = "Which of theese U.S Presidents appeared on the television series 'Laugh-In' ?";
            radioButton1.Text = "A: Lyndon Johnson";
            radioButton2.Text = "B: Jimmy Carter";
            radioButton3.Text = "C: Richard Nixon";
            radioButton4.Text = "D: Gerald Ford";
            //answer C
        }

        private void Question14()
        {
            label1.Text = "The Earth is approximately how many miles away from the Sun?";
            radioButton1.Text = "A: 9.3 million";
            radioButton2.Text = "B: 39 million";
            radioButton3.Text = "C: 93 million";
            radioButton4.Text = "D: 193 million";
            //answer C
        }

        private void Question15()
        {
            label1.Text = "Which insect shorted out an early supercomputer and inspired the term computer bug?";
            radioButton1.Text = "A: Moth";
            radioButton2.Text = "B: Roach";
            radioButton3.Text = "C: Fly";
            radioButton4.Text = "D: Japanese beetle";
            //answer A
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(button1.Text == "1" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Gold;
                button1.Enabled = true;
               
                if(button1.Text == "1" && radioButton1.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if(button1.Text == "15" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Gold;
                button1.Enabled = true; 
                MessageBox.Show("You are a Millionaire!!");

                if (button1.Text == "15" && radioButton1.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

            }

            if (button1.Text == "3" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "3" && radioButton1.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

            }

            if (button1.Text == "6" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "6" && radioButton1.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }



            }

            if (button1.Text == "10" && radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.Gold;
                button1.Enabled = true;
                MessageBox.Show("You won 32 thousand");

                DialogResult dialog = MessageBox.Show("You can now quit and go home with your cash or you can continue", "Exit", MessageBoxButtons.YesNo); 
                if (dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }

                if (button1.Text == "10" && radioButton1.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            //-------------------Incorrect Answer----------------------------//

            if((button1.Text=="2" || button1.Text == "4" || button1.Text == "5" || button1.Text == "11" || button1.Text == "12" || button1.Text== "13" || button1.Text == "14"))
            {
                radioButton1.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                iSlide = 0;
                DialogResult dialog1 = MessageBox.Show("You loose","Exit",MessageBoxButtons.OKCancel);
                //button1.Enabled = true;
                //button1.Text = "Start again";   

                if (dialog1 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else 
                {
                    this.Close();
                }


            }

            if(button1.Text == "7" || button1.Text == "8" || button1.Text == "9")
            {
                radioButton1.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                iSlide = 0;
                MessageBox.Show("You loose, but u have won 1 thousand");
                //button1.Enabled = true;
                //button1.Text = "Start again";
                DialogResult dialog2 = MessageBox.Show("You loose", "Exit", MessageBoxButtons.OKCancel);
                if (dialog2 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else
                {
                    this.Close();
                }
                



            }
          


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Text == "4" && radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "4" && radioButton2.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

               

            }

            //--------------Incorrect Answer-------------------------//

            if ((button1.Text == "1" || button1.Text == "2" || button1.Text == "3" || button1.Text == "5" || button1.Text == "6" || button1.Text == "7"
                || button1.Text == "8" || button1.Text == "9" || button1.Text == "10"))
            {
                radioButton2.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                iSlide = 0;
                MessageBox.Show("You loose");
                //button1.Enabled = true;
                //button1.Text = "Start again"; 

                DialogResult dialog3 = MessageBox.Show("You loose", "Exit", MessageBoxButtons.OKCancel);
                if (dialog3 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else
                {
                    this.Close();
                }

            }

            if(button1.Text == "11" || button1.Text == "12" || button1.Text == "13" || button1.Text == "14" || button1.Text == "15" || button1.Text == "16")
            {
                radioButton2.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                iSlide = 0;
                MessageBox.Show("You loose, but u have won 32 thousand");
                //button1.Enabled = true;
                //button1.Text = "Start again";

                DialogResult dialog4 = MessageBox.Show("You loose", "Exit", MessageBoxButtons.OKCancel);
                if (dialog4 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else
                {
                    this.Close();
                }

            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Text == "14" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "14" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if (button1.Text == "13" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "13" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if (button1.Text == "12" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "12" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if (button1.Text == "9" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "9" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if (button1.Text == "5" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;
                MessageBox.Show("You won 1 thousand");

                DialogResult dialog = MessageBox.Show("You can now quit and go home with your cash or you can continue", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Application.Restart();
                }

                if (button1.Text == "5" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

            }

            if (button1.Text == "2" && radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "2" && radioButton3.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }



            }

            //-----------------------------Incorrect Answer---------------------------------\\

            if ((button1.Text == "1" || button1.Text == "3" || button1.Text == "4" || button1.Text == "6" || button1.Text == "7" || button1.Text == "8"
                || button1.Text == "10" || button1.Text == "11" || button1.Text == "15"))
            {
                radioButton3.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                iSlide = 0;
                MessageBox.Show("You loose");
                //button1.Enabled = true;
                //button1.Text = "Start again";

                DialogResult dialog5 = MessageBox.Show("You loose", "Exit", MessageBoxButtons.OKCancel);
                if (dialog5 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else
                {
                    this.Close();
                }

            }




        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (button1.Text == "11" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "11" && radioButton4.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }


            }

            if (button1.Text == "8" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "8" && radioButton4.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

            }

            if (button1.Text == "7" && radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Gold;
                button1.Enabled = true;

                if (button1.Text == "7" && radioButton4.Checked == true)
                {
                    label2.Text = "Score: " + score;
                    score++;
                }
                else
                {
                    score = 0;
                }

            }

            //----------------------------------------Incorrect answer------------------------------//

            if ((button1.Text == "1" || button1.Text == "2" || button1.Text == "3" || button1.Text == "4" || button1.Text == "5" || button1.Text == "6"
                || button1.Text == "9" || button1.Text == "10" || button1.Text == "12" || button1.Text == "13"|| button1.Text == "14" || button1.Text == "15" || button1.Text =="16"))
            {
                radioButton4.BackColor = Color.Red;
                pictureBox5.Image = imageList1.Images[8];
                MessageBox.Show("You loose");
                //button1.Enabled = true;
                //button1.Text = "Start again";
                iSlide = 0;

                DialogResult dialog6 = MessageBox.Show("You loose", "Exit", MessageBoxButtons.OKCancel);
                if (dialog6 == DialogResult.OK)
                {
                    this.Hide();
                    Form begin = new Begin();
                    begin.ShowDialog();
                }
                else
                {
                    this.Close();
                }

            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (button1.Text == "0")
            {
                pictureBox3.Image = imageList1.Images[3];
                
            }
            else
            {
                pictureBox3.Image = imageList1.Images[4];
                
            }

            if(button1.Text == "1")
            {
                MessageBox.Show("The audience thinks its A");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "2")
            {
                MessageBox.Show("The audience thinks its C");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "3")
            {
                MessageBox.Show("The audience thinks its A");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "4")
            {
                MessageBox.Show("The audience thinks its B");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is B";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "5")
            {
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                MessageBox.Show("The audience thinks its C");
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "6")
            {
                MessageBox.Show("The audience thinks its A");
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "7")
            {
                MessageBox.Show("The audience thinks its D");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "8")
            {
                MessageBox.Show("The audience thinks its D");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is D";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "9")
            {
                MessageBox.Show("The audience thinks its C");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "10")
            {
                MessageBox.Show("The audience thinks its A");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "11")
            {
                MessageBox.Show("The audience thinks its D");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is D";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "12")
            {
                MessageBox.Show("The audience thinks its A");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "13")
            {
                MessageBox.Show("The audience thinks its C");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "14")
            {
                MessageBox.Show("The audience thinks its C");
                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "15")
            {
                MessageBox.Show("The audience thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is C";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "16")
            {
                MessageBox.Show("The audience thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (button1.Text == "0")
            {
                pictureBox2.Image = imageList1.Images[5];
            }
            else
            {
                pictureBox2.Image = imageList1.Images[6];
            }

            if (button1.Text == "1")
            {
                MessageBox.Show("Your friend thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "2")
            {
                MessageBox.Show("Your friend  thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "3")
            {
                MessageBox.Show("Your friend thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "4")
            {
                MessageBox.Show("Your friend thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "5")
            {
                MessageBox.Show("Your friend thinks its B");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "6")
            {
                MessageBox.Show("Your friend thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "7")
            {
                MessageBox.Show("Your friend thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "8")
            {
                MessageBox.Show("Your friend thinks its D");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "9")
            {
                MessageBox.Show("Your friend thinks its D");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "10")
            {
                MessageBox.Show("Your friend thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "11")
            {
                MessageBox.Show("Your friend thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox3.Enabled = false;
            }

            if (button1.Text == "12")
            {
                MessageBox.Show("Your friend thinks its D");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "13")
            {
                MessageBox.Show("Your friend thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "14")
            {
                MessageBox.Show("Your friend  thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "15")
            {
                MessageBox.Show("Your friend thinks its C");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }

            if (button1.Text == "16")
            {
                MessageBox.Show("Your friend thinks its A");

                //textBox1.Visible = true;
                //textBox1.Text = "The audience thinks the answer is A";
                pictureBox2.Enabled = false;
            }
        }
        //private void MyTimer_Tick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("The form will now be closed.", "Time Elapsed");
        //    this.Close();
        //}

      

    }
}
