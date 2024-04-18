using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_2nd_try_Classes_continued
{
    internal class AmazonOrder
    {

        //fields

        string _orderId;
        string _name;
        List<Product> _products;
        decimal _tax;




        //construcotrs

        public AmazonOrder(string orderId, string name, decimal tax)
        {
            _orderId = orderId;
            _name = name;
            _tax = tax;
            _products = new List<Product>();
        }


        //properties 
        public string OrderId { get => _orderId; set => _orderId = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Tax { get => _tax; set => _tax = value; }
        internal List<Product> Products { get => _products; set => _products = value; }

        //methods

        public decimal TotalPrice()
        {
            decimal totalPrice = 0m;


            //looping thrpough our product list

            foreach (Product product in _products)
            {
                totalPrice += product.Price;
            }

            totalPrice *= (1 + _tax);

            //return the total
            return totalPrice;
        }


    }//class
}// namespace
