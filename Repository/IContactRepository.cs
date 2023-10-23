using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PhoneBook.Repository
{
    internal interface IContactRepository
    {
        DataTable SellectAll();
        DataTable SelectById(int contactId);
        DataTable SearchBtNameAndFamily(string searchText);
        bool Insert(string name, string family, int age, string email, string phoneNumber, string address);
        bool Update(int contactId ,string name, string family, int age, string email, string phoneNumber, string address);
        bool Delete(int contactId);
    }
}
