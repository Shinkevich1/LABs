using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using Model;

namespace View
{
    public partial class MainForm : Form
    {
        
        /// <summary>Поле, хранящее список источникоа</summary>
        public readonly List<ILibrary> ListL = new List<ILibrary>();
        public int size = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>Добавление объектов в dataGridView</summary>
        /// <param name="L">Объект для добавления</param>
        public void AddListItem(ILibrary L)
        {
            ListL.Add(L);
            size++;
            string buf = "";
            if (L.GetType() == typeof(Book)) buf = "Книга";
            else if (L.GetType() == typeof(Magazine)) buf = "Журнал";
            else if (L.GetType() == typeof(Collection)) buf = "Сборник";
            else if (L.GetType() == typeof(Thesis)) buf = "Диссертация";
            dataGridView1.Rows.Add(buf, L.Information());
        }

        /// <summary>Вывод списка найденных объектов на главную форму</summary>
        /// <param name="list">Найденный список</param>
        public void AddFindItem(List<ILibrary> list)
        {
            foreach (var item in list)
            {
                string buf = "";
                if (item.GetType() == typeof(Book)) buf = "Книга";
                else if (item.GetType() == typeof(Magazine)) buf = "Журнал";
                else if (item.GetType() == typeof(Collection)) buf = "Сборник";
                else if (item.GetType() == typeof(Thesis)) buf = "Диссертация";
                dataGridView1.Rows.Add(buf, item.Information());
            }
        }

        /// <summary>Отчистка поля с данными</summary>
        public void ClearGrid()
        {
            dataGridView1.Rows.Clear();
        }

        /// <summary>Вывод всех обхектов в главную форму</summary>
        public void ShowGrid()
        {
            foreach (var item in ListL)
            {
                string buf = "";
                if (item.GetType() == typeof(Book)) buf = "Книга";
                else if (item.GetType() == typeof(Magazine)) buf = "Журнал";
                else if (item.GetType() == typeof(Collection)) buf = "Сборник";
                else if (item.GetType() == typeof(Thesis)) buf = "Диссертация";
                dataGridView1.Rows.Add(buf, item.Information());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddForm { Owner = this }.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ListL.RemoveAt(dataGridView1.SelectedRows[0].Index);
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберете корректную строку", "Ошибка", MessageBoxButtons.OK);
            }
        }
#if RAND
        private void buttonRand_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string fio = $"Фамилия{size} Имя{size} Отчество{size}";
            string name = $"Название{size}";
            int year = random.Next(1950, 2021);

            switch (random.Next(4))
            {
                case 0:
                    string publisher = $"Издательство{size}";
                    string city = $"Город{size}";
                    int pages = random.Next(30, 500);
                    AddListItem(new Book(fio, name, year, publisher, city, pages));
                    break;
                case 1:
                    string mameMag = $"Название журнала{size}";
                    int number = random.Next(1, 50);
                    AddListItem(new Magazine(fio, name, year, mameMag, number));
                    break;
                case 2:
                    string nameCol = $"Название сборника{size}";
                    string cityC = $"Город{size}";
                    AddListItem(new Collection(fio, name, year, nameCol, cityC));
                    break;
                case 3:
                    string rank = $"канд. техн. наук";
                    string cityT = $"Город{size}";
                    int pagesT = random.Next(100, 500);
                    AddListItem(new Thesis(fio, name, year, rank, cityT, pagesT));
                    break;
            }
        }
#endif

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            new FindForm { Owner = this }.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOpenFD_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "my files (*.my)|*.my|All files (*.*)|*.*";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = File.OpenRead(openFileDialog1.FileName);
                    List<ILibrary> list = new BinaryFormatter().Deserialize(file) as List<ILibrary>;
                    
                    if (list != null)
                    {
                        ListL.Clear();
                        dataGridView1.Rows.Clear();
                        foreach (var item in list)
                            AddListItem(item);
                    }
                    file.Close();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonSaveFD_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "my files (*.my)|*.my|All files (*.*)|*.*";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FilterIndex == 2)
                    {
                        FileStream file = File.Create($"{saveFileDialog1.FileName}.my");
                        new BinaryFormatter().Serialize(file, ListL);
                        file.Close();
                    }
                    else
                    {
                        FileStream file = File.Create($"{saveFileDialog1.FileName}");
                        new BinaryFormatter().Serialize(file, ListL);
                        file.Close();
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
