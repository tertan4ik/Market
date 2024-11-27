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
   

        }

        private void label5_Click(object sender, EventArgs e)
        {
            string data = "¬ход";
            Form reg = new RegForm(data);
            reg.Show();
            this.FormClosed += (s, args) => this.Close();
            this.Hide();
        }
    }
}
