using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_
{
    public partial class MainForm : Form
    {

        public MainForm()
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

        Form SelectedForm;
        private void OpenTasksButton_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                if (SelectedForm != null) SelectedForm.Close();
                if (button.TabIndex == 7) SelectedForm = new Task7Form();
                else if (button.TabIndex == 6) SelectedForm = new Task6Form();
                else if (button.TabIndex == 5) SelectedForm = new Task5Form();
                else if (button.TabIndex == 4) SelectedForm = new Task4Form();
                else if (button.TabIndex == 3) SelectedForm = new Task3Form();
                else if (button.TabIndex == 2) SelectedForm = new Task2Form();
                else SelectedForm = new EmptyForm();
                SelectedForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
