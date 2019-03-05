namespace SimpleApi.Models
{
    using ServiceStack.DataAnnotations;

    [Alias("AddressTable")]
    public class Address
    {
        [AutoIncrement]
        public int ID { get; set; }

        public string AddressOne { get; set; }

        public string AddressTwo { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostCode { get; set; }
    }
}