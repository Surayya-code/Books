using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAppendBook_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Name = textBoxName.Text;
            book.Author = textBoxAuthor.Text;
            book.Janr = textBoxJanr.Text;
            book.Lang = textBoxLangue.Text;
            book.Year = textBoxYear.Text;
            book.Size = textBoxSize.Text;
            book.Rating = checkBoxRating.Checked;

            listBoxBookList.Items.Add(book);

        }
        string fileName = "Books.dat";
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Books> books = new List<Books>();

            foreach (Books item in listBoxBookList.Items)
            {
                books.Add(item);
            }


            using (Stream stream = File.OpenWrite(fileName))
            {
               
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, books);
                

            }
            

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (Stream stream = File.OpenRead(fileName))
            {

                BinaryFormatter formatter = new BinaryFormatter();

                List<Books> books = (List<Books>)formatter.Deserialize(stream);

                listBoxBookList.Items.AddRange(books.ToArray());

            }
        }

        private void listBoxBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxBookList.SelectedIndex;
            object obyekt = listBoxBookList.Items[index];
            Books book = (Books)obyekt;

           textBoxName.Text=book.Name;
           textBoxAuthor.Text = book.Author; 
           textBoxJanr.Text = book.Janr; 
           textBoxLangue.Text = book.Lang; 
           textBoxYear.Text = book.Year; 
           textBoxSize.Text = book.Size; 
           checkBoxRating.Checked = book.Rating; 
        }
    }
}