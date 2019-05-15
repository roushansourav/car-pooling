using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace req5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Members:");
            int i, n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the member details:");
            ArrayList memberList = new ArrayList();

            for (i = 0; i < n; i++)
            {
                try
                {
                    string s = Console.ReadLine();
                    Member mm = Member.CreateInstance(s);
                    if (!((mm.Email.EndsWith(".com") || mm.Email.EndsWith(".org")) && mm.Email.Contains("@")))
                        throw new InvalidEmailException("InvalidEmailException: Invalid Email for " + mm.FirstName);
                    else
                    {
                        if (mm != null)
                            memberList.Add(mm);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("\nThe member details are:");
            memberList.Sort();
            foreach (Member m in memberList)
            {
                Console.WriteLine(m.Id + "," + m.FirstName + "," + m.LastName + "," + m.Email + "," + m.ContactNumber);
            }
            Console.ReadKey();
        }

        
    }
}
