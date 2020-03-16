﻿namespace To_Do_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.lblDeletedItems = new System.Windows.Forms.Label();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you need to do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Things to do";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(28, 51);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(510, 22);
            this.txtNewToDo.TabIndex = 2;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(674, 51);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDo.TabIndex = 3;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(28, 124);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(731, 174);
            this.clsToDo.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 16;
            this.lstDone.Location = new System.Drawing.Point(28, 371);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(731, 68);
            this.lstDone.TabIndex = 7;
            // 
            // lblDeletedItems
            // 
            this.lblDeletedItems.Location = new System.Drawing.Point(25, 345);
            this.lblDeletedItems.Name = "lblDeletedItems";
            this.lblDeletedItems.Size = new System.Drawing.Size(100, 23);
            this.lblDeletedItems.TabIndex = 8;
            this.lblDeletedItems.Text = "Deleted Items";
            this.lblDeletedItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkUrgent
            // 
            this.chkUrgent.Location = new System.Drawing.Point(560, 53);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(104, 24);
            this.chkUrgent.TabIndex = 9;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            this.chkUrgent.CheckedChanged += new System.EventHandler(this.ChkUrgent_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.lblDeletedItems);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.clsToDo);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Label lblDeletedItems;
        private System.Windows.Forms.CheckBox chkUrgent;
    }
}
