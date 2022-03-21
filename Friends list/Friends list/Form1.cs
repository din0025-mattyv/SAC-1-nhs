using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friends_list
{
    public partial class frmOne : Form
    {
        List<String> myFriendsList = new List<String>();
        BindingSource bindSource = new BindingSource();
        public frmOne()
        {
            InitializeComponent();
            bindSource.DataSource = myFriendsList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myFriendsList.Add(txtInputNames.Text);
            lstbxDisplayNames.DataSource = bindSource;
            bindSource.ResetBindings(false);
            lblNumberInList.Text = "This list has " + myFriendsList.Count + " names in it.";
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            myFriendsList.Add("Vale");
            myFriendsList.Add("Max");
            myFriendsList.Add("Kiara");
            myFriendsList.Add("Hawk");
            myFriendsList.Add("Lexi");
            lstbxDisplayNames.DataSource = bindSource;
            bindSource.ResetBindings(false);
            lblNumberInList.Text = "This list has " + myFriendsList.Count + " names in it.";
        }

        private void btnSortZA_Click(object sender, EventArgs e)
        {
            myFriendsList.Sort();
            myFriendsList.Reverse();
            bindSource.ResetBindings(false);
        }

        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            myFriendsList.Sort();
            bindSource.ResetBindings(false);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            myFriendsList.Clear();
            txtInputNames.Clear();
            lblNumberInList.Text = "---";
            bindSource.ResetBindings(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (myFriendsList.Contains(txtInputNames.Text));
            {
                myFriendsList.Remove(txtInputNames.Text);
                bindSource.ResetBindings(false);
                lblNumberInList.Text = "Name removed.";
            };
           
            

        }

        private void lstbxDisplayNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxDisplayNames.SelectedItem != null)
            {
                string modifynames = lstbxDisplayNames.SelectedItem.ToString();
                txtInputNames.Text = modifynames;
                myFriendsList.Remove(modifynames);
            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            myFriendsList.Add(txtInputNames.Text);
            lstbxDisplayNames.DataSource = bindSource;
            bindSource.ResetBindings(false);     
            
        }
    }
}
