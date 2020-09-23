using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {

            //Create string str variable to get the text from the text box
            string str = txtPara.Text;
            //Create int variable to hold vowels
            int i, len, vowel, cons;
            //set to 0
            vowel = 0;
            
            //getting length of string
            len = str.Length;

            //using for loop to lopp through the string until it reaches the end length
            for (i = 0; i < len; i++)
            {
                //checks for vowels
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
          
            }
                //displays the number of vowels
                txtVowels.Text = Convert.ToString(vowel);
        }
    }
}
