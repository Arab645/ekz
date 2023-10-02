namespace hwForUniversity
{
    class Address
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public string Country
        {
            get => _country;
            set => _country = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string House
        {
            get => _house;
            set => _house = value;
        }

        public string Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }
    }
}
