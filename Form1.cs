namespace PraktikumModul2
{
    public partial class Form1 : Form
    {
        int masukan_pertama = 0;
        int masukan_kedua = 0;
        int total = 0;
        public Form1()
        {

            InitializeComponent();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 7;
            }
            else
            {
                masukan_kedua = 7;
            }
            this.label1.Text = "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(masukan_pertama == 0) //UNIK ANGKA 0
            {
                masukan_pertama = 0;
            }
            else
            {
                masukan_kedua = 0;
            }
            this.label1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 9;
            }
            else
            {
                masukan_kedua = 9;
            }
            this.label1.Text = "9";
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 1;
            }
            else
            {
                masukan_kedua = 1;
            }
            this.label1.Text = "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 2;
            }
            else
            {
                masukan_kedua = 2;
            }
            this.label1.Text = "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 3;
            }
            else
            {
                masukan_kedua = 3;
            }
            this.label1.Text = "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 4;
            }
            else
            {
                masukan_kedua = 4;
            }
            this.label1.Text = "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 5;
            }
            else
            {
                masukan_kedua = 5;
            }
            this.label1.Text = "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 6;
            }
            else
            {
                masukan_kedua = 6;
            }
            this.label1.Text = "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (masukan_pertama == 0)
            {
                masukan_pertama = 8;
            }
            else
            {
                masukan_kedua = 8;
            }
            this.label1.Text = "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = total + masukan_pertama + masukan_kedua;

            this.label1.Text = Convert.ToString(total);
            total = 0;
            masukan_pertama = 0;
            masukan_kedua = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "+";
        }
    }
}