namespace fukuv0601
{
    public partial class Form1 : Form
    {
        int vx = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             vx = -10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             vx = +10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Text = "KATO MASAHIRO";
        }
    }
}