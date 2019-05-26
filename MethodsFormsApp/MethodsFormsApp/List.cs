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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();
        List<string> names = new List<string>();

        private void AddButton_Click(object sender, EventArgs e)
        {

            numbers.Add(Convert.ToInt32(InpuitTextBox.Text));
            names.Add(NameTextBox.Text);
            

            string message = "Foreach\n";

            int index = 0;

            foreach(int number in numbers)
            {
                message = message + names[index] + " " + number + "\n";
                index++;
            }

            showRichTextBox.Text = message;
        }

        
    }
}
