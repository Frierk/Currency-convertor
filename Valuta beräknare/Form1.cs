namespace Valuta_beräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Standard
        private void buttonVtH_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.09).ToString();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.11).ToString();
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.078).ToString();
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox7.Text)).ToString();
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 11.08).ToString();
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 1.17).ToString();
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.87).ToString();
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    double sek = 1 * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * (sek * 11.08)).ToString();
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 9.44).ToString();
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.85).ToString();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 0.74).ToString();
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    double sek = 1 * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * (sek * 9.44)).ToString();
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 12.76).ToString();
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 1.15).ToString();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * 1.35).ToString();
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    double sek = 1 * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * (sek * 12.76)).ToString();
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                   textBox2.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox7.Text)).ToString();
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    double sek = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (sek * 0.09).ToString();
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    double sek = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (sek * 0.11).ToString();
                }
                if (comboBox2.SelectedIndex == 3)
                {
                    double sek = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox7.Text);
                    textBox2.Text = (sek * 0.078).ToString();
                }
                if (comboBox2.SelectedIndex == 4)
                {
                    textBox2.Text = textBox1.Text;
                }
            }
        }
        private void buttonHtV_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 11.08).ToString();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 9.44).ToString();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) * 12.76).ToString();
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.09).ToString();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.85).ToString();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 1.15).ToString();
                }
            }
            if (comboBox2.SelectedIndex == 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.11).ToString();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 1.17).ToString();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Text = textBox2.Text;
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 1.35).ToString();
                }
            }
            if (comboBox2.SelectedIndex == 3)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.078).ToString();
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.87).ToString();
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Text = (Convert.ToDouble(textBox2.Text) / 0.74).ToString();
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    textBox1.Text = textBox2.Text;
                }
            }
            if (comboBox2.SelectedIndex == 4)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox2.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox7.Text)).ToString();
                }
            }
        }
        private void buttonCl_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Custom
        private void buttonVtHSp_Click(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox5.Text)).ToString();
        }
        private void buttonHtVSp_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox4.Text) / Convert.ToDouble(textBox5.Text)).ToString();
        }
        private void ButtonClSp_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
