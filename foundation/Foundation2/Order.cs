public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order( List<Product> products,Customer customer)
            {
                _products = products;
                _customer = customer;
            }

        public string GetPackingLabel(string name, string productId)
            {
                //foreach (Product product in _products)
                return name;
            }

        public string GetTotal()
            {
                foreach (Product prod in _products)
                    {
                        float total2 += prod
                    }
                return total2;
            }

        public string GetShippingLabel(string name, Address address)
            {
                return name;
            }
    }