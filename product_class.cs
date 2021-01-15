using System;

namespace product_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Huawei Notebook";
            product1.productPrice = 6000;
            product1.discountRate = 10;
            
            Product product2 = new Product();
            product2.productName = "Lenovo Notebook";
            product2.productPrice = 4000;
            product2.discountRate = 25;

            Product product3 = new Product();
            product3.productName = "Asus Notebook";
            product3.productPrice = 8000;
            product3.discountRate = 0;


            Product[] products = new Product[] { product1, product2 , product3};

            foreach (var product in products)
            {
                Console.WriteLine("Product Name: " + product.productName
                    + "\nProduct Price: " + product.productPrice
                    + "\nDiscount Rate: " + product.discountRate
                    + "\nNew Product Price After Sales: " + product.newProductPrice
                    + "\n-----------------");
            }
        }
    }

    class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public double newProductPrice
        {
            get
            {
                return productPrice - ((productPrice * discountRate) / 100);
            }
        }
        public int discountRate { get; set; }





        // 2nd Way
        /*
        private double _productPrice;
        public double productPrice
        {
            get
            {
                if (discountRate == 0)
                {
                    return _productPrice;
                }
                else
                {
                    return _productPrice - ((_productPrice * discountRate) / 100);
                }
                
            }
            set { _productPrice = value; }


        }
        */
        

    }
}
