using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodeString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncodeButton_Click(object sender, EventArgs e)
        {

            //grabs user's input from InputTextBox
            string userInput = InputTextBox.Text;

            //changes capital letters to lowercase so the program isn't case-sensitive
            string userInLower = userInput.ToLower();

            //clears ResultLabel for subsequent clicks
            ResultLabel.Text = "";
                     
            for(int index = 0; index < userInLower.Length; index++)
            {
                //checks string userInLower for repeated characters
                if (userInLower.LastIndexOf(userInLower[index]) == userInLower.IndexOf(userInLower[index]))
                {
                    //Appends "(" to ResultLabel for every repeated char
                    ResultLabel.Text += "(";
                }
                else
                {
                    //Appends ")" to ResultLabel for every non-repeated char
                    ResultLabel.Text += ")";
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clears both InputTextBox and ResultLable
            InputTextBox.Text = "";
            ResultLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {            
            //closes the application
            this.Close();
        }
    }
}
