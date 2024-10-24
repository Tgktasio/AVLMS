using System;
using System.Windows.Forms;

namespace AVLMS
{
    public partial class ManageBooks : Form
    {
        ManageBook manageBook = new ManageBook();

        public ManageBooks()
        {
            InitializeComponent();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgvBooks.Rows.Clear();
            var books = manageBook.ViewBooks();
            foreach (var book in books)
            {
               // dgvBooks.Rows.Add(book.BookId, book.Title, book.Author, book.ISBN, book.IsAvailable ? "Available" : "Borrowed");
            }
        }

        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                manageBook.AddBook(txtTitle.Text, txtAuthor.Text, txtISBN.Text);
                MessageBox.Show("Book added successfully!");
                LoadBooks();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
                manageBook.EditBook(bookId, txtTitle.Text, txtAuthor.Text, txtISBN.Text);
                MessageBox.Show("Book updated successfully!");
                LoadBooks();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
                manageBook.DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!");
                LoadBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvBooks.Rows[e.RowIndex];
                txtTitle.Text = row.Cells[1].Value.ToString();
                txtAuthor.Text = row.Cells[2].Value.ToString();
                txtISBN.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
