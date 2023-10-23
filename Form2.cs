using PhoneBook.Repository;
using PhoneBook.Services;
using System;
using System.Data;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PhoneBook
{
    public partial class AddOrEditForm : Form
    {
        public int contactId = 0;
        contact_DBEntities db = new contact_DBEntities();
        public AddOrEditForm()
        {
            InitializeComponent();
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
                MyContact contact = db.MyContacts.Find(contactId);
                NameInput.Text = contact.Name;
                FamilyInput.Text = contact.Family;
                AgeInput.Value = contact.Age;
                PhoneNumberInput.Text = contact.PhoneNumber;
                EmailInput.Text = contact.Email;
                AddressInput.Text = contact.Address;
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
                    MyContact newContact = new MyContact()
                    {
                        Name = NameInput.Text.ToString(),
                        Family = FamilyInput.Text.ToString(),
                        Age = int.Parse(AgeInput.Value.ToString()),
                        PhoneNumber = PhoneNumberInput.Text.ToString(),
                        Email = EmailInput.Text.ToString(),
                        Address = AddressInput.Text.ToString()
                    };
                    db.MyContacts.Add(newContact);
                }
                else
                {
                    MyContact contact = db.MyContacts.Find(contactId);
                    contact.Name = NameInput.Text.ToString();
                    contact.Family = FamilyInput.Text.ToString();
                    contact.Age = int.Parse(AgeInput.Value.ToString());
                    contact.PhoneNumber = PhoneNumberInput.Text.ToString();
                    contact.Email = EmailInput.Text.ToString();
                    contact.Address = AddressInput.Text.ToString();

                }
                db.SaveChanges();
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
        }



    }
}
