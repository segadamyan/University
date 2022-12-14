namespace University
{
    public partial class Form1 : Form
    {
        private User user = new User(0, "user", "CS");
        public Form1()
        {
            InitializeComponent();
            this.takeTest.Visible = false;
        }

        private void takeTest_Click(object sender, EventArgs e)
        {
            if (user.id == 0)
            {
                MessageBox.Show("Please login first.");
            } else
            {
                test testing = new test(user);
                testing.ShowDialog();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(user);
            login.ShowDialog();
            if (user.id != 0)
            {
                this.takeTest.Visible = true;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
            this.user.id = 0;
            this.takeTest.Visible = false;
        }
    }

    public class User
    {
        public int id;
        public string username;
        public string faculty;

        public User(int id, string username, string faculty)
        {
            this.id = id;
            this.username = username;
            this.faculty = faculty;
        }
    }
}