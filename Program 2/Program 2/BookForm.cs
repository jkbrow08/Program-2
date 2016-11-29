//  Title: Program 2 - Book Form
//  Class: CIS 200-01
//    Due: 3/12/2012
//   Name: Jeremy Brown
//Purpose: The purpose of this form is to allow the user to select a new
//         books that they want to add to the library.

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
    public partial class BookForm : Form
    {
        // Precondition:  None
        // Postcondition: The BookForm GUI is initialized
        public BookForm()
        {
            InitializeComponent();

        }
        
        
        public string AuthorValue
        {
            // Precondition:  None
            // Postcondition: Text in authorTxt is returned
            get { return authorTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in authorTxt is set to specified value
            set { authorTxt.Text = value; }
        }
        public string TitleValue
        {
            // Precondition:  None
            // Postcondition: Text in titleTxt is returned
            get { return titleTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in titleTxt is set to specified value
            set { titleTxt.Text = value; }
        }
        public string PublisherValue
        {
            // Precondition:  None
            // Postcondition: Text in publisherTxt is returned
            get { return publisherTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in publisherTxt is set to specified value
            set { publisherTxt.Text = value; }
        }
        public string CopyRightYearValue
        {
            // Precondition:  None
            // Postcondition: Text in copyrghyrTxt is returned
            get { return copyrghyrTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in copyrghyrTxt is set to specified value
            set { copyrghyrTxt.Text = value; }
        }
        public string LoanPeriodValue
        {
            // Precondition:  None
            // Postcondition: Text in loanPeTxt is returned
            get { return loanPeTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in loanPeTxt is set to specified value
            set { loanPeTxt.Text = value; }
        }
        public string CallNumerValue
        {
            // Precondition:  None
            // Postcondition: Text in callNumTxt is returned
            get { return callNumTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in callNumTxt is set to specified value
            set { callNumTxt.Text = value; }
        }
        // Precondition:  Attempting to change focus from titleTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                else error message will be set
        private void titleTxt_Validating(object sender, CancelEventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(titleTxt.Text))
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            bookError.SetError(titleTxt, "Must enter a Name!"); // Set error message

            titleTxt.SelectAll(); // Select all text in inputTxt to ease correction
          
        }
        // Precondition:  titleTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void titleTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(titleTxt, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from publisherTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //               else error message will be set
        private void publisherTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(publisherTxt.Text))
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            bookError.SetError(publisherTxt, "Must enter a Name!"); // Set error message

            publisherTxt.SelectAll(); // Select all text in inputTxt to ease correction
          
        }
        // Precondition:  publisherTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void publisherTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(publisherTxt, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from copyrghyrTxt_Validating
        // Postcondition: If entered value is valid int, focus will change,
        //                 else error message will be set
        private void copyrghyrTxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(copyrghyrTxt.Text, out num))
            {
                if (num > 0)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                    bookError.SetError(copyrghyrTxt, "Must enter a Valid Copyright Year!"); // Set error message

                    copyrghyrTxt.SelectAll(); // Select all text in inputTxt to ease correction 
                }
            }else
            {
                e.Cancel = true;

                bookError.SetError(copyrghyrTxt, "Must enter a Valid Copyright Year!"); // Set error message

                copyrghyrTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            

        }
        // Precondition:  copyrghyrTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void copyrghyrTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(copyrghyrTxt, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from loanPeTxt_Validating
        // Postcondition: If entered value is valid int, focus will change,
        //               else error message will be set
        private void loanPeTxt_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if (int.TryParse(loanPeTxt.Text, out num))
            {
                if (num > 0)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                    bookError.SetError(loanPeTxt, "Must enter a Valid Copyright Year!"); // Set error message

                    loanPeTxt.SelectAll(); // Select all text in inputTxt to ease correction 
                }
            }else
            {
                e.Cancel = true;

                bookError.SetError(loanPeTxt, "Must enter a Valid Copyright Year!"); // Set error message

                loanPeTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            
        }
        // Precondition:  loanPeTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void loanPeTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(loanPeTxt, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from callNumTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                else error message will be set
        private void callNumTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callNumTxt.Text))
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            bookError.SetError(callNumTxt, "Must enter a Name!"); // Set error message

            callNumTxt.SelectAll(); // Select all text in inputTxt to ease correction
          
        }
        // Precondition:  callNumTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void callNumTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(callNumTxt, ""); // Clears error message
        }
        // Precondition:  Attempting to change focus from authorTxt_Validating
        // Postcondition: If entered value is valid string, focus will change,
        //                 else error message will be set
        private void authorTxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorTxt.Text))
                e.Cancel = true; // Stops focus changing process
            // Will NOT proceed to Validated event

            bookError.SetError(authorTxt, "Must enter a Author!"); // Set error message

            authorTxt.SelectAll(); // Select all text in inputTxt to ease correction
          
        }
        // Precondition:  authorTxt_Validating succeeded
        // Postcondition: ErrorMessage has been cleared, and the user can shift focus can continue on their way
        private void authorTxt_Validated(object sender, EventArgs e)
        {
            bookError.SetError(authorTxt, ""); // Clears error message
        }


        // Precondition:  User has initiated click on cancelBtn
        // Postcondition: If left-click, BookForm is eneded with with Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        // Precondition:  User has clicked on Ok Button
        // Postcondition: BookForm is eneded with with OK result
        private void bookOkBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
            else { this.DialogResult = DialogResult.None; }
        }
    }
}
