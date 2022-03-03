using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace shoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GunaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //All button on Nav bar
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Exit button
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Minimize tab button
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            //GP-3 Logo
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            //Downlaod button
                this.Visible = false;
                Form2 form2 = new Form2();
                form2.Visible = true;
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Automotive button on nav bar
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Simulator on Nav bar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Action button on Nav bar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Office button on Nav Bar
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Racing / Car under hot releases
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //Simulator unber hot releases
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Office software under hot releases
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Sports under hot releases
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //New Releases button on Nav bar
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Hot Releases text
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Forza Horizon 5 under hot releases
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Farming Simulator under hot releases
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Adobe Photoshop under hot releases
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Fifa 19 under hot releases
        }
    }
}
