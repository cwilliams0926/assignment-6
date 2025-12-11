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
    }
}
