using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Oct16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Pet myDog = new Pet();
            //myDog.Name = "whatever I want";
            MessageBox.Show("Your dog's name is " + myDog.Name);
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            Pet myCat = new Pet();
            //myCat.Name = "skittles";
            MessageBox.Show("Your cat's name is " + myCat.Name);
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            Pet myHuman = new Pet();
            //myHuman.Name = "Bitch";
            MessageBox.Show("You sick bastard");
        }
    }
}
