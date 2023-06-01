namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = - 10;
        int vy = - 10;
        string chr = "BAKA";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx -= 10;
            //label1.Text = "KAMEHAMEHA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = 10;
            //label1.Text = "LOL";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;  
            string t = label1.Text;
            label1.Text = chr;
            chr = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "KATO MASAHIRO";
        }
    }
}