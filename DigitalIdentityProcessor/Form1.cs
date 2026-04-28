using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(
                fullName: textBox1.Text,
                IDNumber: textBox2.Text,
                citizenshipStatus: comboBox1.SelectedItem.ToString()
                );

            label5.Text = profile.validateID();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IDNumber;
            string fullName;
            CitizenProfile profile = new CitizenProfile
            (
                fullName: textBox1.Text,
                IDNumber: textBox2.Text,
                citizenshipStatus: comboBox1.SelectedItem.ToString()
            );

            label5.Text = profile.GenerateProfile();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // shouldn't have done this
        }
    }
}
