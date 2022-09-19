using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Model;

namespace View
{
    public partial class FindForm : Form
    {
        /// <summary>Список с найденными элементами</summary>
        public readonly List<ILibrary> Find = new List<ILibrary>();

        public FindForm()
        {
            InitializeComponent();
        }

        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            foreach (var item in Form.ListL)
            {
                if (item.GetType() == typeof(Book))
                    Find.Add(item);
            }
            Form.AddFindItem(Find);
        }

        private void radioButtonMag_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            foreach (var item in Form.ListL)
            {
                if (item.GetType() == typeof(Magazine))
                    Find.Add(item);
            }
            Form.AddFindItem(Find);
        }

        private void radioButtonCol_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            foreach (var item in Form.ListL)
            {
                if (item.GetType() == typeof(Collection))
                    Find.Add(item);
            }
            Form.AddFindItem(Find);
        }

        private void radioButtonTh_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            foreach (var item in Form.ListL)
            {
                if (item.GetType() == typeof(Thesis))
                    Find.Add(item);
            }
            Form.AddFindItem(Find);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Form.ShowGrid();
            Close();
        }

        private void radioButtonFio_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            try
            {
                
                if (textBoxFio.Text == "")
                    throw new Exception("Некорректное имя автора");
                foreach (var item in Form.ListL)
                {
                    if (item.Fio.Contains(textBoxFio.Text))
                        Find.Add(item);
                }
                Form.AddFindItem(Find);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void radioButtonName_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            try
            {
                if (textBoxName.Text == "")
                    throw new Exception("Некорректное название источника");
                foreach (var item in Form.ListL)
                {
                    if (item.Name == textBoxName.Text)
                        Find.Add(item);
                }
                Form.AddFindItem(Find);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;
            Form.ClearGrid();
            Find.Clear();
            try
            {
                foreach (var item in Form.ListL)
                {
                    if (item.Year == int.Parse(textBoxYear.Text))
                        Find.Add(item);
                }
                Form.AddFindItem(Find);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
