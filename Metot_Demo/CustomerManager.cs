using System;
using System.Collections.Generic;
using System.Text;

namespace Metot_Demo
{
   public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi" + Environment.NewLine + customer.ID + Environment.NewLine + customer.MusteriNo + Environment.NewLine + customer.Ad + " " + customer.Soyad + Environment.NewLine + customer.DogumTarihi);
            Console.WriteLine("----------------------------------");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri silindi" + Environment.NewLine + customer.Ad + " " + customer.Soyad);

        }


        List<Customer> customers = new List<Customer>();
        public void List()
        {
            foreach (var item in customers)
            {
                Console.WriteLine(customers);
            }

        }



    }
}
