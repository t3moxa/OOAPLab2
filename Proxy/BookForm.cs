using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proxy.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proxy
{
    public partial class BookForm : Form
    {
        public User currentUser;
        public Catalogue? currentCatalogue;
        public BookForm()
        {
            InitializeComponent();
        }
        public void ChangeRights(bool b)
        {
            if (b)
            {
                RightsLabel.Text = "Администраторские";
            }
            else
                RightsLabel.Text = "Пользовательские";
        }
        private void LoadCatalogue(ProxyCatalogue pc)
        {
            currentCatalogue = pc;
            CatalogueNameBox.Text = pc.name;
            BookListBox.Items.Clear();
            foreach (Book b in pc.GetCatalogue())
            {
                BookListBox.Items.Add(b.title);
            }
        }
        private void LoadBook(Book bk)
        {
            TitleBox.Text = bk.title;
            AuthorsBox.Text = bk.authors;
            YearBox.Text = bk.year;
            DescriptionBox.Text = bk.description;
        }
        private void SaveBook(Book bk)
        {
            bk.title = TitleBox.Text;
            bk.authors = AuthorsBox.Text;
            bk.year = YearBox.Text;
            bk.description = DescriptionBox.Text;
            BookListBox.Items[BookListBox.SelectedIndex] = bk.title;
        }
        private void ImportCatalogueButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            LoadCatalogue(Catalogue.DeserializeCatalogue(fileText));
        }
        private void BookListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex != -1)
            {
                LoadBook(currentCatalogue.GetCatalogue()[BookListBox.SelectedIndex]);
            }
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            if (BookListBox.SelectedIndex != -1)
                currentCatalogue.ChangeBook(currentUser, BookListBox.SelectedIndex, TitleBox.Text, AuthorsBox.Text, YearBox.Text, DescriptionBox.Text);
        }

        private void ExportCatalogueButton_Click(object sender, EventArgs e)
        {
            currentCatalogue.name = CatalogueNameBox.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string filetext = currentCatalogue.SerializeCatalogue(currentUser);
            File.WriteAllText(filename, filetext);
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (currentCatalogue != null)
            {
                Book bk = new Book("New book");
                if (currentCatalogue.AddBook(currentUser, bk))
                    BookListBox.Items.Add(bk.title);
            }
        }

        private void CreateCatalogueButton_Click(object sender, EventArgs e)
        {
            var cc = Catalogue.NewCatalogue(currentUser, "New catalogue");
            if (cc != null)
                LoadCatalogue(cc);
        }
    }
}
