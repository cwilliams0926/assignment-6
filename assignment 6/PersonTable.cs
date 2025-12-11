using Microsoft.EntityFrameworkCore;

namespace assignment_6
{
    public partial class PersonTable : Form
    {
        private PersonDbContext db = new();
        public PersonTable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            db.People.Load();
            personBindingSource.DataSource = db.People.Local.ToBindingList();
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
            db.People.Remove(currentPerson);
            db.SaveChanges();
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
                    db.People.Add(newPerson);
                    db.SaveChanges();
                }
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        // This should be called searchTextBox_TextChanged but I added the event handler
        // before renaming and now I can't fix it
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
