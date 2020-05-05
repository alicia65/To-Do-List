using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{

    public partial class frmToDo : Form
    {
        public object chkdateCreated;
        public frmToDo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cboToDoCategory.Items.Add("Work");
            cboToDoCategory.Items.Add("School");
            cboToDoCategory.Items.Add("Personal");
            cboToDoCategory.Items.Add("Just for Fun");
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string todoText = txtToDoItem.Text;
            bool urgent = chkUrgent.Checked;
            string category = cboToDoCategory.Text;

            string comboBox = lblToDo.Text;

            if (!String.IsNullOrWhiteSpace(todoText))
            {
                //Create new ToDo object using a constructor
                ToDo toDoItem = new ToDo(todoText, urgent, category, comboBox);

                if (!ToDoItemInList(toDoItem))
                {
                    clsToDoCategory.Items.Add(toDoItem);
                    txtToDoItem.Text = " "; //Clear text
                    txtToDoItem.Focus();// focus on this button
                }
                else
                {
                    MessageBox.Show("You already added that", "Duplicate");
                }
            }
        }

        private bool ToDoItemInList(ToDo toDoItem)
        {
            foreach (ToDo listItem in clsToDoCategory.Items)
            {
                if (toDoItem.Text.ToUpper() == listItem.Text.ToUpper())
                {
                    return true;//This list item has the same text as toDoItem

                }
            }
            //If the end of the loop is reached without returning
            // an item with the same text is not in the list. Return false 
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make new list
            List<ToDo> doneItems = new List<ToDo>();

            //Copy all checked items to new List
            foreach (ToDo item in clsToDoCategory.CheckedItems)
            {
                doneItems.Add(item);
            }

            // For each string in doneItems list, remove from clsToDo.Items
            // Add to lstDone.Items
            foreach (ToDo item in doneItems)
            {
                clsToDoCategory.Items.Remove(item); // Remove by value
                lstDone.Items.Add(item);
            }

            //Search list done for for done items
            foreach (ToDo item in doneItems) 
            {
                lstDone.Items.Contains(item);//check list done for item
            }
            

        }

        private void ChkUrgent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchInternet_Click(object sender, EventArgs e)
        {
            //passing data from To Do form to web browser form
            WebBrowser browser = new WebBrowser(txtToDoItem.Text);
            browser.ShowDialog();
        }
    }
}    

