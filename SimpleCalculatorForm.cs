using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class SimpleCalculatorForm : Form
    {
        SimpleCalculatorLogic Calculator;
        int MemoryClickCount;
        TextBox textBox;
        Label label;
        public SimpleCalculatorForm()
        {
            InitializeComponent();
            Calculator = new Calculator();

            TextBox.Text = "0";
            TextBoxEn.Text = "0";
            textBox = TextBox;

            Label.Text = "";
            LabelEn.Text = "";
            label = Label;
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

        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (textBox.Text.IndexOf("∞") != -1)
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (textBox.Text[0] == '0' && (textBox.Text.IndexOf(".") != 1))
                textBox.Text = textBox.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (textBox.Text[0] == '-')
                if (textBox.Text[1] == '0' && (textBox.Text.IndexOf(".") != 2))
                    textBox.Text = textBox.Text.Remove(1, 1);
        }

        private bool CanPress()
        {
            if (!ButtonMultiplication.Enabled)
                return false;

            if (!ButtonDivision.Enabled)
                return false;

            if (!ButtonSum.Enabled)
                return false;

            if (!ButtonSubtraction.Enabled)
                return false;

            if (!ButtonDivisionModule.Enabled)
                return false;

            if (!ButtonSqrt.Enabled)
                return false;

            if (!ButtonPow.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            ButtonMultiplication.Enabled = true;
            ButtonDivision.Enabled = true;
            ButtonSubtraction.Enabled = true;
            ButtonSum.Enabled = true;
            ButtonDivisionModule.Enabled = true;
            ButtonSqrt.Enabled = true;
            ButtonPow.Enabled = true;
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            label.Text = "";

            Calculator.ClearA();
            FreeButtons();

            MemoryClickCount = 0;
        }

        private void ButtonSetSign_Click(object sender, EventArgs e)
        {
            if (textBox.Text[0] == '-')
                textBox.Text = textBox.Text.Remove(0, 1);
            else
                textBox.Text = "-" + textBox.Text;
        }

        private void ButtonSetPoint_Click(object sender, EventArgs e)
        {
            if ((textBox.Text.IndexOf(".") == -1) && (textBox.Text.IndexOf("∞") == -1))
                textBox.Text += ".";
        }

        private void ButtonSetZero_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";

            CorrectNumber();
        }

        private void ButtonSetOne_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";

            CorrectNumber();
        }

        private void ButtonSetTwo_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";

            CorrectNumber();
        }

        private void ButtonSetThree_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";

            CorrectNumber();
        }

        private void ButtonSetFour_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";

            CorrectNumber();
        }

        private void ButtonSetFive_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";

            CorrectNumber();
        }

        private void ButtonSetSix_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";

            CorrectNumber();
        }

        private void ButtonSetSeven_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";

            CorrectNumber();
        }

        private void ButtonSetEight_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";

            CorrectNumber();
        }

        private void ButtonSetNine_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";

            CorrectNumber();
        }

        private void ButtonGetResult_Click(object sender, EventArgs e)
        {
            
            if (!ButtonMultiplication.Enabled)
                textBox.Text = Calculator.Multiplication(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonDivision.Enabled)
                textBox.Text = Calculator.Division(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonSum.Enabled)
                textBox.Text = Calculator.Sum(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonSubtraction.Enabled)
                textBox.Text = Calculator.Subtraction(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonPow.Enabled)
                textBox.Text = Calculator.Pow(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonDivisionModule.Enabled)
                textBox.Text = Calculator.DivisionModule(Convert.ToDouble(textBox.Text)).ToString();

            if (!ButtonSqrt.Enabled)
                textBox.Text = Calculator.Sqrt(Convert.ToDouble(textBox.Text)).ToString();

            Calculator.ClearA();
            FreeButtons();

            MemoryClickCount = 0;
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonMultiplication.Enabled = false;
                label.Text = textBox.Text + "*";
                textBox.Text = "0";
            }
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonDivision.Enabled = false;
                label.Text = textBox.Text + "/";

                textBox.Text = "0";
            }
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonSum.Enabled = false;
                label.Text = textBox.Text + "+";

                textBox.Text = "0";
            }
        }

        private void ButtonSubtraction_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonSubtraction.Enabled = false;
                label.Text = textBox.Text + "-";

                textBox.Text = "0";
            }
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonSqrt.Enabled = false;

                textBox.Text = "0";
            }
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonPow.Enabled = false;
                label.Text = textBox.Text + "^";

                textBox.Text = "0";
            }
        }

        private void ButtonFraction_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if (Convert.ToDouble(textBox.Text) != 0.0)
                {
                    Calculator.PutA(Convert.ToDouble(textBox.Text));
                    textBox.Text = Calculator.Fraction().ToString();
                    Calculator.ClearA();
                    FreeButtons();
                }
                else
                    MessageBox.Show("x > 0!");
            }
        }

        private void ButtonAbs_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));
                textBox.Text = Calculator.Abs().ToString();
                Calculator.ClearA();
                FreeButtons();
            }
        }

        private void ButtonDivisionModule_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));

                ButtonDivisionModule.Enabled = false;
                label.Text = textBox.Text + "%";

                textBox.Text = "0";
            }
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(textBox.Text) == (int)(Convert.ToDouble(textBox.Text))) && 
                    ((Convert.ToDouble(textBox.Text) >= 0.0)))
                {
                    Calculator.PutA(Convert.ToDouble(textBox.Text));

                    textBox.Text = Calculator.Factorial().ToString();

                    Calculator.ClearA();
                    FreeButtons();
                }
                else
                    MessageBox.Show("x >= 0!");
            }
        }

        private void ButtonInt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));
                textBox.Text = Calculator.Int().ToString();
                Calculator.ClearA();
                FreeButtons();
            }
        }

        private void ButtonCInt_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                Calculator.PutA(Convert.ToDouble(textBox.Text));
                textBox.Text = Calculator.CInt().ToString();
                Calculator.ClearA();
                FreeButtons();
            }
        }

        private void ButtonMemorySum_Click(object sender, EventArgs e)
        {
            Calculator.M_Sum(Convert.ToDouble(textBox.Text));
        }
 
        private void ButtonMemorySubtraction_Click(object sender, EventArgs e)
        {
            Calculator.M_Subtraction(Convert.ToDouble(textBox.Text));
        }

        private void ButtonMemoryMultiplication_Click(object sender, EventArgs e)
        {
            Calculator.M_Multiplication(Convert.ToDouble(textBox.Text));
        }

        private void ButtonMemoryDivision_Click(object sender, EventArgs e)
        {
            Calculator.M_Division(Convert.ToDouble(textBox.Text));
        }

        private void ButtonMemoryClear_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                MemoryClickCount++;
 
                if (MemoryClickCount == 1)
                    textBox.Text = Calculator.MemoryShow().ToString();
 
                if (MemoryClickCount == 2)
                {
                    Calculator.Memory_Clear();
                    textBox.Text = "0";

                    MemoryClickCount = 0;
                }
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == "Standard")
            {
                textBox = TextBox;
                label = Label;
            }
            else 
            { 
                textBox = TextBoxEn;
                label = LabelEn;
            }
        }

        private void ButtonDeleteLast_Click(object sender, EventArgs e)
        {
            int lenght = textBox.Text.Length - 1;
            string text = textBox.Text;
            textBox.Clear();
            for (int i = 0; i < lenght; i++)
                textBox.Text += text[i];
        }
    }
}
