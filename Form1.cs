using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox2.Text == "")
                {
                    double curs = double.Parse(TextBox.Text) * 99.00;
                    textBox2.Text = curs.ToString();
                }
                else if (TextBox.Text == "")
                {
                    double cursRub = double.Parse(textBox2.Text) / 99.00;
                    TextBox.Text = cursRub.ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox2.Text == "")
                {
                    double curs = double.Parse(TextBox.Text) * 144.77;
                    textBox2.Text = curs.ToString();
                }
                else if (TextBox.Text == "")
                {
                    
                        double cursRub = double.Parse(textBox2.Text) / 144.77;
                        TextBox.Text = cursRub.ToString();
                }
            }
            else if (radioButton3.Checked)
            {
                if (textBox2.Text == "")
                {
                    double curs = double.Parse(TextBox.Text) * 4360000.88;
                    textBox2.Text = curs.ToString();
                }
                else if (TextBox.Text == "")
                {
                    double cursRub = double.Parse(textBox2.Text) / 4360000.88;
                    TextBox.Text = cursRub.ToString();
                }
            }
            else if (radioButton4.Checked)
            {
                if (textBox2.Text == "")
                {
                    double curs = double.Parse(TextBox.Text) * 0.20;
                    textBox2.Text = curs.ToString();
                }
                else if (TextBox.Text == "")
                {
                    double cursRub = double.Parse(textBox2.Text) / 0.20;
                    TextBox.Text = cursRub.ToString();
                }
            }
            else if (radioButton5.Checked)
            {
                if (textBox2.Text == "")
                {
                    double curs = double.Parse(TextBox.Text) * 30.59;
                    textBox2.Text = curs.ToString();
                }
                else if (TextBox.Text == "")
                {
                    double cursRub = double.Parse(textBox2.Text) / 30.59;
                    TextBox.Text = cursRub.ToString();
                }
            }
        }

        private void Curse_click_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Curse_click_Click(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radioButton1":
                    label2.Text = "Доллар";
                    break;
                case "radioButton2":
                    label2.Text = "Евро";
                    break;
                case "radioButton3":
                    label2.Text = "Биткоин";
                    break;
                case "radioButton4":
                    label2.Text = "Тенге";
                    break;
                case "radioButton5":
                    label2.Text = "Шекель";
                    break;
            }
        }
    }
}