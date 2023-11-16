using System.Data;
using System.Text;

namespace CRUD
{
    public partial class NoteTakingApplication : Form
    {
        //Declere instance of DataTable class for datagridView
        DataTable notes = new DataTable();
        bool editing = false;
        public NoteTakingApplication()
        {
            InitializeComponent();
        }

        //Load event of the app
        private void NoteTakingApplication_Load(object sender, EventArgs e)
        {

            notes.Columns.Add("Title"); // Add Title column in datagridview
            notes.Columns.Add("Description"); // Add description column in datagridview

            //Establish a connection between the datagridview and Datatable
            notesDGV.DataSource = notes;
        }

        //Create button click event
        private void createButton_Click(object sender, EventArgs e)
        {
            //The current title and description textBox value will be cleared
            title_txtBox.Text = string.Empty;
            description_txtBox.Text = string.Empty;
            editing = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Update the data if editing is true
            //editing value will be true if the user click a cell
            if (editing)
            {
                notes.Rows[notesDGV.CurrentCell.RowIndex]["Title"] = title_txtBox.Text;
                notes.Rows[notesDGV.CurrentCell.RowIndex]["Description"] = description_txtBox.Text;
            }
            //Add the data if editing = false
            else
            {
       
                notes.Rows.Add(title_txtBox.Text, description_txtBox.Text);
            }

            //reset the value in textBox
            title_txtBox.Text = "";
            description_txtBox.Text = "";
            editing = false;
        }
      

        private void deleteButton_Click(object sender, EventArgs e)
        {
            notes.Rows[notesDGV.CurrentCell.RowIndex].Delete();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            title_txtBox.Text = notes.Rows[notesDGV.CurrentCell.RowIndex].ItemArray[0].ToString();
            description_txtBox.Text = notes.Rows[notesDGV.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        //Datagridview cell double click event
        // display title and description in textBox
        private void notesDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            title_txtBox.Text = notes.Rows[notesDGV.CurrentCell.RowIndex].ItemArray[0].ToString();
            description_txtBox.Text = notes.Rows[notesDGV.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}