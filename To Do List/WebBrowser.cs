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
    public partial class WebBrowser : Form
    {
     
        public WebBrowser(string address)
        {
            InitializeComponent();
            this.Address = address;
        }

        // set property
        public string Address { get; set; }
                
        private void WebBrowser_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Address;
            webBrowser1.Navigate("http://www.google.com/");// display url
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call back button to go back

            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            //Call forward button to move forward
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Call refresh button to refresh web browser
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //display address
            webBrowser1.Navigate(txtAddress.Text);
            btnGo.Focus(); // made go button as focus button

        }

        internal static void Navigate()
            
        {
             throw new NotImplementedException();
        }

     }

 }
        
   

