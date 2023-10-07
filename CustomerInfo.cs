using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class CustomerInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public CustomerInfo()
        {
            this.Id = 1;
            this.Name = string.Empty;
            this.IsDeleted = false;
        }

        public CustomerInfo(int Id, string Name, bool isDeleted)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsDeleted = isDeleted;
        }

        public void PrintId()
        {
            Console.WriteLine("Id is : {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is : {0}", this.Name);
        }

        public void PrintValue()
        {
            Console.WriteLine("IsDeleted value is : {0}", this.IsDeleted);
        }
    }
}
