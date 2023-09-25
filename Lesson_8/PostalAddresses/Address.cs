namespace PostalAddresses
{
    internal class Address
    {
        private int index;

        public int Index
        {
            get { return index; }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    index = value;
                }
                else
                {
                    Console.WriteLine("Неверный формат индекса!");
                }
            }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public void PrintAddress()
        {
           Console.WriteLine("Индекс: {0}\nСтрана: {1}\nГород: {2}\nУлица: {3}\nДом: {4}\nКвартира: {5}\n", Index, Country, City, Street, House, Apartment);
        }
    }
}
