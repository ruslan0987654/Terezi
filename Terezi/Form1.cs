using System;
using System.Windows.Forms;

namespace Terezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            string cekiS = maskedTextBox1.Text;
            string boyS = maskedTextBox2.Text;

            if (string.IsNullOrEmpty(cekiS) || string.IsNullOrEmpty(boyS))
            {
                MessageBox.Show("Sahələr boşdur", "Xəta", MessageBoxButtons.OK);
            }
            else
            {
                int ceki = int.Parse(cekiS);
                int boy = int.Parse(boyS);

                if (ceki < 1 || ceki > 500)
                {
                    MessageBox.Show("Çəki düzgün deyil", "Xəta", MessageBoxButtons.OK);
                }
                else if (boy < 20 || boy > 300)
                {
                    MessageBox.Show("Boy düzgün deyil", "Xəta", MessageBoxButtons.OK);
                }
                else
                {
                    double bki = ceki * 10000.0 / (boy * boy);

                    label1.Text = bki.ToString("0.00");

                    if (bki < 18.5)
                    {
                        pictureBox1.Visible = true;
                        label2.Text = "Çəki azlığı (Arıq)";
                    }
                    else if (bki < 25)
                    {
                        pictureBox2.Visible = true;
                        label2.Text = "Normal çəki";
                    }
                    else if (bki <= 32)
                    {
                        pictureBox3.Visible = true;
                        label2.Text = "Artıq çəki";
                    }
                    else if (bki < 40)
                    {
                        pictureBox4.Visible = true;
                        label2.Text = "I dərəcəli piylənmə";
                    }
                    else
                    {
                        pictureBox5.Visible = true;
                        label2.Text = "III dərəcəli (Morbid) piylənmə";
                    }
                }
            }
        }
    }
}