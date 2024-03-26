using System.Text.Json;
using static Proxy.Program;

namespace Proxy
{
    public partial class RegistrationForm : Form
    {
        UserList userList;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            userList = UserList.Import();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            User currentUser = userList.InitializeUser(login, password);
            if (currentUser != null)
            {
                BookForm bf = new BookForm();
                bf.currentUser = currentUser;
                if (currentUser.IsAdmin())
                    bf.ChangeRights(true);
                bf.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверные данные для входа!");
        }
    }
}
