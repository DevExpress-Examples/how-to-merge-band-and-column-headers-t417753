using System.Collections.ObjectModel;

namespace DXSample {
    public class MainViewModel {
        public ObservableCollection<Customer> Customers { get; set; }

        public MainViewModel() {
            Customers = new ObservableCollection<Customer>();
            Customers.Add(new Customer() {
                FullName = "Nancy Davolio",
                JobTitle = "Sales Representative",
                CompanyName = "Lonesome Pine Restaurant",
                Phone = "(503) 555-9573",
                Email = "nancy_davolio@outlook.com",
                Country = "USA",
                City = "Portland"
            });
            Customers.Add(new Customer() {
                FullName = "Henriette Pfalzheim",
                JobTitle = "Vice President",
                CompanyName = "Ottilies Käseladen",
                Phone = "0221-0644327",
                Email = "henriette_pfalzheim@outlook.com",
                Country = "Germany",
                City = "Köln"
            });
        }
    }
    public class Customer {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Phone { get; set; }

    }
}
