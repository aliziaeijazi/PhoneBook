using PhoneBook.Repository;
using PhoneBook.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        IContactRepository repository;
        public int contactId = 0;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataOnDataGrid();
        }

        private void SearchInput_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchInput.Text;
            ContactTable.DataSource = repository.SearchBtNameAndFamily(searchText);
        }
        private void LoadDataOnDataGrid()
        {
            ContactTable.AutoGenerateColumns = false;
            ContactTable.DataSource = repository.SellectAll();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ContactTable.CurrentRow != null)
            {

                int contactId = int.Parse(ContactTable.CurrentRow.Cells[0].Value.ToString());
                string name = ContactTable.CurrentRow.Cells[1].Value.ToString();
                string family = ContactTable.CurrentRow.Cells[2].Value.ToString();
                string fullName = $"{name} {family}";
                DialogResult confirmation = MessageBox.Show($"آیا از حدف {fullName} اطمینان دارید؟", "توجه", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    repository.Delete(contactId);
                    LoadDataOnDataGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا برای حذف یک فرد را انتخاب نمایید");
            }
        }

        private void InsertContactBtn_Click(object sender, EventArgs e)
        {
            AddOrEditForm addContact = new AddOrEditForm();
            addContact.ShowDialog();
            if (addContact.DialogResult == DialogResult.OK)
            {
                LoadDataOnDataGrid();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ContactTable.CurrentRow != null)
            {
                int contactId = int.Parse(ContactTable.CurrentRow.Cells[0].Value.ToString());
                AddOrEditForm editContact = new AddOrEditForm();
                editContact.contactId = contactId;
                if (editContact.ShowDialog() == DialogResult.OK)
                {
                    LoadDataOnDataGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا برای ویرایش یک فرد را انتخاب نمایید.");
            }
        }

        private void RefreshContactBtn_Click(object sender, EventArgs e)
        {
            LoadDataOnDataGrid();
        }
    }
}
