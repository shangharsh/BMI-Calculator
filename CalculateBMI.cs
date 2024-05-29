using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class CalculateBMI : Form
    {
        public CalculateBMI()
        {
            InitializeComponent();
        }

        void Calculate()
        {

            if ( TxtHeight.TextLength>0 && TxtWeight.TextLength > 0 && ComboUnit.SelectedIndex == 0)
            {
                //MessageBox.Show("Pound");
                //
                double bmi, weight, height;
                weight = double.Parse(TxtWeight.Text.ToString());
                height = double.Parse(TxtHeight.Text.ToString());

                bmi = 703*weight / (height * height);
                if (bmi < 18.5)
                {
                    //TxtResult.BackColor = Color.Yellow;
                    TxtStatus.BackColor = Color.Yellow;
                    TxtStatus.Text = "UnderWeight";
                    TxtStatus.ForeColor = Color.White;

                }
                else if (bmi > 18.5 && bmi < 25)
                {
                    //TxtResult.BackColor = Color.Green;
                    TxtStatus.BackColor = Color.Green;
                    TxtStatus.Text = "HealthyWeight";
                    TxtStatus.ForeColor = Color.White;

                }
                else if (bmi > 25 && bmi < 30)
                {
                    //TxtResult.BackColor = Color.Orange;
                    TxtStatus.BackColor = Color.Orange;
                    TxtStatus.Text = "OverWeight";
                    TxtStatus.ForeColor = Color.White;

                }
                else if (bmi > 30)
                {
                    //TxtResult.BackColor = Color.Red;
                    TxtStatus.BackColor = Color.Red;
                    TxtStatus.Text = "Obesity";
                    TxtStatus.ForeColor = Color.White;

                }
                TxtResult.Text = bmi.ToString();
                //MessageBox.Show(bmi.ToString());
                //Math.Round(bmi * 10 ^ x) / 10 ^ x

            }
            else if (TxtHeight.TextLength > 0 && TxtWeight.TextLength > 0 && ComboUnit.SelectedIndex == 1)
            {
                //MessageBox.Show("Kg");
                //Calculate();
                double bmi, weight, height;
                weight = double.Parse(TxtWeight.Text.ToString());
                height = double.Parse(TxtHeight.Text.ToString());

                bmi = weight / (height * height);
                if (bmi < 18.5)
                {
                    //TxtResult.BackColor = Color.Yellow;
                    TxtStatus.BackColor = Color.Yellow;
                    TxtStatus.Text = "UnderWeight";
                    TxtStatus.ForeColor = Color.White;
                }
                else if (bmi > 18.5 && bmi < 25)
                {
                    //TxtResult.BackColor = Color.Green;
                    TxtStatus.BackColor = Color.Green;
                    TxtStatus.Text = "HealthyWeight";
                    TxtStatus.ForeColor = Color.White;

                }
                else if (bmi > 25 && bmi < 30)
                {
                    //TxtResult.BackColor = Color.Orange;
                    TxtStatus.BackColor = Color.Orange;
                    TxtStatus.Text = "OverWeight";
                    TxtStatus.ForeColor = Color.White;

                }
                else if (bmi > 30)
                {
                    //TxtResult.BackColor = Color.Red;
                    TxtStatus.BackColor = Color.Red;
                    TxtStatus.Text = "Obesity";
                    TxtStatus.ForeColor = Color.White;

                }
                TxtResult.Text = bmi.ToString();
                //MessageBox.Show(bmi.ToString());
                //Math.Round(bmi * 10 ^ x) / 10 ^ x
            }
            else
            {
                MessageBox.Show("Please Select Option From Unit List");
            }





            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
           Calculate();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtWeight.Clear();
            TxtHeight.Clear();
            ComboUnit.SelectedIndex = -1;
            TxtResult.Clear();
            TxtStatus.Clear();
        }

        
    }
}
