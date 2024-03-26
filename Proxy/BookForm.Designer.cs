namespace Proxy
{
    partial class BookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ImportCatalogueButton = new Button();
            ExportCatalogueButton = new Button();
            SaveBookButton = new Button();
            BookListBox = new ListBox();
            CatalogueNameBox = new TextBox();
            TitleBox = new TextBox();
            AuthorsBox = new TextBox();
            YearBox = new TextBox();
            DescriptionBox = new TextBox();
            CreateCatalogueButton = new Button();
            AddBookButton = new Button();
            label7 = new Label();
            RightsLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 56);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Название каталога";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 1;
            label2.Text = "Список книг в каталоге";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 74);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Название книги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 121);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Авторы";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 167);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "Год выпуска";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 209);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "Описание";
            // 
            // ImportCatalogueButton
            // 
            ImportCatalogueButton.Location = new Point(183, 269);
            ImportCatalogueButton.Name = "ImportCatalogueButton";
            ImportCatalogueButton.Size = new Size(166, 23);
            ImportCatalogueButton.TabIndex = 6;
            ImportCatalogueButton.Text = "Импортировать каталог";
            ImportCatalogueButton.UseVisualStyleBackColor = true;
            ImportCatalogueButton.Click += ImportCatalogueButton_Click;
            // 
            // ExportCatalogueButton
            // 
            ExportCatalogueButton.Location = new Point(183, 298);
            ExportCatalogueButton.Name = "ExportCatalogueButton";
            ExportCatalogueButton.Size = new Size(166, 23);
            ExportCatalogueButton.TabIndex = 7;
            ExportCatalogueButton.Text = "Экспортировать каталог";
            ExportCatalogueButton.UseVisualStyleBackColor = true;
            ExportCatalogueButton.Click += ExportCatalogueButton_Click;
            // 
            // SaveBookButton
            // 
            SaveBookButton.Location = new Point(415, 289);
            SaveBookButton.Name = "SaveBookButton";
            SaveBookButton.Size = new Size(139, 40);
            SaveBookButton.TabIndex = 8;
            SaveBookButton.Text = "Сохранить информацию о книге";
            SaveBookButton.UseVisualStyleBackColor = true;
            SaveBookButton.Click += SaveBookButton_Click;
            // 
            // BookListBox
            // 
            BookListBox.FormattingEnabled = true;
            BookListBox.ItemHeight = 15;
            BookListBox.Location = new Point(29, 122);
            BookListBox.Name = "BookListBox";
            BookListBox.Size = new Size(134, 199);
            BookListBox.TabIndex = 9;
            BookListBox.SelectedIndexChanged += BookListBox_SelectedIndexChanged;
            // 
            // CatalogueNameBox
            // 
            CatalogueNameBox.Location = new Point(29, 74);
            CatalogueNameBox.Name = "CatalogueNameBox";
            CatalogueNameBox.Size = new Size(136, 23);
            CatalogueNameBox.TabIndex = 10;
            // 
            // TitleBox
            // 
            TitleBox.Location = new Point(415, 92);
            TitleBox.Name = "TitleBox";
            TitleBox.Size = new Size(100, 23);
            TitleBox.TabIndex = 11;
            // 
            // AuthorsBox
            // 
            AuthorsBox.Location = new Point(415, 141);
            AuthorsBox.Name = "AuthorsBox";
            AuthorsBox.Size = new Size(100, 23);
            AuthorsBox.TabIndex = 12;
            // 
            // YearBox
            // 
            YearBox.Location = new Point(415, 183);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(100, 23);
            YearBox.TabIndex = 13;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Location = new Point(415, 227);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(100, 23);
            DescriptionBox.TabIndex = 14;
            // 
            // CreateCatalogueButton
            // 
            CreateCatalogueButton.Location = new Point(183, 122);
            CreateCatalogueButton.Name = "CreateCatalogueButton";
            CreateCatalogueButton.Size = new Size(166, 23);
            CreateCatalogueButton.TabIndex = 15;
            CreateCatalogueButton.Text = "Создать каталог";
            CreateCatalogueButton.UseVisualStyleBackColor = true;
            CreateCatalogueButton.Click += CreateCatalogueButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(415, 256);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(139, 23);
            AddBookButton.TabIndex = 16;
            AddBookButton.Text = "Добавить книгу";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 9);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 17;
            label7.Text = "Права:";
            // 
            // RightsLabel
            // 
            RightsLabel.AutoSize = true;
            RightsLabel.Location = new Point(415, 24);
            RightsLabel.Name = "RightsLabel";
            RightsLabel.Size = new Size(109, 15);
            RightsLabel.TabIndex = 18;
            RightsLabel.Text = "Пользовательские";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 395);
            Controls.Add(RightsLabel);
            Controls.Add(label7);
            Controls.Add(AddBookButton);
            Controls.Add(CreateCatalogueButton);
            Controls.Add(DescriptionBox);
            Controls.Add(YearBox);
            Controls.Add(AuthorsBox);
            Controls.Add(TitleBox);
            Controls.Add(CatalogueNameBox);
            Controls.Add(BookListBox);
            Controls.Add(SaveBookButton);
            Controls.Add(ExportCatalogueButton);
            Controls.Add(ImportCatalogueButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookForm";
            Text = "BookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ImportCatalogueButton;
        private Button ExportCatalogueButton;
        private Button SaveBookButton;
        private ListBox BookListBox;
        private TextBox CatalogueNameBox;
        private TextBox TitleBox;
        private TextBox AuthorsBox;
        private TextBox YearBox;
        private TextBox DescriptionBox;
        private Button CreateCatalogueButton;
        private Button AddBookButton;
        private Label label7;
        private Label RightsLabel;
    }
}