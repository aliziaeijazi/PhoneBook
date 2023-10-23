using PhoneBook.Repository;
using PhoneBook.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class AddOrEditForm : Form
    {
        public int contactId = 0;
        IContactRepository repository;
        public AddOrEditForm()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            if (contactId == 0)
            {
                this.Text = "افزودن فرد جدید";
                AddOrEditBtn.Text = "افزودن فرد جدید";
            }
            else
            {
                this.Text = "ویرایش اطلاعات";
                AddOrEditBtn.Text = "ویرایش اطلاعات";
                DataTable selectedContact = repository.SelectById(contactId);
                NameInput.Text = selectedContact.Rows[0][1].ToString();
                FamilyInput.Text = selectedContact.Rows[0][2].ToString();
                AgeInput.Text = selectedContact.Rows[0][6].ToString();
                PhoneNumberInput.Text = selectedContact.Rows[0][3].ToString();
                EmailInput.Text = selectedContact.Rows[0][4].ToString();
                AddressInput.Text = selectedContact.Rows[0][5].ToString();
            }
        }

        private bool ValidateInputs()
        {

            if (NameInput.Text == "") { MessageBox.Show("فیلد نام یک فیلد اجباری است. لطفا ان را وارد نمایید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (FamilyInput.Text == "") { MessageBox.Show("فیلد نام خانوادگی یک فیلد اجباری است. لطفا ان را وارد نمایید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (AgeInput.Value == 0) { MessageBox.Show("فیلد سن یک فیلد اجباری است. لطفا ان را وارد نمایید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (EmailInput.Text == "") { MessageBox.Show("فیلد پست الکترونیکی یک فیلد اجباری است. لطفا ان را وارد نمایید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (PhoneNumberInput.Text == "") { MessageBox.Show("فیلد شماره تماس یک فیلد اجباری است. لطفا ان را وارد نمایید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }

        private void AddOrEditBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccessFull;
                if (contactId == 0)
                {
                    isSuccessFull = repository.Insert(NameInput.Text, FamilyInput.Text, (int)AgeInput.Value, EmailInput.Text, PhoneNumberInput.Text, AddressInput.Text);
                }
                else
                {
                    isSuccessFull = repository.Update(contactId, NameInput.Text, FamilyInput.Text, (int)AgeInput.Value, EmailInput.Text, PhoneNumberInput.Text, AddressInput.Text);
                }
                if (isSuccessFull)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات با خطا مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

     

    }
}
