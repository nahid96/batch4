using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWinApp
{
    public partial class CustomerForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string user;
            string name;
            int age;

            userLabel.Text = "";

            try
            {
                if(userTextBox.Text == "")
                {
                    userLabel.Text = "user can't be null";
                    return;
                }

                if(UserExists(userTextBox.Text) == true)
                {
                    userLabel.Text = "user already exist";
                    return;
                }

                if (string.IsNullOrEmpty(ageTextBox.Text))
                { 
                    if (!Int32.TryParse(ageTextBox.Text, out int result))
                    {
                        MessageBox.Show("Age must be a number");
                        return;
                    }

                MessageBox.Show("Age can't be empty");
                    return;
                }


                user = userTextBox.Text;
                name = nameTextBox.Text;
                age = Convert.ToInt32(ageTextBox.Text);

                users.Add(user);
                names.Add(name);
                ages.Add(age);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            ResultRichTextBox.Text = Display();
        }

        private string Display()
        {
            string message = "ID\tUser\tName\tAge\n";

            for(int index=0; index<ages.Count; index++)
            {
                message = message + (index + 1) + "\t" + users[index] + "\t" + names[index] + "\t" + ages[index] + "\n";
            }

            return message;
        }

        private bool UserExists(string user)
        {
            bool isExist = false;

            foreach(string userCk in users)
            {
                if(userCk == user)
                {
                    isExist = true;
                }
            }

            return isExist;
        }


    }
}
