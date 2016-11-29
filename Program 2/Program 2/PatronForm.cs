//  Title: Program 2 - Patron Form
//  Class: CIS 200-01
//    Due: 3/12/2012
//   Name: Jeremy Brown
//Purpose: The purpose of this form is to allow the user to select a new
//         patron that they want to add to the library.


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

    public partial class PatronForm : Form
    {
        // Precondition:  None
        // Postcondition: The PatronForm GUI is initialized
        public PatronForm()
        {
            InitializeComponent();
            
        }
        public string NameValue
        {
            // Precondition:  None
            // Postcondition: Text in nameTxt is returned
            get { return nameTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in nameTxt is set to specified value
            set { nameTxt.Text = value; }
        }
        public string IDValue
        {
            // Precondition:  None
            // Postcondition: Text in idTxt is returned
            get { return idTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in idTxt is set to specified value
            set { idTxt.Text = value; }
        }


        // Precondition:  Attempting to change focus from nameTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set
        private void nameTxt_Validating(object sender, CancelEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            errorProvider1.SetError(nameTxt, "Must enter a Name!"); // Set error message

            nameTxt.SelectAll(); // Select all text in inputTxt to ease correction
          
        
        }
        // Precondition:  nameTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void nameTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(nameTxt, ""); // Clears error message
        }

        // Precondition:  Attempting to change focus from idTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set

        private void idTxt_Validating(object sender, CancelEventArgs e)
        {

             int number; // Value entered into inputTxt

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(idTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                // Will NOT proceed to Validated event

                errorProvider1.SetError(idTxt, "Enter an integer!"); // Set error message

                idTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            
        }
        // Precondition:  idTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void idTxt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(idTxt, ""); // Clears error message
        }


        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, PatronForm is eneded with with Cancel result
        private void patronCancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: PatronForm is eneded with with OK result
        private void patronOkBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
            
        }
        
    }
}
