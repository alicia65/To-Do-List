﻿using System;
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
        public object chkdateCreated;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox comboBox = new ComboBox();// Create comboBox ojbect
            comboBox.Items.Add("Work");
            comboBox.Items.Add("School");
            comboBox.Items.Add("Personal");

        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string todoText = txtToDoItem.Text;
            bool urgent = chkUrgent.Checked;
            string category = txtToDoItem.Text;
            DateTime dateCreated = chkdateCreated.Checked;
            string comboBox = lblToDo.Text;
                        
            if (!String.IsNullOrWhiteSpace(todoText))
            {
                //Create new ToDo object using a constructor
                ToDo toDoItem = new ToDo(todoText, urgent, category, dateCreated, comboBox );

                if (!ToDoItemInList(toDoItem))
                {
                    clsToDo.Items.Add(toDoItem);
                   txtToDoItem.Text =   " "; //Clear text
                }
                else
                {
                    MessageBox.Show("You already added that", "Duplicate");
                }
            }
        }

        private bool ToDoItemInList(ToDo toDoItem)
        {
            foreach(ToDo listItem in clsToDo.Items) 
            {
                if(toDoItem.Text.ToUpper() == listItem.Text.ToUpper()) 
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
            foreach (ToDo item in clsToDo.CheckedItems) 
            {
                doneItems.Add(item);
            }

            // For each string in doneItems list, remove from clsToDo.Items
            // Add to lstDone.Items
            foreach(ToDo item in doneItems) 
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
