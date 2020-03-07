using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        private Single Fahrenheit, Celcius;
        // Get rid of the global variables, create pure methods to convert temps, Unit Test both methods.
       
        public Form1()
        {
            InitializeComponent();
        }
        //button converts celsuis to fahrenheit

        private void btnCel_Click(object sender, EventArgs e)
        {
            txtCel.Text = Convert.ToString(CelFah(Fah:Convert.ToSingle(txtFah.Text)));
        }
     
        //2ND METHOD
        public Single CelFah(Single Fah)
        {
            Celcius = (float)((5.0 / 9.0) * (Fah - 32.0)); ;
            return Celcius;
        }


        //button converts fahrenheit to celsius
        private void btnFah_Click(object sender, EventArgs e)
        {
            txtFah.Text = Convert.ToString(FahCel(Cel: Convert.ToSingle(txtCel.Text)));;
        }

        //METHOD 

        public Single FahCel (Single Cel)
        {
            Fahrenheit = (float)(Cel * (9.0 / 5.0) + 32);
            return Fahrenheit;
        }
    }
}
