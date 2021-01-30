using System;

namespace OOPReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değer Tipler : int, decimal, float, enum, boolean : Value Types
            // Referans Tipler : array, class, interface : Reference Types 

            // Değer Tip Örneği : Değer tiplerde değişkenin yalnızca değeri değişir örnekte olduğu gibi.

            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;
            Console.WriteLine(sayi1);

            // Referans Tip Örneği : Referans tiplerde değişkenin* referansı değişir. Bu yüzden sayilar1 in değerleri tamamiyle 
            // sayilar2'nin değerlerine eşitlenir ve sayilar1'in içerikleri kalmaz, silinir.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FistName = "Elif";

            person2.FistName = "Orhan";

            person1 = person2;
            person2.FistName = "Emre";
            Console.WriteLine(person2.FistName);
            


            Customer customer = new Customer();
            customer.FistName = "Engin";
            customer.CreditCardNumber = "123456456";
            Employee employee = new Employee();
            employee.FistName = "Ali";

            Person person3 = customer;
            Console.WriteLine(person3.FistName);
            Console.WriteLine(((Customer) person3).CreditCardNumber); // boxing !!!

            // Burada Person "base class"'tır. 

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); // PersonManager'a parametre olarak "Person person" verdiğimiz için tüm class'ları seçebiliyoruz.
        }
    }

    // Inheritance : Miras Alma 
    // Aşağıdaki örnekte 3 adet class oluşturduk. Person class'ını diğer 2 class'a ekledik. Person class'ının değerleri diğer 2 class'ta da olur bu sayede.
    class Person
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FistName);
        }
    }
}
