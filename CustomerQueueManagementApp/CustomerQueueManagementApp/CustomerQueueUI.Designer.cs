namespace CustomerQueueManagementApp
{
    partial class CustomerQueueUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.complainDeqTextBox = new System.Windows.Forms.TextBox();
            this.complainEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.serialNoDeqTextBox = new System.Windows.Forms.TextBox();
            this.nameDeqTextBox = new System.Windows.Forms.TextBox();
            this.waitingQListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enqueue Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dequeue Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Serial number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Complain";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Waiting Queue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enqueue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.enqueueButton);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(683, 33);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 8;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(140, 74);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEnqueueTextBox.TabIndex = 10;
            // 
            // complainDeqTextBox
            // 
            this.complainDeqTextBox.Location = new System.Drawing.Point(515, 145);
            this.complainDeqTextBox.Name = "complainDeqTextBox";
            this.complainDeqTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainDeqTextBox.TabIndex = 11;
            // 
            // complainEnqueueTextBox
            // 
            this.complainEnqueueTextBox.Location = new System.Drawing.Point(132, 116);
            this.complainEnqueueTextBox.Name = "complainEnqueueTextBox";
            this.complainEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainEnqueueTextBox.TabIndex = 12;
            // 
            // serialNoDeqTextBox
            // 
            this.serialNoDeqTextBox.Location = new System.Drawing.Point(515, 66);
            this.serialNoDeqTextBox.Name = "serialNoDeqTextBox";
            this.serialNoDeqTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialNoDeqTextBox.TabIndex = 13;
            // 
            // nameDeqTextBox
            // 
            this.nameDeqTextBox.Location = new System.Drawing.Point(515, 107);
            this.nameDeqTextBox.Name = "nameDeqTextBox";
            this.nameDeqTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDeqTextBox.TabIndex = 14;
            // 
            // waitingQListView
            // 
            this.waitingQListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.waitingQListView.GridLines = true;
            this.waitingQListView.Location = new System.Drawing.Point(42, 282);
            this.waitingQListView.Name = "waitingQListView";
            this.waitingQListView.Size = new System.Drawing.Size(716, 206);
            this.waitingQListView.TabIndex = 15;
            this.waitingQListView.UseCompatibleStateImageBehavior = false;
            this.waitingQListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            // 
            // CustomerQueueUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.waitingQListView);
            this.Controls.Add(this.nameDeqTextBox);
            this.Controls.Add(this.serialNoDeqTextBox);
            this.Controls.Add(this.complainEnqueueTextBox);
            this.Controls.Add(this.complainDeqTextBox);
            this.Controls.Add(this.nameEnqueueTextBox);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerQueueUI";
            this.Text = "Serial number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.TextBox complainDeqTextBox;
        private System.Windows.Forms.TextBox complainEnqueueTextBox;
        private System.Windows.Forms.TextBox serialNoDeqTextBox;
        private System.Windows.Forms.TextBox nameDeqTextBox;
        private System.Windows.Forms.ListView waitingQListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

