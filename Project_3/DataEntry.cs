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
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        private List<double> allGPA = new List<double>();
        private List<char> allGrades = new List<char>();
        private List<int> allHours = new List<int>();
        private char grade = '.';
        public double gpa;
        
        //enter button calculations
        private void enterbtn_Click(object sender, EventArgs e)
        {
                if (this.grade == '.')
                {
                    MessageBox.Show("A grade must be selected.", "Grade Missing");
                }
                else if (this.credithrsbox.SelectedIndex != -1)
                {
                    this.allGrades.Add(grade);
                    this.allHours.Add(Convert.ToInt32(this.credithrsbox.SelectedItem));
                    this.CalculateGPA();
                    this.allGPA.Add(this.gpa);
                    this.ShowDetail();
                    this.credithrsbox.SelectedIndex = -1;
                }
                else if (this.credithrsbox.SelectedIndex == -1)
                {
                    MessageBox.Show("Credit hours must be selected.", "Credit Hours Missing");
                }
        }

        private void ChooseGrade(object sender, EventArgs e)
        {
            string name = ((RadioButton)sender).Name;
            if (name == "radioButtonA")
            {
                grade = 'A';
            }
            else if (name == "radioButtonB")
            {
                grade = 'B';
            }
            else if (name == "radioButtonC")
            {
                grade = 'C';
            }
            else if (name == "radioButtonD")
            {
                grade = 'D';
            }
            else if (name == "radioButtonF")
            {
                grade = 'F';
            }
        }

        private void CalculateGPA()
        {
            int pt = 0;
            int it = 0;
            int num = 0;
            for (int i = 0; i < this.allGrades.Count; i++)
            {
                pt = this.Situation(this.allGrades[i]);
                it += this.allHours[i];
                num = num + pt * this.allHours[i];
            }
            this.gpa = Convert.ToDouble(num) / (double)it;
        }

        private void CalculateGPA(int total)
        {
            int pt = 0;
            int it = 0;
            int num = 0;
            for (int i = 0; i < total; i++)
            {
                pt = this.Situation(this.allGrades[i]);
                it += this.allHours[i];
                num = num + pt * this.allHours[i];
            }
            this.gpa = Convert.ToDouble(num) / (double)it;
        }

        private void ShowDetail()
        {
            this.lstDetail.Items.Clear();
            for (int i = 0; i < this.allGrades.Count; i++)
            {
                //arrays
                string[] string1 = new string[8];
                //keep count increment by 1
                int it = i + 1;
                string1[0] = it.ToString();
                string1[1] = " -- ";

                char chr = this.allGrades[i];
                string1[2] = chr.ToString();
                string1[3] = " -- ";

                it = this.allHours[i];
                string1[4] = it.ToString();
                string1[5] = "  (GPA: ";

                double num = this.allGPA[i];
                string1[6] = num.ToString("N3");
                string1[7] = ")";

                string string2 = string.Concat(string1);
                this.lstDetail.Items.Add(string2);
            }
        }

        //copied over from Project_2
        private int Situation(char character)
        {
            int sit0 = 0;
            switch (char.ToUpper(character))
            {
                case 'A':
                    {
                        sit0 = 4;
                        break;
                    }
                case 'B':
                    {
                        sit0 = 3;
                        break;
                    }
                case 'C':
                    {
                        sit0 = 2;
                        break;
                    }
                case 'D':
                    {
                        sit0 = 1;
                        break;
                    }
                case 'F':
                    {
                        sit0 = 0;
                        break;
                    }
            }
            return sit0;
        }

        private void rmbtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.lstDetail.SelectedIndex;
            if (selectedIndex != -1)
            {
                this.allGrades.RemoveAt(selectedIndex);
                this.allHours.RemoveAt(selectedIndex);
                this.allGPA.Clear();
                for (int i = 0; i < this.allGrades.Count; i++)
                {
                    this.CalculateGPA(i + 1);
                    this.allGPA.Add(this.gpa);
                }
                this.ShowDetail();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            this.credithrsbox.SelectedIndex = -1;
            this.allGrades.Clear();
            this.allHours.Clear();
            this.allGPA.Clear();
            this.lstDetail.Items.Clear();
            this.radioButtonA.Checked = false;
            this.radioButtonB.Checked = false;
            this.radioButtonC.Checked = false;
            this.radioButtonD.Checked = false;
            this.radioButtonF.Checked = false;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program?", "Closing Program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
