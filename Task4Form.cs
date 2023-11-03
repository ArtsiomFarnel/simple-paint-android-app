using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_
{
    public partial class Task4Form : Form
    {
        public Task4Form()
        {
            InitializeComponent();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeFormButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;
        private void TitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = (TextBox)sender;
                if (System.Text.RegularExpressions.Regex.IsMatch(text.Text, "  ^ [0-9]"))
                    text.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            TextBox textbox = sender as TextBox;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '.' && textbox.Text != "")
            {
                if (textbox.Text.IndexOf('.') != -1) e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && textbox.Text == "")
            {
                if (textbox.Text.IndexOf('-') != -1) e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void AbsButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    textBox2.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else textBox2.Text = "null";
        }

        private void CIntButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    textBox2.Text = Math.Ceiling(double.Parse(textBox1.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else textBox2.Text = "null";
        }

        private void FixButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    textBox2.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else textBox2.Text = "null";
        }

        private void IntButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    textBox2.Text = Math.Round(double.Parse(textBox1.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else textBox2.Text = "null";
        }

        private void SgrButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    if (double.Parse(textBox1.Text) > 0)
                    {
                        textBox2.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                    }
                    else textBox2.Text = "null";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else textBox2.Text = "null";
        }
    }
}
