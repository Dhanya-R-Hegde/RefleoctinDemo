using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class ReflectionOnCustomer
    {
        public static void Test()
        {  
            Type type = typeof(CustomerInfo);

            Console.WriteLine("FullName of Class is : " + type.FullName);
            Console.WriteLine("------------------------");

            Console.WriteLine("Name is : " + type.Name);
            Console.WriteLine("------------------------");

            Console.WriteLine("Methods used in CustomerInfo Class");
            MethodInfo[] methods = type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " : " + method.Name);
            }
            Console.WriteLine("------------------------");

            Console.WriteLine("Properties in our CustomerInfo Class");
            PropertyInfo[] property = type.GetProperties();
            foreach(PropertyInfo propertyInfo in property)
            {
                Console.WriteLine(propertyInfo.PropertyType.Name + ": " + propertyInfo.Name);
            }
            Console.WriteLine("------------------------");

            Console.WriteLine("Constructors in our CustomerInfo Class");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructorInfo in constructors)
            {
                Console.WriteLine(constructorInfo.ToString());
            }
            Console.WriteLine("------------------------");

            Console.WriteLine("Constructors in our CustomerInfo Class using binding");
            ConstructorInfo[] constructorsBinding = type.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
            foreach (ConstructorInfo constructorInfo in constructorsBinding)
            {
                Console.WriteLine(constructorInfo.ToString());
            }
            Console.WriteLine("------------------------");

        }
    }
}
