//  Title: Program 2 - Checkout Form
//  Class: CIS 200-01
//    Due: 3/12/2012
//   Name: Jeremy Brown
//Purpose: The purpose of this form is to allow the user to select what
//         items they want to checkout, and select what user is checking them out.

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
    public partial class CheckoutForm : Form
    {

        // Precondition:  None
        // Postcondition: The CheckoutForm GUI is initialized
        public CheckoutForm(List<LibraryItem>itemsList,List<LibraryPatron>patronsList)
        {

            InitializeComponent();


            //Displays every item that has been checked out in the itemsAvaCbo comboBox
            foreach (var item in itemsList)
           {

               itemsAvaCbo.Items.Add(string.Format("{0},{1}{2}", item.Title, item.CallNumber, System.Environment.NewLine));
           }
            ///Displays every patron that has been been registered with the library in the patronBoxCbo comboBox
           foreach (var patron in patronsList)
           {
               patronBoxCbo.Items.Add(string.Format("{0},{1}{2}", patron.PatronName, patron.PatronID, System.Environment.NewLine));
           }

        }
        public int ItemsValue
        {
            // Precondition:  None
            // Postcondition: Item in itemsAvaCbo is returned
            get { return itemsAvaCbo.SelectedIndex; }
        }
        public int PatronsValue
        {
            // Precondition:  None
            // Postcondition: Item in patronBoxCbo  is returned
            get { return patronBoxCbo.SelectedIndex; }
        }
        // Precondition:  Attempting to change focus from returnItemCbo_Validating
        // Postcondition: If itemsAvaCbo.selectedIndex >= 0, focus will change,
        //                 else error message will be set         
        private void itemsAvaCbo_Validating(object sender, CancelEventArgs e)
        {
            if(itemsAvaCbo.SelectedIndex < 0)
                 e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            CheckOutError.SetError(itemsAvaCbo, "Must select an item!"); // Set error message

            itemsAvaCbo.SelectAll();
        }
        // Precondition:  itemsAvaCbo_Validating Succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus and continue on their way
        private void itemsAvaCbo_Validated(object sender, EventArgs e)
        {
            CheckOutError.SetError(itemsAvaCbo, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from returnItemCbo_Validating
        // Postcondition: If patronBoxCbo.selectedIndex >= 0, focus will change,
        //                 else error message will be set    
        private void patronBoxCbo_Validating(object sender, CancelEventArgs e)
        {
            if (patronBoxCbo.SelectedIndex < 0)
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            CheckOutError.SetError(patronBoxCbo, "Must select an patron!"); // Set error message

            patronBoxCbo.SelectAll();
        }
        // Precondition:  itemsAvaCbo_Validating Succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus and continue on their way
        private void patronBoxCbo_Validated(object sender, EventArgs e)
        {
            CheckOutError.SetError(patronBoxCbo, ""); // Clears error message
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: CheckoutForm is eneded with with OK result
        private void checkOutOkBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
            }
            else { this.DialogResult = DialogResult.None; }
        }
        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, CheckoutForm is eneded with with Cancel result
        private void checkoutCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}