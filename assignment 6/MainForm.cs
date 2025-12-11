using Microsoft.EntityFrameworkCore;

namespace assignment_6
{
    public partial class MainForm : Form
    {
        private IPersonDataSource db = new PersonContextDataSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Person currentPerson = (Person)personBindingSource.Current;
            if (currentPerson == null)
                return;
            db.Delete(currentPerson);
            db.SaveChanges();
            ApplyFilter();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    var newPerson = new Person
                    {
                        Name = addForm.PersonName,
                        Phone = addForm.PersonPhone
                    };
                    db.Add(newPerson);
                    db.SaveChanges();
                }
            }
            ApplyFilter();
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        // This should be called searchTextBox_TextChanged but I added the event handler
        // before renaming and now I can't fix it
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            personBindingSource.DataSource = db.GetPeople(searchTextBox.Text);
        }
    }
}
