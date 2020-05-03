using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    class ToDo
    {
        
        public ToDo(string text, bool urgent, string category, string comboBox) 
        {
            Text = text; // set the Text property
            Urgent = urgent; // set the Urgent property
            Category = category;// set the Category property
            ComboBox = comboBox; // set the Combox property
            DueDate = DateTime.Now.AddDays(10);//statement for Due date
        }
        // A Property, backed by the text field 
        public string Text { get; set; }

        // Another auto property, C# creates an urgent field
        public bool Urgent { get; set; }

        // A property, backed by the category field
        public string Category { get; set; }

        //Auto property with an initial value
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string ComboBox { get; set; }

        public DateTime DueDate { get; set; } 

        //A method that can be called for any ToDo object

        public override string ToString()
        {
            string displayText = $"{Text} category {Category} - Created on {DateCreated:f} - Due on  {DueDate:f}";
            if (Urgent) 
            {
                displayText +=  "URGENT!" ;
            }
            
            return displayText;
        }
    }
}

