//  Title: Program 2 - Return Form
//  Class: CIS 200-01
//    Due: 3/12/2012
//   Name: Jeremy Brown
//Purpose: The purpose of this form is to allow the user to select what
//         items they want to reutrn.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class ReturnForm : Form
    {
        // Precondition:  None
        // Postcondition: The CheckoutForm GUI is initialized
        public ReturnForm(List<LibraryItem> itemsList)
        {
            InitializeComponent();

            //Finds and displays the items that have been checked out.
            var checkedOutItems =
            from item in itemsList
            where item.IsCheckedOut()
            select item;

            //Displays every item that has been checked out in the returnItemCbo comboBox
            foreach (var item in checkedOutItems)
            {
                returnItemCbo.Items.Add(string.Format("{0},{1}{2}", item.Title, item.CallNumber, System.Environment.NewLine));
            }
        }
        public int ItemsValue
        {
            // Precondition:  None
            // Postcondition: Item in returnItemCbo is returned
            get { return returnItemCbo.SelectedIndex; }

        }
        // Precondition:  Attempting to change focus from returnItemCbo_Validating
        // Postcondition: If returnItemCbo.selectedIndex >= 0, focus will change,
        //                 else error message will be set        
        private void returnItemCbo_Validating(object sender, CancelEventArgs e)
        {
            if (returnItemCbo.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            errorProvider1.SetError(returnItemCbo, "Must select an item!"); // Set error message

            returnItemCbo.SelectAll();
        }
        // Precondition:  returnItemCbo_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void returnItemCbo_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(returnItemCbo, ""); // Clears error message
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: ReturnForm is eneded with with OK result
        private void returnOkBtn_Click(object sender, EventArgs e)
        {
            
            if(this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, ReturnForm is eneded with with Cancel result
        private void returnCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        
    }
}
