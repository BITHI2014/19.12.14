using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueUI : Form
    {
        public CustomerQueueUI()
        {
            InitializeComponent();
        }
        List<Customer> customerQueue=new List<Customer>();
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int count = 0;
        private void enqueueButton(object sender, EventArgs e)
        {
            Customer customer1=new Customer();
            customer1.name = nameEnqueueTextBox.Text;
            customer1.complain = complainEnqueueTextBox.Text;
            ListViewItem checkItem=new ListViewItem();
            string serial = "";
            if (waitingQListView.Items.Count > 0)
            {
                checkItem = waitingQListView.Items[waitingQListView.Items.Count - 1];
                serial = (int.Parse(checkItem.Text)+1).ToString();
            }
            else
            {
                serial = "1";
            }
            ListViewItem aItem=new ListViewItem();
            aItem.Text = serial;
            aItem.SubItems.Add(customer1.name);
            aItem.SubItems.Add(customer1.complain);
            waitingQListView.Items.Add(aItem);

            MessageBox.Show(customer1.name +" your serial number is:" +count);
            
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            ListViewItem item=new ListViewItem();
            item = waitingQListView.Items[0];
            serialNoDeqTextBox.Text = item.Text;
            nameDeqTextBox.Text = item.SubItems[1].Text;
            complainDeqTextBox.Text = item.SubItems[2].Text;
            waitingQListView.Items.Remove(item);

        }

        
        }
}
