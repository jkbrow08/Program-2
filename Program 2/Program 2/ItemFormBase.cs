//  Title: Program 2 - Base Form
//  Class: CIS 200-01
//    Due: 3/12/2012
//   Name: Jeremy Brown
//Purpose: The purpose of this form is to provide an output for the checkout item list, item list, and patron list.
//         As well as a menu with a set of option the user can select from.

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
    public partial class ItemFormBase : Form
    {
        //Creation of library instance variable the will hold the testdata
        private Library newLibrary;
        
                
        public ItemFormBase()
        {
            InitializeComponent();
            
            //instatiate the test library
            newLibrary = new Library();

            //Test data for the library
            newLibrary.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright");
            newLibrary.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            newLibrary.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            newLibrary.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2011, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            newLibrary.AddLibraryMusic("C# - The Album", "UofL Music", 2011, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            newLibrary.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            newLibrary.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2011, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            newLibrary.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2007, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9A", 16, 7);
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9B", 16, 8);
            newLibrary.AddLibraryMagazine("C# Monthly", "UofL Mags", 2010, 14,
                "MA53 9C", 16, 9);
            newLibrary.AddLibraryMagazine("VB Magazine", "UofL Mags", 2011, 14,
                "MA21 5V", 1, 1);
            newLibrary.AddPatron("Ima Reader", "12345");
            newLibrary.AddPatron("Jane Doe", "11223");
            newLibrary.AddPatron("John Smith", "54321");
            newLibrary.AddPatron("James T. Kirk", "98765");
            newLibrary.AddPatron("Jean-Luc Picard", "33456");

       
            
        }
        // Precondition:  None
        // Postcondition: Brings up about menu stating the vital information about the program, and it's creator.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program 2 - Extra Credit\nBy: Jeremy Brown\nCIS 200-01" +
                "\nSpring 2012","About Program 2");
        }
        // Precondition:  None
        // Postcondition: Program will close.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  None
        // Postcondition: Adds new patron to the list of patron's in the library's linq list.
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creates the patron subform and opens it.
          PatronForm patronForm = new PatronForm();
          DialogResult result;//Holds the dialog result
          string name;//holds the name of the new patron name
          string id;//holds the name of the new patron's id
          result = patronForm.ShowDialog();

          if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {
                name = patronForm.NameValue;
                id = patronForm.IDValue;
                newLibrary.AddPatron(name, id);
                
            }

        }
        // Precondition:  None
        // Postcondition: Adds new book to the list of book's in the library's linq list.
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates the book subform and opens it.
            BookForm bookForm = new BookForm();
            DialogResult result;//Holds the dialog result
            string title;//holds the title of the book
            string publisher;//holds the publisher of the book
            int copyRightYear;//holds the copyRightYear of the book
            int loanPeriod;//holds the loanPeriod of the book
            string callNum;//holds the callNum of the book
            string author;//holds the author of the book

            result = bookForm.ShowDialog();

            if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {
                title = bookForm.TitleValue;
                publisher = bookForm.PublisherValue;
                copyRightYear = int.Parse(bookForm.CopyRightYearValue);
                loanPeriod = int.Parse(bookForm.LoanPeriodValue);
                callNum = bookForm.CallNumerValue;
                author = bookForm.AuthorValue;

                newLibrary.AddLibraryBook(title, publisher, copyRightYear, loanPeriod, callNum, author);

            }
        }
        // Precondition:  None
        // Postcondition: Displays the list of patrons in the library.
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplayTxt.Clear();

            //Displays every patron registerd for the library
            foreach (var patron in newLibrary.patrons)
            {

                mainDisplayTxt.Text += string.Format("{0}{1}{1}", patron, System.Environment.NewLine);

            }
        }
        // Precondition:  None
        // Postcondition: Displays the list of items in the library.
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplayTxt.Clear();

            mainDisplayTxt.Text += string.Format("The amount of items in the list is: {0}{1}", newLibrary.GetItemCount(), System.Environment.NewLine);

            //Displays every item that the library owns
            foreach (var item in newLibrary.items)
            {

                mainDisplayTxt.Text += string.Format("{1}{0}{1}", item , System.Environment.NewLine);
                
            }
        }
        // Precondition:  None
        // Postcondition: Displays the list of items that have been checkedout from the library.
        private void checkedOutItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainDisplayTxt.Clear();

            //Finds and displays the items that have been checked out.
            var checkedOutItems =
            from item in newLibrary.items
            where item.IsCheckedOut()
            select item;
            

            mainDisplayTxt.Text += string.Format("The amount of items in the list is: {0}{1}", checkedOutItems.Count(), System.Environment.NewLine);

            //Displays every item that has been checked out
            foreach (var item in checkedOutItems)
            {
                mainDisplayTxt.Text += string.Format("{1}{0}{1}", item, System.Environment.NewLine);
            }
           
        }
        // Precondition:  None
        // Postcondition: Check's out the items that the user selects from the subform Checkout.
        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sends the items, and patrons list to the checkout subform
            CheckoutForm checkoutForm = new CheckoutForm(newLibrary.items, newLibrary.patrons);
            DialogResult result;//holds the dialog result
            int item;//holds the item index
            int patron;//holds the patron index
             

            result = checkoutForm.ShowDialog();

            if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {
                item = checkoutForm.ItemsValue;
                patron = checkoutForm.PatronsValue;
                newLibrary.CheckOut(item, patron);
                
            }
        }
        // Precondition:  None
        // Postcondition: Return's the items that the user selects to return from the subform Returnform.
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //sends the items list to the return subform
            ReturnForm returnForm = new ReturnForm(newLibrary.items);
            DialogResult result;//holds the dialog result
            int item;//holds the item index

            result = returnForm.ShowDialog();

            if (result == DialogResult.OK)// Only update if user chose OK from dialog box
            {

                item = returnForm.ItemsValue;
                newLibrary.ReturnToShelf(item);

            }
        }
    }
}
