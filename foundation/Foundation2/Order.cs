public class Order
    {
        private Customer _customer;
        private List<Product> _products;

        public Order( List<Product> products,Customer customer)
            {
                _products = products;
                _customer = customer;
            }

         public string GetPackingLabel()
             {
                string label = "Packing Label:\n";
                foreach (Product product in _products)
                {
                   label += $"{product.GetName()}, Product ID: {product.GetProductId()}\n";
                 }
                return label;
            }

         public float GetTotal()
              {
                 float productTotal = _products.Sum(product => product.GetTotalCost());

                 // Determine shipping cost
                float shippingCost = _customer.IsInUSA() ? 5.0f : 35.0f;

                return productTotal + shippingCost;
                }
                

      

        public string GetShippingLabel()
            {
             string customerName = _customer.GetName();
             string customerAddress = _customer.GetAddress().GetDisplayText();

            return $"Shipping Label:\nName: {customerName}\n{customerAddress}";
            }
         
   }