using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Perpustakaan.DatabaseClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Perpustakaan
{
    internal class DatabaseClass
    {
        public static SqlConnection DB;
        public static SqlCommand KodeBuku, NamaBuku, DekripsiBuku, SypnosisBuku, GambarBuku, BukuData, BookGenre, BookAuthor;
        public static SqlCommand RegisterId, Username, Email, Password, Datetime;
        public class Book
        {
            public string BookId { get; set; }
            public string BookTitle { get; set; }
            public string BookDescription { get; set; }
            public string BookPublisher { get; set; }
            public string BookImageCover { get; set; }
            public string BookGenre { get; set; }
            public string BookAuthor { get; set; }
        }

        public class Register
        {
            public string RegisterId { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Datetime { get; set; }
        }


        public static void BukaDB(string databaseAccess)
        {
            DB = new SqlConnection($"Data Source=(local); Initial Catalog=Database_Library; User ID=sa; Password=123456");
            DB.Open();

            if (databaseAccess == "book")
            {
                KodeBuku = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY book_id", DB);
                NamaBuku = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY book_title", DB);
                DekripsiBuku = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY book_description", DB);
                SypnosisBuku = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY book_publisher", DB);
                GambarBuku = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY book_image_cover", DB);
                BookGenre = new SqlCommand("SELECT * FROM" + databaseAccess + " ORDER BY book_genre", DB);
                BookAuthor = new SqlCommand("SELECT * FROM" + databaseAccess + " ORDER BY book_writer", DB);
            }
            else if (databaseAccess == "users")
            {
                RegisterId = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY user_id", DB);
                Username = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY username", DB);
                Email = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY email", DB);
                Password = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY password", DB);
                Datetime = new SqlCommand("SELECT * FROM " + databaseAccess + " ORDER BY created_at", DB);
            }
        }

        public static void TutupDB(string databaseAccess)
        {
            if (databaseAccess == "book")
            {
                KodeBuku.Dispose();
                NamaBuku.Dispose();
                DekripsiBuku.Dispose();
                SypnosisBuku.Dispose();
                GambarBuku.Dispose();
                BookGenre.Dispose();
            }
            else if (databaseAccess == "users")
            {
                RegisterId.Dispose();
                Username.Dispose();
                Email.Dispose();
                Password.Dispose();
                Datetime.Dispose();
            }
            DB.Close();
            DB.Dispose();

        }
        //public static List<Register> BacaDataLogin(string sqlCmd)
        //{
        //    List<Register> registers = new List<Register>();

        //    try
        //    {
        //        SqlCommand paginatedQuery = new SqlCommand(sqlCmd, DB);

        //        using (SqlDataReader reader = paginatedQuery.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Register register = new Register
        //                {
        //                    RegisterId = reader.GetString(reader.GetOrdinal("user_id")),
        //                    Username = reader.GetString(reader.GetOrdinal("username")),
        //                    Email = reader.GetString(reader.GetOrdinal("email")),
        //                    Password = reader.GetString(reader.GetOrdinal("password")),
        //                    Datetime = reader.GetString(reader.GetOrdinal("created_at")),
        //                };

        //                registers.Add(register);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error reading data: {ex.Message}");
        //    }

        //    return registers;
        //}

        public static bool CheckLoginCredentials(string email, string password, string sqlCmd)
        {
            try
            {
                SqlCommand command = new SqlCommand(sqlCmd, DB);
                command.Parameters.AddWithValue("@email", email);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader.GetString(reader.GetOrdinal("password"));
                        return storedPassword == password;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during login: {ex.Message}");
            }
            return false;
        }


        public static List<Book> BacaDataBuku(string sqlCmd)
        {
            List<Book> books = new List<Book>();

            try
            {
                SqlCommand paginatedQuery = new SqlCommand(sqlCmd, DB);

                using (SqlDataReader reader = paginatedQuery.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            BookId = reader.GetString(reader.GetOrdinal("book_id")),
                            BookTitle = reader.GetString(reader.GetOrdinal("book_title")),
                            BookDescription = reader.GetString(reader.GetOrdinal("book_description")),
                            BookPublisher = reader.GetString(reader.GetOrdinal("book_publisher")),
                            BookImageCover = reader.GetString(reader.GetOrdinal("book_image_cover")),
                            BookGenre = reader.GetString(reader.GetOrdinal("book_genre"))
                        };

                        books.Add(book);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading data: {ex.Message}");
            }

            return books;
        }

        public static int GetTotalBooks(string datatype, string databaseAccess, string keyword = null)
        {
            int totalBooks = 0;

            try
            {
                DatabaseClass.BukaDB(databaseAccess);

                string query = "SELECT COUNT(*) FROM " + databaseAccess;
                SqlCommand totalBooksCommand = new SqlCommand(query, DB);

                if (!string.IsNullOrEmpty(keyword))
                {
                    query += $" WHERE CAST({datatype} AS VARCHAR(MAX)) = @keyword";
                    totalBooksCommand.CommandText = query;
                    totalBooksCommand.Parameters.AddWithValue("@keyword", keyword);
                }

                totalBooks = (int)totalBooksCommand.ExecuteScalar();
                DatabaseClass.TutupDB(databaseAccess);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error counting books: {ex.Message}");
            }

            return totalBooks;
        }

        public static bool IsUserExists(string variable, string variableKey, string sqlCmd)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(sqlCmd, DB))
                {
                    command.Parameters.AddWithValue(variableKey, variable);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void RegisterUser(string username, string email, string password)
        {
            try
            {
                string commandText = "INSERT INTO users (username, email, password, created_at) VALUES ('"
                    + username + "', '"
                    + email + "', '"
                    + password + "', '"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";

                using (SqlCommand command = new SqlCommand(commandText, DB))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error registering user: {ex.Message}");
            }
        }
    }
}
