using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }
        private DataEntry de = new DataEntry();

        private void signinbtn_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                DataEntry de = new DataEntry()
                {
                    Text = "Hello User!"
                };
                de.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
        //Enter key pressed situations
        private void Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbtn.PerformClick();
                //MessageBox.Show("Enter Key Pressed ");
            }
        }
        private void fnamebox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbtn.PerformClick();
                //MessageBox.Show("Enter Key Pressed ");
            }
        }
        private void lnamebox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbtn.PerformClick();
                //MessageBox.Show("Enter Key Pressed ");
            }
        }
        private void unum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbtn.PerformClick();
                //MessageBox.Show("Enter Key Pressed ");
            }
        }
        private void unum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signinbtn.PerformClick();
                //MessageBox.Show("Enter Key Pressed ");
            }
        }

        //Start Validating...
        public bool Validate()
        {
            return (
                !this.IsPresentfirst(this.fnamebox) ||
                !this.IsItAllLetterfirst(this.fnamebox) ||
                !this.IsPresentlast(this.lnamebox) ||
                !this.IsItAllLetterlast(this.lnamebox) ||
                !this.IsItPresentu1(this.unum1) ||
                !this.IsIt4Digits(this.unum1) ||
                !this.IsItPresentu2(this.unum1)
                ? false : this.IsIt4Digits(this.unum2)
            );
        }
        //is it present for first name
        public bool IsPresentfirst(TextBox textBox)
        {
            bool flag;
            if (textBox.Text != "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(string.Concat("First name is a required field."), "Entry Error");
                textBox.Focus();
                flag = false;
            }
            return flag;
        }
        //is it present for last name
        public bool IsPresentlast(TextBox textBox)
        {
            bool flag;
            if (textBox.Text != "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(string.Concat("Last name is a required field."), "Entry Error");
                textBox.Focus();
                flag = false;
            }
            return flag;
        }
        //is it all letter for first name
        public bool IsItAllLetterfirst(TextBox textBox)
        {
            bool flag;
            string text = textBox.Text;
            int num = 0;
            while (true)
            {
                if (num >= text.Length)
                {
                    flag = true;
                    break;
                }
                else if (char.IsLetter(text[num]))
                {
                    num++;
                }
                else
                {
                    MessageBox.Show(string.Concat("First name must contain only letters."), "Entry Error");
                    textBox.Focus();
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        //is it all letter for last name
        public bool IsItAllLetterlast(TextBox textBox)
        {
            bool flag;
            string text = textBox.Text;
            int num = 0;
            while (true)
            {
                if (num >= text.Length)
                {
                    flag = true;
                    break;
                }
                else if (char.IsLetter(text[num]))
                {
                    num++;
                }
                else
                {
                    MessageBox.Show(string.Concat("Last name must contain only letters."), "Entry Error");
                    textBox.Focus();
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        //is first unum present
        public bool IsItPresentu1(TextBox textBox)
        {
            bool flag;
            if (textBox.Text != "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(string.Concat("First half of U-number is a required field."), "Entry Error");
                textBox.Focus();
                flag = false;
            }
            return flag;
        }
        //is second unum present
        public bool IsItPresentu2(TextBox textBox)
        {
            bool flag;
            if (textBox.Text != "")
            {
                flag = true;
            }
            else
            {
                MessageBox.Show(string.Concat("Second half of U-number is a required field."), "Entry Error");
                textBox.Focus();
                flag = false;
            }
            return flag;
        }
        //Is it 4 digit
        public bool IsIt4Digits(TextBox textBox)
        {
            bool flag;
            if (textBox.Text.Length == 4)
            {
                string text = textBox.Text;
                int num = 0;
                while (num < text.Length)
                {
                    if (char.IsDigit(text[num]))
                    {
                        num++;
                    }
                    else
                    {
                        MessageBox.Show(string.Concat("First half of U-number must contain 4 digits."), "Entry Error");
                        textBox.Focus();
                        flag = false;
                        return flag;
                    }
                }
                flag = true;
            }
            else
            {
                MessageBox.Show(string.Concat("Second half of U-number must contain 4 digits."), "Entry Error");
                textBox.Focus();
                flag = false;
            }
            return flag;
        }

        private void unum1_TextChanged(object sender, EventArgs e)
        {
            if (unum1.Text.Length == 4)
            {
                unum2.Focus();
            }
        }

        //private void unum1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsNumber(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void unum2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsNumber(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}

