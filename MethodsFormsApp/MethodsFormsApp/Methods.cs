using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodsFormsApp
{
    public partial class Methods : Form
    {

        const int size =  10;

        int[] number = new int[size];
        public Methods()
        {
            InitializeComponent();
        }

        private string Show()
        {
            string message = "";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    message = message + "Element at index[" + index + "] is " + number[index].ToString() + "\n";
            }

            return message;
        }

        int count = 0;
        private void AddButton_Click(object sender, EventArgs e)
        {
            number[count] = Convert.ToInt32(InputTextBox.Text);
            count++;
            string message = "";

            message = "Input Value\n";
            message = message + Show();

            //for (int index = 0; index < number.Length; index++)
            //{
            //    if (number[index] != 0)
            //        message = message + "Element at index[" + index + "] is " + number[index].ToString() + "\n";
            //}

            ShowRichTextBox.Text = message;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";

            message = "Input Value\n";
            message = message + Show();

            //for (int index = 0; index < number.Length; index++)
            //{
            //    if (number[index] != 0)
            //        message = message + "Element at index[" + index + "] is " + number[index].ToString() + "\n";
            //}

            ShowRichTextBox.Text = message;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = "";

            message = "Input Value\n";
            message = message + Show();

            message = message + "Reverse Value\n";

            for (int index = size-1; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "Element at index[" + index + "] is " + number[index].ToString() + "\n";
            }

            ShowRichTextBox.Text = message;
        }


    }
}
