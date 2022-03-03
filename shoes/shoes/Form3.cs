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
    public partial class Form3 : Form
    {
        public Form3()
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

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Launcher browser to downlaod link - Adobe After Effects
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1MJaCgM2aM6CTJY8V0WWK5SEYgkykbC0-?usp=sharing");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Home Button on Nv bar
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Launches browser to download link for Adobe Photoshop 2021
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1LOYnqRYh-MJ4PHv9LLuK5uWHrh1k15EK?usp=sharing");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Catagorie button on Nav bar
            this.Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Launches browser to downlaod link for Adobe Illustrator 2021
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1AOpNx-1sn5K2ct3MhcjeSaecGgMw7UJO?usp=sharing");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Launches browser to downlaod link Adobe Premire 2021
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1HSdmGczBK34qdtDutAZZ-26HQmn7xJSN?usp=sharing");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Lanunches browser to downlado link for Microsoft Office 2013
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1xd5GfI4GR7GyRMW4WmQ4wS8bo03myVzb?usp=sharing");
        }
    }
}
