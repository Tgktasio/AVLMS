using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AVLMS
{
    internal class Books
    {
        private string connectionString = "server=localhost;user=root;database=AlvinLMSdb;port=3306;password=YOUR_PASSWORD;";

        public void AddBook(string title, string author, string isbn, bool isAvailable)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO Books (Title, Author, ISBN, IsAvailable) VALUES (@Title, @Author, @ISBN, @IsAvailable)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Book added successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding book: " + ex.Message);
            }
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM Books WHERE BookId = @BookId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookId", bookId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Book deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting book: " + ex.Message);
            }
        }

        public void EditBook(int bookId, string title, string author, string isbn, bool isAvailable)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE Books SET Title = @Title, Author = @Author, ISBN = @ISBN, IsAvailable = @IsAvailable WHERE BookId = @BookId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookId", bookId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Book updated successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating book: " + ex.Message);
            }
        }

        public List<Book> ViewBooks()
        {
            List<Book> books = new List<Book>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Books";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Book book = new Book
                            {
                                BookId = reader.GetInt32("BookId"),
                                Title = reader.GetString("Title"),
                                Author = reader.GetString("Author"),
                                ISBN = reader.GetString("ISBN"),
                                IsAvailable = reader.GetBoolean("IsAvailable")
                            };
                            books.Add(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving books: " + ex.Message);
            }
            return books;
        }

        public void Back()
        {
            Console.WriteLine("Navigating back to the previous menu...");
        }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
    }
}
