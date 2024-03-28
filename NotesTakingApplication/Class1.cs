using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NotesTakingApplication
{
    public class Class1
    {
        public void LoadNotes(ListView list)
        {
            list.Items.Clear(); // Clear existing items

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC14\SQLEXPRESS; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string selectQuery = "SELECT NoteID, Title, Content, Timestamp FROM Notes ORDER BY Timestamp DESC"; // Assuming Timestamp is the column name for the timestamp
                SqlCommand command = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Title"].ToString());
                    item.SubItems.Add(reader["Timestamp"].ToString());
                    item.Tag = reader["NoteID"]; // Store NoteID in Tag for future reference (e.g., deleting a note)
                    list.Items.Add(item);
                }
            }
        }
    }
}