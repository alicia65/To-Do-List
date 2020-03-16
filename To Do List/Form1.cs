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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            //Remove any spaces start and end of string
            string newItem = txtNewToDo.Text.Trim();

            if (!String.IsNullOrWhiteSpace(newItem))
            {
                //Use Contains to check if item is already in Items collection
                if (clsToDo.Items.Contains(newItem))
                
                {
                    MessageBox.Show("You already added that item", "Error");
                }
                else
                {
                    //Use Add to add new item to end of Items collection
                    DateTime todoCreated = DateTime.Now;
                    bool urgent = chkUrgent.Checked;

                    //Format the text, date/time created and urgent into one string
                    string todoText = $"{newItem} - created at {todoCreated:f}";
                    if (urgent) 
                    {
                        todoText +=    "URGENT!";
                    }
                    
                    // add to the ListBox items
                    clsToDo.Items.Add(todoText);
                    
                    //Clear inputs
                    txtNewToDo.Text = "";
                    chkUrgent.Checked = false;
                }
            }   
            //No else, just ignore empty input.
        }

        private bool itemIsInList(CheckedListBox.ObjectCollection items, string newItem) 
        {
            foreach(string item in items) 
            {
                if(item.ToUpper()== newItem.ToUpper()) 
                {
                    return true;
                }
            }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Make new list
            List<string> doneItems = new List<string>();

            //Copy all checked items to new List
            foreach (string item in clsToDo.CheckedItems) 
            {
                doneItems.Add(item);
            }

            // For each string in doneItems list, remove from clsToDo.Items
            // Add to lstDone.Items
            foreach(string item in doneItems) 
            {
                clsToDo.Items.Remove(item); // Remove by value
                lstDone.Items.Add(item);
            }
        }

        private void ChkUrgent_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
