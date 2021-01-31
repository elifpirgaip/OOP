using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir class'ı new'lediğimiz zaman çalışan bloktur. Class ilk kez oluştuğunda bir kere çalışır, bir daha çalışmaz.
            // contructor yazmak için ==> "ctor" yazıp tab tuşuna iki kez basmak yeterlidir.
            // constructor : yapıcı blok  --> Sınıfı ilk kez yapılandırdığımızda çalışan blok. Örn: -->
            
            Customer customer1 = new Customer {Id=1, FirstName= "Elif", LastName ="PİRGAİP", City="İstanbul" };
            // "Customer" class'ımıza yukarıda görüldüğü gibi süslü parantezler içerisine değerler girilerek de ekleme yapılabilir.
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer(2, "Emre", "PİRGAİP", "İSTANBUL");
            // "Customer"class'ımıza yukarıda görüldüğü gibi normal parantezler arasına parametre isimleri girilmeden de ekleme yapılabilir.
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Aylin";
            customer3.LastName = "Koç";
            customer3.City = "Giresun";
            // "customer3" ve "customer2" classlarının kullanımları aynıdır. 
            Console.WriteLine(customer3.City);

            Method(2, "deneme", "deneme", "deneme");
            // constructor'lar da memthodlar gibi çalışır. Yukarıdaki örnekte görüldüğü gibi.
        }

        static void Method(int id, string firstName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        public Customer() // Bu default constructor'ı oluşturma sebebimiz, aşağıda oluşturduğumuz const'a parametre atadığımızdan
                          // yukarıdaki customer2 class'ımız bize kızdı. Bu yüzden parametresiz, default constructor'a ihtiyacımız vardı.
        {
            
        }
        public Customer(int id, string firstName, string lastName, string city) // "ctor" yazıp tab tab yaptık. --> default constructor'dır bu blok.
        {
            Console.WriteLine("Yapıcı blok çalıştı. (constructor)");

            // Aşağıdaki olay değerlerimizi set etmektir. Bunu yapmamızın sebebi, yukarıdaki "customer2" buradaki constuctor'ın küçük harfli
            // olan parametre değerlerini baz alması ve bu nedenle yazdırmaya çalıştığımızda görünmemesidir. 
            // "customer2"'nin değerlerini normal parantezler içerisinde yazdığımız için, constructor içersindeki "id, firstName, lastName ve city" parametrelerini baz aldı.

            Id = id; 
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
