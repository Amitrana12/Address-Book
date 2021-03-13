using System;
using System.Collections.Generic;
using System.Text;

namespace Address_book
{
    class AddressBook
    {
        public List<Contact> ContactList;
        public AddressBook()
        {
            this.ContactList = new List<Contact>();
        }
        public void AddContact(Contact contactObj)
        {
            this.ContactList.Add(contactObj);
        }
        public int FindByPhoneNum(long phoneNumber)
        {
            return this.ContactList.FindIndex(contact => contact.PhoneNumber.Equals(phoneNumber));
        }
        //Find Contact Object Index By FirstName
        public int FindByFirstName(string firstName)
        {
            return this.ContactList.FindIndex(contact => contact.FirstName.Equals(firstName));
        }
        //Delete a Give Contact By Index
        public void DeleteContact(int index)
        {
            this.ContactList.RemoveAt(index);
        }

    }
}
