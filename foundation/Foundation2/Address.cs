public class Address
    {
        private string _streetAddress;
        private string _stateOrProvince;
        private string _country;
        private string _city;

        public Address(string streetAdress,string city, string stateOrProvince, string country)
                {
                    _streetAddress = streetAdress;
                    _city = city;
                    _stateOrProvince = stateOrProvince;
                    _country = country;
                }

            public string GetDisplayText()
                {
                    return $"{_streetAddress},{_city},{_stateOrProvince} ,{_country}";
                }

             public bool IsInUSA()
                {
                    return _country.ToLower() == "usa"; 
                }

           
    }