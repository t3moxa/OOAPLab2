using Microsoft.VisualBasic.Devices;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;

namespace Proxy
{
    public class User
    {
        public string? login { get; set; }
        public string? password { get; set; }
        public bool admin { get; set; } = false;
        public User() { }
        public User(string log, string pass, bool adm)
        {
            login = log;
            password = pass;
            admin = adm;
        }
        public bool IsAdmin()
        {
            return admin;
        }
    }

    public class UserList
    {
        public List<User> users { get; set; }
        public UserList()
        {
            users = new List<User>();
        }
        public void Export()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string fileName = "UserData.json";
            string jsonString = JsonSerializer.Serialize(this, options);
            File.WriteAllText(fileName, jsonString);
        }
        public static UserList Import()
        {
            string fileName = "UserData.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<UserList>(jsonString);
        }
        public User InitializeUser(string login, string password)
        {
            foreach (var user in users)
            {
                if ((login == user.login) && (password == user.password))
                    return user;
            }
            return null;
        }
    }

    public abstract class Catalogue
    {
        public string name { get; set; }
        protected static readonly JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public abstract bool AddBook(User usr, Book bk);
        public abstract void ChangeBook(User usr, int i, string title, string authors, string year, string description);
        public abstract List<Book> GetCatalogue();
        public abstract string SerializeCatalogue(User usr);
        public static ProxyCatalogue DeserializeCatalogue(string text)
        {
            return JsonSerializer.Deserialize<ProxyCatalogue>(text, options);
        }
        public static ProxyCatalogue NewCatalogue(string name)
        {
            ProxyCatalogue rc = new ProxyCatalogue(name);
            return rc;
        }
    }
    public class RealCatalogue : Catalogue
    {
        public List<Book> books { get; set; }
        public RealCatalogue(string name)
        {
            books = new List<Book>();
            this.name = name;
        }
        public override List<Book> GetCatalogue()
        {
            return books;
        }
        public bool AddBook(Book bk)
        {
            books.Add(bk);
            return true;
        }
        public override bool AddBook(User usr, Book bk)
        {
            books.Add(bk);
            return true;
        }
        public override void ChangeBook(User usr, int i, string title, string authors, string year, string description)
        {
            books[i].ChangeBook(title, authors, year, description);
        }
        public override string SerializeCatalogue(User usr)
        {
            return JsonSerializer.Serialize(this, options);
        }
    }
    public class ProxyCatalogue : Catalogue
    {
        public RealCatalogue rCatalogue { get; set; }
        public ProxyCatalogue(string name)
        {
            this.name=name;
            rCatalogue = new RealCatalogue(name);
        }
        public override List<Book> GetCatalogue()
        {
            return rCatalogue.GetCatalogue();
        }
        public override bool AddBook(User usr, Book bk)
        {
            if (usr.IsAdmin())
                return rCatalogue.AddBook(bk);
            else
            {
                MessageBox.Show("Необходимо обладать правами администратора!");
                return false;
            }
        }
        public override void ChangeBook(User usr, int i, string title, string authors, string year, string description)
        {
            if (usr.IsAdmin())
                rCatalogue.ChangeBook(usr, i , title, authors, year, description);
            else
                MessageBox.Show("Необходимо обладать правами администратора!");
        }
        public override string SerializeCatalogue(User usr)
        {
            if (usr.IsAdmin())
                return JsonSerializer.Serialize(this, options);
            else
            {
                MessageBox.Show("Необходимо обладать правами администратора!");
                return null;
            }
        }
    }
    public class Book
    {
        public string? title { get; set; }
        public string? authors { get; set; }
        public string? year { get; set; }
        public string? description { get; set; }
        public Book()
        {

        }
        public Book(string title, string authors, string year, string description)
        {
            this.title = title;
            this.authors = authors;
            this.year = year;
            this.description = description;
        }
        public Book(string title)
        {
            this.title = title;
        }
        public void ChangeBook(string title, string authors, string year, string description)
        {
            this.title = title;
            this.authors = authors;
            this.year = year;
            this.description = description;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistrationForm());
        }
    }
}