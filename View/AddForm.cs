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
    public partial class AddForm : Form
    {
        private int numRadioButton = 0;

        public AddForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Назвние издательства:";
            label5.Text = "Город издания:";
            label6.Text = "Количество страниц:";

            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;

            label6.Visible = true;
            textBox6.Visible = true;

            numRadioButton = 1;
        }

        private void radioButtonMag_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Назвние журнала:";
            label5.Text = "Номер журнала:";

            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;

            label6.Visible = false;
            textBox6.Visible = false;

            numRadioButton = 2;
        }

        private void radioButtonCol_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Назвние сборника:";
            label5.Text = "Город издания:";

            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;

            label6.Visible = false;
            textBox6.Visible = false;

            numRadioButton = 3;
        }

        private void radioButtonTh_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Ученая степень автора:";
            label5.Text = "Город издания:";
            label6.Text = "Количество страниц:";

            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;

            label6.Visible = true;
            textBox6.Visible = true;

            numRadioButton = 4;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MainForm Form = (MainForm)Owner;

            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                    throw new Exception("Данные не введены");
                string fio = textBox1.Text;
                string name = textBox2.Text;
                int year = int.Parse(textBox3.Text);

                switch (numRadioButton)
                {
                    case 1:
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                            throw new Exception("Данные не введены");
                        string publisher = textBox4.Text;
                        string city = textBox5.Text;
                        int pages = int.Parse(textBox6.Text);
                        Form.AddListItem(new Book(fio, name, year, publisher, city, pages));
                        break;
                    case 2:
                        if (textBox4.Text == "" || textBox5.Text == "")
                            throw new Exception("Данные не введены");
                        string mameMag = textBox4.Text;
                        int number = int.Parse(textBox5.Text);
                        Form.AddListItem(new Magazine(fio, name, year, mameMag, number));
                        break;
                    case 3:
                        if (textBox4.Text == "" || textBox5.Text == "")
                            throw new Exception("Данные не введены");
                        string nameCol = textBox4.Text;
                        string cityC = textBox5.Text;
                        Form.AddListItem(new Collection(fio, name, year, nameCol, cityC));
                        break;
                    case 4:
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                            throw new Exception("Данные не введены");
                        string rank = textBox4.Text;
                        string cityT = textBox5.Text;
                        int pagesT = int.Parse(textBox6.Text);
                        Form.AddListItem(new Thesis(fio, name, year, rank, cityT, pagesT));
                        break;
                    default:
                        throw new Exception("Не выбран источник");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
