using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace req5
{
    class Member:IComparable
    {
        long _id;
        string _firstName;
        string _lastName;
        string _email;
        string _contactNumber;
        string _licenseNumber;
        DateTime _licenseStartDate;
        DateTime _licenseExpiryDate;

        public long Id { get { return _id; } set { _id = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string ContactNumber { get { return _contactNumber; } set { _contactNumber = value; } }
        public string LicenseNumber { get { return _licenseNumber; } set { _licenseNumber = value; } }
        public DateTime LicenseStartDate { get { return _licenseStartDate; } set { _licenseStartDate = value; } }
        public DateTime LicenseExpiryDate { get { return _licenseExpiryDate; } set { _licenseExpiryDate = value; } }

        public Member()
        {
            Id = 0; FirstName = null; LastName = null; Email = null; ContactNumber = null; LicenseNumber = null;
            LicenseStartDate = DateTime.Now; LicenseExpiryDate = DateTime.Now;
        }

        public Member(long id, string fname, string lname, string email, string contact, string license, DateTime start, DateTime expiry)
        {
            Id = id; FirstName = fname; LastName = lname; Email = email; ContactNumber = contact; LicenseNumber = license;
            LicenseStartDate = start; LicenseExpiryDate = expiry;
        }

        public bool Equals(Member m)
        {
            string email = this.Email.ToLower();
            string email1 = m.Email.ToLower();
            if (email == email1 && this.ContactNumber.ToLower() == m.ContactNumber.ToLower())
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            string str = string.Format("Name: {0} , {1}\nMember contact details: {2} , {3}", FirstName, LastName, ContactNumber, Email);
            return str;
        }

        public static Member CreateInstance(string detail)
        {
            string[] input = detail.Split(',');
            return new Member(long.Parse(input[0]),input[1],input[2],input[3],input[4],input[5],DateTime.Parse(input[6]),DateTime.Parse(input[7]));
        }

        public int CompareTo(object obj)
        {
            Member other = (Member)obj;
            return this.FirstName.CompareTo(other.FirstName);
        }
    }
}
