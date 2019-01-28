using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlanner_New
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1() 
        {
            InitializeComponent();
            birthdayParty = new BirthdayParty((int)numericUpDown2.Value, fancyCheckBox.Checked, CakeWritingBox.Text);
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayDinnerPartyCost();
        }
               private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            textBox1.Text = Cost.ToString("c");
        }
        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            BdaycostLabel.Text = birthdayParty.Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = checkBox1.Checked;
            DisplayDinnerPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOption = checkBox2.Checked;
            DisplayDinnerPartyCost();
        }

     

        private void CakeWritingBox_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = CakeWritingBox.Text;
            DisplayBirthdayPartyCost();
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyCheckBox.Checked;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthdayPartyCost();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
