using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class RegForm : Form
    {
        public RegForm(string data)
        {
            InitializeComponent();

        }


        private void RegOrSingForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            createmass();
        }
        char[] specialCharacters;
        char[] russianLetters;
        char[] nglishUpperCaseLetters;
        char[] englishLowerCaseLetters;
        char[] digits;
       private void createmass()
        {
            // Массив специальных символов
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', ';', ':', '\'', '"', ',', '.', '<', '>', '/', '?', '|', '\\' };

            // Массив всех русских букв
            char[] russianLetters = new char[66];
            for (int i = 0; i < 33; i++)
            {
                russianLetters[i] = (char)('А' + i);
                russianLetters[i + 33] = (char)('а' + i);
            }

            // Массив всех английских букв верхнего регистра
            char[] englishUpperCaseLetters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                englishUpperCaseLetters[i] = (char)('A' + i);
            }

            // Массив всех английских букв нижнего регистра
            char[] englishLowerCaseLetters = new char[26];
            for (int i = 0; i < 26; i++)
            {
                englishLowerCaseLetters[i] = (char)('a' + i);
            }

            // Массив цифр от 1 до 9
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
            }

        }
    }
}
