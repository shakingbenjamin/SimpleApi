namespace SimpleApi.Models
{
    using ServiceStack.DataAnnotations;

    [Alias("ContactTable")]
    public class Contact
    {
        [AutoIncrement]
        [PrimaryKey]
        public int ID { get; set; }

        [References(typeof(Address))]
        public int AddressID { get; set; }

        [Ignore]
        public string FullName => $"{this.Title} {this.FirstName} {this.LastName}";

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mobile { get; set; }

        [Ignore]
        public Address Address { get; set; }
    }
}