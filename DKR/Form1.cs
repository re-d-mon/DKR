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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130 , Color.Black);
            panel2.BackColor = Color.FromArgb(130, Color.Black);
            panel5.BackColor = Color.FromArgb(130, Color.Black);
            panel6.BackColor = Color.FromArgb(130, Color.Black);
            panel7.BackColor = Color.FromArgb(130, Color.Black);
            panel8.BackColor = Color.FromArgb(130, Color.Black);
            panel3.BackColor = Color.FromArgb(130, Color.Black);
            panel9.BackColor = Color.FromArgb(100, Color.Black);
            panel_up.BackColor = Color.FromArgb(130, Color.Black);
            alphaBlendTextBox1.BackColor = Color.Black;
            alphaBlendTextBox1.BackAlpha = 70;
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
            if (ZD1_Pane9_Visible.Value == 0)
            {


                panel9.Visible = false;
            }
            alphaBlendTextBox1.ForeColor = Color.MediumPurple;
            alphaBlendTextBox1.Text = "Сторона треугольника =";
            label_otvet_zd_1.Text = "Площадь треугольника: \r\n Радиус описанной окружности:  \r\n Радиус вписанной  окружности:";
        }

        private void button1_Click(object sender, EventArgs e)
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

        public void button_zd_1_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "Сторона треугольника =")
            {
                alphaBlendTextBox1.ForeColor = Color.LavenderBlush;
                alphaBlendTextBox1.Text = "";
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text =="")
            {
                alphaBlendTextBox1.ForeColor = Color.MediumPurple;
                alphaBlendTextBox1.Text = "Сторона треугольника =";
            }
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Popup;
            button1.BackColor = Color.FromArgb(100, Color.MediumPurple);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.FromArgb(100, Color.Black);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text.Contains ("."))
            {
                alphaBlendTextBox1.Text = alphaBlendTextBox1.Text.Replace(".", ",");
            }
            if (double.TryParse(alphaBlendTextBox1.Text, out double alphaBlendTextBox))
            {
                string out1 = Convert.ToString((Math.Pow(alphaBlendTextBox, 2) * Math.Sqrt(3)) / 4);
                string out2 = Convert.ToString(Math.Round(alphaBlendTextBox / (2 * Math.Sqrt(3)), 4));
                string out3 = Convert.ToString(double.Parse(alphaBlendTextBox1.Text)/ Math.Sqrt(3));
                if (double.Parse(out2) > 0)
                {
                    if (out2.Length >= 14)
                    {
                        label_otvet_zd_1.Height = 170;
                        button1.Location = new Point(235, 430);
                    }
                    else
                    {
                        label_otvet_zd_1.Height = 140;
                        button1.Location = new Point(235, 400);
                    }
                    label_otvet_zd_1.Text = "Площадь треугольника:" +out1 + " \r\n Радиус описанной окружности:" + out2 + " \r\n Радиус вписанной  окружности:"+out3;
                }
                else
                {
                    label_otvet_zd_1.Text = "Сторона триугольника должнать быть больше 0";
                }
            }
            else
            {
                label_otvet_zd_1.Text = "Вы ввели не число";
            }
        }

        private void alphaBlendTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button_zd_2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
