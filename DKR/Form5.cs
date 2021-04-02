using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DKR
{
    public partial class Form5 : Form
    {
        public int start;
        public Form5()
        {

            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.Black);
            panel2.BackColor = Color.FromArgb(130, Color.Black);
            panel5.BackColor = Color.FromArgb(130, Color.Black);
            panel6.BackColor = Color.FromArgb(130, Color.Black);
            panel7.BackColor = Color.FromArgb(130, Color.Black);
            panel8.BackColor = Color.FromArgb(130, Color.Black);
            panel3.BackColor = Color.FromArgb(130, Color.Black);
            panel9.BackColor = Color.FromArgb(100, Color.Black);
            panel_up.BackColor = Color.FromArgb(130, Color.Black);
            label1.BackColor = Color.FromArgb(130, Color.Black);
            button_close.BackColor = Color.FromArgb(130, Color.PaleVioletRed);
            button_zd_1.FlatStyle = FlatStyle.Flat;
            button_zd_1.FlatAppearance.BorderColor = Color.White;
            button_zd_1.FlatAppearance.BorderSize = 1;
            button_zd_1.BackColor = Color.FromArgb(130, Color.Black);
            button_zd_2.FlatStyle = FlatStyle.Flat;
            button_zd_2.FlatAppearance.BorderColor = Color.White;
            button_zd_2.FlatAppearance.BorderSize = 1;
            button_zd_2.BackColor = Color.FromArgb(130, Color.Black);
            button_zd_3.FlatStyle = FlatStyle.Flat;
            button_zd_3.FlatAppearance.BorderColor = Color.White;
            button_zd_3.FlatAppearance.BorderSize = 1;
            button_zd_3.BackColor = Color.FromArgb(130, Color.Black);
            button_zd_4.FlatStyle = FlatStyle.Flat;
            button_zd_4.FlatAppearance.BorderColor = Color.White;
            button_zd_4.FlatAppearance.BorderSize = 1;
            button_zd_4.BackColor = Color.FromArgb(130, Color.Black);
            button_zd_5.FlatStyle = FlatStyle.Flat;
            button_zd_5.FlatAppearance.BorderColor = Color.White;
            button_zd_5.FlatAppearance.BorderSize = 1;
            button_zd_5.BackColor = Color.FromArgb(130, Color.Black);
            panel9.Visible = true;
            alphaBlendTextBox1.ForeColor = Color.MediumPurple;
            alphaBlendTextBox1.Text = "X=";
        }
        private void button_zd_1_Click(object sender, EventArgs e)
        {
            ZD1_Pane9_Visible.Value = 1;
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void г(object sender, MouseEventArgs e)
        {
            label1.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }
        private void button_zd_1_MouseEnter(object sender, EventArgs e)
        {
            button_zd_1.FlatStyle = FlatStyle.Popup;
            button_zd_1.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void button_zd_1_MouseLeave(object sender, EventArgs e)
        {
            button_zd_1.FlatStyle = FlatStyle.Flat;
            button_zd_1.BackColor = Color.FromArgb(130, Color.Black);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button_zd_2.FlatStyle = FlatStyle.Popup;
            button_zd_2.BackColor = Color.FromArgb(0, Color.Black);
        }
        private void button_zd_3_MouseEnter(object sender, EventArgs e)
        {
            button_zd_3.FlatStyle = FlatStyle.Popup;
            button_zd_3.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void button_zd_4_MouseEnter(object sender, EventArgs e)
        {
            button_zd_4.FlatStyle = FlatStyle.Popup;
            button_zd_4.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void button_zd_5_MouseEnter(object sender, EventArgs e)
        {
            button_zd_5.FlatStyle = FlatStyle.Popup;
            button_zd_5.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void button_zd_2_MouseLeave(object sender, EventArgs e)
        {
            button_zd_2.FlatStyle = FlatStyle.Flat;
            button_zd_2.BackColor = Color.FromArgb(130, Color.Black);
        }

        private void button_zd_3_MouseLeave(object sender, EventArgs e)
        {
            button_zd_3.FlatStyle = FlatStyle.Flat;
            button_zd_3.BackColor = Color.FromArgb(130, Color.Black);
        }

        private void button_zd_4_MouseLeave(object sender, EventArgs e)
        {
            button_zd_4.FlatStyle = FlatStyle.Flat;
            button_zd_4.BackColor = Color.FromArgb(130, Color.Black);
        }

        private void button_zd_5_MouseLeave(object sender, EventArgs e)
        {
            button_zd_5.FlatStyle = FlatStyle.Flat;
            button_zd_5.BackColor = Color.FromArgb(130, Color.Black);
        }

        private void alphaBlendTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "X=")
            {
                alphaBlendTextBox1.ForeColor = Color.LavenderBlush;
                alphaBlendTextBox1.Text = "";
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "")
            {
                alphaBlendTextBox1.ForeColor = Color.MediumPurple;
                alphaBlendTextBox1.Text = "X=";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text.Contains("."))
            {
                alphaBlendTextBox1.Text = alphaBlendTextBox1.Text.Replace(".", ",");
            }
            if (double.TryParse(alphaBlendTextBox1.Text, out double alphaBlendTextBox))
            {
                if ((alphaBlendTextBox < 1.3) && (alphaBlendTextBox > -1.3))
                {
                    label_otvet_zd_1.Text = "Нет решение \r\n Выведение логарифма из отрицательного числа";
                }
                else
                {
                    string out1 = Convert.ToString(Math.Sqrt(2 * (Math.Log(3 * Math.Pow(alphaBlendTextBox, 2) - 4)) / Math.Log(9)) - (Math.Log(Math.Sqrt(3 * Math.Pow(alphaBlendTextBox, 2) - 4))) / Math.Log(3));
                    label_otvet_zd_1.Text = "Y=" + out1;
                }
            }
            else
            {
                label_otvet_zd_1.Text = "Вы ввели не число";
            }
        }
    }
    }

