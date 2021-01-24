using System;

namespace Metot_Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            Customer customer1 = new Customer();
            customer1.ID = 1234;
            customer1.MusteriNo = 1;
            customer1.Ad = "Mert";
            customer1.Soyad = "Çelik";
            customer1.DogumTarihi = new DateTime(1995, 10, 16);

            Customer customer2 = new Customer();
            customer2.ID = 1234;
            customer2.MusteriNo = 1;
            customer2.Ad = "Salih";
            customer2.Soyad = "İnceoğlu";
            customer2.DogumTarihi = new DateTime(1980, 11, 1);

            Customer customer3 = new Customer();
            customer3.ID = 1234;
            customer3.MusteriNo = 1;
            customer3.Ad = "Ömer";
            customer3.Soyad = "candan";
            customer3.DogumTarihi = new DateTime(1999, 1, 1);


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.List();





        }
    }
}
