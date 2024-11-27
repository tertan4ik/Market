namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form sign = new SignInForm();
            sign.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {          
            Form reg = new RegForm();
            reg.Show();       
            this.Hide();
        }
    }
}
