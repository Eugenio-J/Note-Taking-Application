using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApplication
{
    internal class NoteDAO
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=NotesDB;Integrated Security=True";
        public List<Notes> albums = new List<Notes>();

        public List<Notes> getAllNotes()
        {
            // start with an empty list
            List<Notes> returnThese = new List<Notes>();

            // connect to the mysql server
            SqlConnection connection = new SqlConnection(connectionString);
            //open the connection
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Notes", connection);

            //execute the command 
            //the reader can use in a loop to fetch each line
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Notes a = new Notes
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                       
                    };
                    returnThese.Add(a);
                }
            }
            //close the connection
            connection.Close();


            return returnThese;
        }

        public List<Notes> search(string searchTerm)
        {
            // start with an empty list
            List<Notes> returnThese = new List<Notes>();

            // connect to the mysql server
            SqlConnection connection = new SqlConnection(connectionString);
            //open the connection
            connection.Open();

            String searchWildPhrase = "%" + searchTerm + "%";

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM NOTES WHERE TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            //execute the command 
            //the reader can use in a loop to fetch each line
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Notes a = new Notes
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                       
                    };
                    returnThese.Add(a);
                }
            }
            //close the connection
            connection.Close();


            return returnThese;
        }

        internal int addOneNote(Notes notes)
        {

            // connect to the mysql server
            SqlConnection connection = new SqlConnection(connectionString);
            //open the connection
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO NOTES (TITLE, DESCRIPTION) VALUES (@title, @description)", connection);

            command.Parameters.AddWithValue("@title", notes.Title);
            command.Parameters.AddWithValue("@description", notes.Description);
 

            int newRows = command.ExecuteNonQuery();

            //close the connection
            connection.Close();

            return newRows;

        }

        internal int deleteNote(int noteID)
        {
            // connect to the mysql server
            SqlConnection connection = new SqlConnection(connectionString);
            //open the connection
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM NOTES WHERE NOTES.ID = @noteID", connection);

            command.Parameters.AddWithValue("@noteID", noteID);


            int result = command.ExecuteNonQuery();

            //close the connection
            connection.Close();

            return result;

        }
    }
}
