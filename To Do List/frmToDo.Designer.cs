namespace To_Do_List
{
    partial class frmToDo
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
            this.lblToDo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.clsToDoCategory = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.lblDeletedItems = new System.Windows.Forms.Label();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.cboToDoCategory = new System.Windows.Forms.ComboBox();
            this.txtToDoItem = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSearchInternet = new System.Windows.Forms.Button();
            this.btnSearchDoneItems = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDoneItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblToDo
            // 
            this.lblToDo.Location = new System.Drawing.Point(-1, 34);
            this.lblToDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(297, 32);
            this.lblToDo.TabIndex = 0;
            this.lblToDo.Text = "What do you need to do?";
            this.lblToDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Things to do";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(763, 80);
            this.btnAddToDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(91, 32);
            this.btnAddToDo.TabIndex = 3;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // clsToDoCategory
            // 
            this.clsToDoCategory.FormattingEnabled = true;
            this.clsToDoCategory.Location = new System.Drawing.Point(38, 147);
            this.clsToDoCategory.Margin = new System.Windows.Forms.Padding(4);
            this.clsToDoCategory.Name = "clsToDoCategory";
            this.clsToDoCategory.Size = new System.Drawing.Size(1023, 165);
            this.clsToDoCategory.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(38, 324);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove checked items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 22;
            this.lstDone.Location = new System.Drawing.Point(38, 407);
            this.lstDone.Margin = new System.Windows.Forms.Padding(4);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(1023, 136);
            this.lstDone.TabIndex = 7;
            // 
            // lblDeletedItems
            // 
            this.lblDeletedItems.Location = new System.Drawing.Point(34, 380);
            this.lblDeletedItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeletedItems.Name = "lblDeletedItems";
            this.lblDeletedItems.Size = new System.Drawing.Size(138, 32);
            this.lblDeletedItems.TabIndex = 8;
            this.lblDeletedItems.Text = "Deleted Items";
            this.lblDeletedItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkUrgent
            // 
            this.chkUrgent.Location = new System.Drawing.Point(644, 78);
            this.chkUrgent.Margin = new System.Windows.Forms.Padding(4);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(111, 33);
            this.chkUrgent.TabIndex = 2;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            this.chkUrgent.CheckedChanged += new System.EventHandler(this.ChkUrgent_CheckedChanged);
            // 
            // cboToDoCategory
            // 
            this.cboToDoCategory.FormattingEnabled = true;
            this.cboToDoCategory.Location = new System.Drawing.Point(333, 78);
            this.cboToDoCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cboToDoCategory.Name = "cboToDoCategory";
            this.cboToDoCategory.Size = new System.Drawing.Size(284, 30);
            this.cboToDoCategory.TabIndex = 1;
            // 
            // txtToDoItem
            // 
            this.txtToDoItem.Location = new System.Drawing.Point(38, 78);
            this.txtToDoItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtToDoItem.Name = "txtToDoItem";
            this.txtToDoItem.Size = new System.Drawing.Size(256, 28);
            this.txtToDoItem.TabIndex = 0;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(437, 34);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(138, 32);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // btnSearchInternet
            // 
            this.btnSearchInternet.Location = new System.Drawing.Point(890, 80);
            this.btnSearchInternet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInternet.Name = "btnSearchInternet";
            this.btnSearchInternet.Size = new System.Drawing.Size(194, 32);
            this.btnSearchInternet.TabIndex = 4;
            this.btnSearchInternet.Text = "Search Internet";
            this.btnSearchInternet.UseVisualStyleBackColor = true;
            this.btnSearchInternet.Click += new System.EventHandler(this.btnSearchInternet_Click);
            // 
            // btnSearchDoneItems
            // 
            this.btnSearchDoneItems.Location = new System.Drawing.Point(333, 551);
            this.btnSearchDoneItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDoneItems.Name = "btnSearchDoneItems";
            this.btnSearchDoneItems.Size = new System.Drawing.Size(214, 32);
            this.btnSearchDoneItems.TabIndex = 10;
            this.btnSearchDoneItems.Text = "Search done items";
            this.btnSearchDoneItems.UseVisualStyleBackColor = true;
            this.btnSearchDoneItems.Click += new System.EventHandler(this.btnSearchDoneItems_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(34, 587);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(138, 32);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // txtDoneItems
            // 
            this.txtDoneItems.Location = new System.Drawing.Point(38, 553);
            this.txtDoneItems.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoneItems.Name = "txtDoneItems";
            this.txtDoneItems.Size = new System.Drawing.Size(256, 28);
            this.txtDoneItems.TabIndex = 9;
            // 
            // frmToDo
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 624);
            this.Controls.Add(this.txtDoneItems);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearchDoneItems);
            this.Controls.Add(this.btnSearchInternet);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtToDoItem);
            this.Controls.Add(this.cboToDoCategory);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.lblDeletedItems);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.clsToDoCategory);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToDo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToDo";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.CheckedListBox clsToDoCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Label lblDeletedItems;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.ComboBox cboToDoCategory;
        private System.Windows.Forms.TextBox txtToDoItem;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSearchInternet;
        private System.Windows.Forms.Button btnSearchDoneItems;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDoneItems;
    }
}

