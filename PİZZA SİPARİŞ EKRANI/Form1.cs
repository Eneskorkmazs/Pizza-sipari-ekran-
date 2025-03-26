namespace PİZZA_SİPARİŞ_EKRANI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int fiyat = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                fiyat += 130;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                fiyat += 160;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                fiyat += 200;
            }

            if (radioButton1.Checked == true)
            {
                fiyat += 15;

            }
            else if (radioButton2.Checked == true)
            {
                fiyat += 15;
            }

            if (checkBox1.Checked == true)
            {
                fiyat += 30;
            }
            if (checkBox2.Checked == true)
            {
                fiyat += 22;
            }
            if (checkBox3.Checked == true)
            {
                fiyat += 19;
            }
            if (checkBox4.Checked == true)
            {
                fiyat += 25;
            }
            if (checkBox5.Checked == true)
            {
                fiyat += 7;
            }
            if (checkBox6.Checked == true)
            {
                fiyat += 11;
            }
            if (checkBox7.Checked == true)
            {
                fiyat += 14;
            }
            if (checkBox8.Checked == true)
            {
                fiyat += 10;
            }
            if (checkBox9.Checked == true)
            {
                fiyat += 13;
            }
            if (checkBox10.Checked == true)
            {
                fiyat += 15;
            }
            int adet = 0;

            adet = Convert.ToInt32(textBox1.Text);
            fiyat = fiyat * adet;

            textBox2.Text = fiyat.ToString() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
