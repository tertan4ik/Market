using System.Text.RegularExpressions;
using System.IO;

namespace WinFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
 

        }


        private void RegOrSingForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }

        private bool[] PasswordChecking(string password)
        {
            bool[] correct = new bool[6];
            if (password != string.Empty)
            {

                correct[0] = Regex.IsMatch(password, @"[a-z]");
                correct[1] = Regex.IsMatch(password, @"[A-Z]");
                correct[2] = Regex.IsMatch(password, @"[0-9]");
                correct[3] = Regex.IsMatch(password, @"[а-яА-Я]");
                correct[4] = Regex.IsMatch(password, @"[!@#№$;%^&*(),.?\"":{}|<>\\/ ~`+=-]");
                if (password.Length < 7 || password.Length > 31)
                {
                    correct[5] = false;
                }
                else
                {
                    correct[5] = true;
                }
            }
            else
            {
                correct[0] = false;
                correct[1] = false;
                correct[2] = false;
                correct[3] = false;
                correct[4] = false;


            }

            return correct;
        }
        private bool Mailchecking(string mail)
        {
            string pattern = @"^([0-9a-zA-Z]{6,30})@([a-z]{2,})\.([a-z]{2,17})";
            bool correct = Regex.IsMatch(mail, pattern);
            return correct;
        }
        private bool Phonechecking(string PhoneNumber)
        { 
               string pattern = @"^(\+7[0-9]{11})|(8[0-9]{10})$";
               

            bool correct = Regex.IsMatch(PhoneNumber, pattern);
                return correct;
            
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
           
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;


            }
        }
        private void inputdata(string login,string password,string name,string surname,string mail,string phonenumber,string org)
        {
              if(checkBox1.Checked)
             {
                StreamWriter sr = File.AppendText("Data.txt");
                sr.Write("login: "+login+"\n");
                sr.Write("password: "+password + "\n");
                sr.Write("role: "+"Продавец\n");
                sr.Write("name: "+name + "\n");
                sr.Write("surname: "+surname + "\n");
                sr.Write("mail: "+mail + "\n");
                sr.Write("phone: "+phonenumber + "\n");
                sr.Write("org: "+org + "\n");

                sr.Close();
       
            }
              else
            {
                StreamWriter sr = File.AppendText("Data.txt");
                sr.Write("login: " + login + "\n");
                sr.Write("password: " + password + "\n");
                sr.Write("role: " + "Покупатель\n");
  

                sr.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox1.Text == string.Empty ||
            textBox2.Text == string.Empty ||
            textBox3.Text == string.Empty ||
            textBox4.Text == string.Empty ||
            textBox5.Text == string.Empty ||
            textBox6.Text == string.Empty ||
            textBox7.Text == string.Empty)

                {
                    MessageBox.Show("Заполните все поля!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool[] correct = PasswordChecking(textBox2.Text.ToString());

                    if (correct[0] == true && correct[1] == true && correct[2] == true && correct[3] == false && correct[4] == true && correct[5] == true)
                    {
                        bool correctmail;
                        if (correctmail = Mailchecking(textBox5.Text.ToString()))
                        {
                            bool correctnumber;
                            if(correctnumber=Phonechecking(textBox6.Text.ToString()))
                            {
                                bool name = Regex.IsMatch(textBox3.Text.ToString(), @"[a-zA-Zа-яА-я]");
                          
                                if(name)
                                {
                                    bool surname = Regex.IsMatch(textBox3.Text.ToString(), @"[a-zA-Zа-яА-я]");
                                    if(surname)
                                    {
                                        inputdata(textBox1.Text.ToString(),
                                        textBox2.Text.ToString(),
                                        textBox3.Text.ToString(),
                                        textBox4.Text.ToString(),
                                        textBox5.Text.ToString(),
                                        textBox6.Text.ToString(),
                                        textBox7.Text.ToString());
                                        Form sign = new SignInForm();
                                        sign.Show();
                                        this.Hide();

                            
                                    }
                                    else
                                    {
                                        MessageBox.Show("В фамилии могут быть только буквы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("В имени могут быть только буквы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
               
                            }
                            else
                            {
                                MessageBox.Show("Некорректный номер телефона", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Некорректный Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Некорректный пароль", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    
                    
                }

            }
            else
            {
                if (textBox1.Text == string.Empty ||
                       textBox2.Text == string.Empty)
                {
                    
                        MessageBox.Show("Заполните все поля!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    bool[] correct = PasswordChecking(textBox2.Text.ToString());
                    if (correct[0] == true && correct[1] == true && correct[2] == true && correct[3] == false && correct[4] == true && correct[5] == true)
                    {

                 
                            inputdata(textBox1.Text.ToString(),
                                textBox2.Text.ToString(),
                                textBox3.Text.ToString(),
                                textBox4.Text.ToString(),
                                textBox5.Text.ToString(),
                                textBox6.Text.ToString(),
                                textBox7.Text.ToString());
                        Form sign = new SignInForm();
                        sign.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Некорректный пароль", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bool[] Correct = PasswordChecking(textBox2.Text.ToString());
            if (Correct[0] == false)
            {
                label10.ForeColor = Color.Red;
            }
            else
            {
                label10.ForeColor = Color.Green;
            }

            if (Correct[1] == false)
            {
                label9.ForeColor = Color.Red;
            }
            else
            {
                label9.ForeColor = Color.Green;
            }

            if (Correct[2] == false)
            {
                label11.ForeColor = Color.Red;
            }
            else
            {
                label11.ForeColor = Color.Green;
            }

            if (Correct[3] == true)
            {
                label12.ForeColor = Color.Red;
            }
            else
            {
                label12.ForeColor = Color.Green;
            }

            if (Correct[4] == false)
            {
                label13.ForeColor = Color.Red;
            }
            else
            {
                label13.ForeColor = Color.Green;
            }

            if (Correct[5] == false)
            {
                label14.ForeColor = Color.Red;
            }
            else
            {
                label14.ForeColor = Color.Green;
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
   
        }
    }
}
