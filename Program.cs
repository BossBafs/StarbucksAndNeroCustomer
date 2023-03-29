using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin",
                LastName = "DEMİROĞ", NationalityId = "28861499108"});
            Console.ReadLine();
        }
    }
}