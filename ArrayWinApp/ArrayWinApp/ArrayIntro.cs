using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayWinApp
{
    public partial class ArrayIntro : Form
    {
        const int size = 10;
        int index = 0;
        int[] numbers = new int[size];

        public ArrayIntro()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            

            string message = "";

            for(int index=0; index<size; index++)
            {
                if (numbers[index] != 0)
                    message = message + "Value of Index [" + index + "] is " + numbers[index].ToString() + "\n"; 
            }

            ResultRichTextBox.Text = message;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            numbers[index] = Convert.ToInt32(addTextBox.Text);
            index++;
            addTextBox.Text = string.Empty;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            ResultRichTextBox.Text = string.Empty;

            string message = "";

            for (int index = size-1; index >= 0; index--)
            {
                if (numbers[index] != 0)
                    message = message + "Value of Index [" + index + "] is " + numbers[index].ToString() + "\n";
            }

            ResultRichTextBox.Text = message;
        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for(int index = 0; index < size; index++)
            {
                if (numbers[index] != 0)
                    sum = sum + numbers[index];
            }

            ResultRichTextBox.Text = "Sum is : " + sum.ToString();

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int[] reverseArray = new int[size];

            for (int index = 0; index < size; index++)
            {
                reverseArray[index] = numbers[index];
            }

            ResultRichTextBox.Text = string.Empty;

            string message = "";

            for (int index = 0; index < size; index++)
            {
                if (reverseArray[index] != 0)
                    message = message + "Value of Index [" + index + "] is " + reverseArray[index].ToString() + "\n";
            }

            ResultRichTextBox.Text = message;
        }

        private void DuplicteButton_Click(object sender, EventArgs e)
        {
            int[] duplicateArray = new int[size];
            int count = 0;
            for (int index=0; index<size; index++)
            {
                int flag = 0;
                
                for(int check=index+1; check<size; check++)
                {
                    if (numbers[index] == numbers[check])
                        flag = numbers[index];
                }
                if(flag != 0)
                {
                    duplicateArray[count] = flag;
                    count++;
                }
                    
            }

            string message = "";

            for (int index = 0; index < size; index++)
            {
                if (duplicateArray[index] != 0)
                    message = message + "Value of Index [" + index + "] is " + duplicateArray[index].ToString() + "\n";
            }

            ResultRichTextBox.Text = message;

        }

        private void Uniquebutton_Click(object sender, EventArgs e)
        {
            int[] uniqueArray = new int[size];
            int count = 0;
            for (int index = 0; index < size; index++)
            {
                int flag = 0;

                for (int check = index + 1; check < size; check++)
                {
                    if (numbers[index] != numbers[check])
                        flag = numbers[index];
                }
                if (flag != 0)
                {
                    uniqueArray[count] = flag;
                    count++;
                }

            }

            string message = "";

            for (int index = 0; index < size; index++)
            {
                if (uniqueArray[index] != 0)
                    message = message + "Value of Index [" + index + "] is " + uniqueArray[index].ToString() + "\n";
            }

            ResultRichTextBox.Text = message;
        }
    }
}
