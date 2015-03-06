using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string txt;
        //txt = textBoxNumero.Text; 
       
        public string result;

        private void Recursão(object sender, EventArgs e)
        {
           
            int n = Convert.ToInt32(textBoxNumero.Text);
            Recur(n);
            Result.Text = "Resultado: " + Convert.ToString(Recur(n));
        }

        static int Recur(int n){
             
            if (n <= 1)
            {
                return 1; 
             }
             else
             {
                 return n * Recur(n - 1);
             }
        }

        private void Iteração(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxNumero.Text);
            int r = n;

            for (int i = n - 1; i > 0; i--)
            {
                r *= i;
            }

            Result.Text = "Resultado: " + Convert.ToString(r);
        }
    }
}
