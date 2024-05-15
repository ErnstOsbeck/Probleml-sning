namespace Problemlösning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int L = int.Parse(textBox1.Text);
            int S = int.Parse(textBox2.Text);
            string DH = textBox3.Text;

            if (L >= 180 && S >= 60)
            {
                label4.Text = "Center";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L >= 190 && S >= 40)
            {
                label4.Text = "Center";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L >= 170 && S >= 50 && DH.ToLower() == "höger")
            {
                label4.Text = "Vänster spiker";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L < 160 && S >= 65 && DH.ToLower() == "höger")
            {
                label4.Text = "Vänster spiker";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L >= 170 && S >= 50 && DH.ToLower() == "vänster")
            {
                label4.Text = "Höger spiker";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L < 160 && S >= 65 && DH.ToLower() == "vänster")
            {
                label4.Text = "Höger spiker";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L >= 165 && S < 50)
            {
                label4.Text = "Passare";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else if (L <= 160 && S <= 40)
            {
                label4.Text = "Libero";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}