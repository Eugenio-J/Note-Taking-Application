using NoteTakingApplication;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CRUD
{
    public partial class NoteTakingApplication : Form
    {
        BindingSource notesBindingSource = new BindingSource();
        //Declere instance of DataTable class for datagridView
        //DataTable notes = new DataTable();
        //bool editing = false;
        List<Notes> notes = new List<Notes>();  
        public NoteTakingApplication()
        {
            InitializeComponent();
        }

        //Load event of the app
        private void NoteTakingApplication_Load(object sender, EventArgs e)
        {
            //When clicking the button it will create a brand new list
            NoteDAO notesDAO = new NoteDAO();

            //connect the list to the grid view control
            notesBindingSource.DataSource = notesDAO.getAllNotes();

            notesDGV.DataSource = notesBindingSource;
            //notes.Columns.Add("Title"); // Add Title column in datagridview
            // notes.Columns.Add("Description"); // Add description column in datagridview

            //Establish a connection between the datagridview and Datatable
            //notesDGV.DataSource = notes;
        }

        //Create button click event
        private void insertButton_Click(object sender, EventArgs e)
        {
            // add a new item to the database

            Notes notes = new Notes
            {
                Title = title_txtBox.Text,
                Description = description_txtBox.Text,

            };

            NoteDAO noteDAO = new NoteDAO();
            int result = noteDAO.addOneNote(notes);
            MessageBox.Show(result + "new row(s) inserted");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ////Update the data if editing is true
            ////editing value will be true if the user click a cell
            //if (editing)
            //{
            //    notes.Rows[notesDGV.CurrentCell.RowIndex]["Title"] = title_txtBox.Text;
            //    notes.Rows[notesDGV.CurrentCell.RowIndex]["Description"] = description_txtBox.Text;
            //}
            ////Add the data if editing = false
            //else
            //{

            //    try
            //    {
            //        //check if the title or description textBox is empty
            //        if (string.IsNullOrEmpty(title_txtBox.Text) || string.IsNullOrEmpty(title_txtBox.Text))
            //        {
            //            throw new Exception("Please enter values for one of the fields.");
            //        }
            //        notes.Rows.Add(title_txtBox.Text, description_txtBox.Text);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message, "Data Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

            ////reset the value in textBox
            //title_txtBox.Text = "";
            //description_txtBox.Text = "";
            //editing = false;
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            int rowClicked = notesDGV.CurrentRow.Index;
            int trackID = (int)notesDGV.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track =  " + trackID);

            NoteDAO noteDAO = new NoteDAO();

            int result = noteDAO.deleteNote(trackID);

            MessageBox.Show("Result " + result);

            notesDGV.DataSource = null;
            notes = noteDAO.getAllNotes();

        }

        //Display the selected row data in textBox
        private void readButton_Click(object sender, EventArgs e)
        {
            //When clicking the button it will create a brand new list
            NoteDAO noteDAO = new NoteDAO();

            //connect the list to the grid view control
            notes = noteDAO.getAllNotes();

            notesBindingSource.DataSource = notes;

            notesDGV.DataSource = notesBindingSource;

        }

    }
}