namespace Formularz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            label4.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string haslo = textBox2.Text;
            string phaslo = textBox3.Text;

            if (textBox1.Text == string.Empty)
            {
                label10.ForeColor = Color.Red;
                label10.Text = "Podaj email";
            }
            else
            {
                label6.Text = "Email: " + email;
                label10.Text = null;
            }

            if (haslo == string.Empty)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Podaj haslo";
            }
            else if (haslo.Length < 8)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Has³o ma byæ d³u¿sze ni¿ 8 znaków";
            }
            else if (haslo != phaslo)
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Has³a nie s¹ identyczne";
            }
            else
            {
                label7.Text = haslo;
                label4.Text = null;
            }

            if (checkBox1.Checked == true)
            {
                label8.Text = "Zgadza siê";
                label11.Text = null;
            }
            else
            {
                label11.ForeColor = Color.Red;
                label11.Text = "Nie zaznaczono";
                checkBox1.Enabled = false;
            }

            if (radioButton1.Checked == true)
            {
                label9.Text = "Ma³a";
            }
            else if (radioButton2.Checked == true)
            {
                label9.Text = "Du¿a";
            }
            else if (radioButton3.Checked == true)
            {
                label9.Text = "Œrednia";
            }
            else
            {
                label9.Text = null;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numericUpDown1.Value + numericUpDown2.Value;
            label12.Text = a.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal a = numericUpDown1.Value + numericUpDown2.Value;
            label12.Text = a.ToString();
        }
    }
}