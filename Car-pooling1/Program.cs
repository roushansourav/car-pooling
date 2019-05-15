using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car_pooling1 {
    class Program
    {
        static void Main(string[] args)
        {
            long id;
            string firstName, lastName, email, contactNumber, licenseNumber;
            DateTime licenseStartDate, licenseExpiryDate;
            Member[] memberArr = new Member[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member" + (i + 1) + " :");
                Console.WriteLine("id:");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("first name:");
                firstName = Console.ReadLine();
                Console.WriteLine("last name:");
                lastName = Console.ReadLine();
                Console.WriteLine("email:");
                email = Console.ReadLine();
                Console.WriteLine("contact number:");
                contactNumber = Console.ReadLine();
                Console.WriteLine("license number:");
                licenseNumber = Console.ReadLine();
                Console.WriteLine("license start date:");
                licenseStartDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                Console.WriteLine("license expiry date:");
                licenseExpiryDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                memberArr[i] = new Member(id, firstName, lastName, email, contactNumber, licenseNumber, licenseStartDate, licenseExpiryDate);
            }
            int j = 0;

            foreach (Member m in memberArr)
            {
                j++;
                Console.WriteLine("\nMember " + j);
                Console.WriteLine(m);
            }
            if (memberArr[0].Equals(memberArr[1]))
                Console.WriteLine("Member 1 is same as Member 2");
            else
                Console.WriteLine("Member 1 and Member 2 are different");
        }
    }
}
