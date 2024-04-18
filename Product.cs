using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Week_3_Day_2nd_try_Classes_continued
{
    internal class Product
    {
        //fields

        //+string _title
        //+string _director
        //+double _rating
        //+double _price

        //+ means this will be public

        private int _uId;
        private string _title;
        private string _director;
        private double _rating;
        private decimal _price;

        public Product(string title, string director)
        {

            Random rand = new Random();
            UId = rand.Next(10000000, 1000000000);
            Title = title;
            Director = director;
            Rating = 0.0;
            Price = 0.0m;

        }

        public Product(string title, string director, double rating, decimal price)
        {
            Random rand = new Random();
            UId = rand.Next(10000000, 1000000000);

            Title = title;
            Director = director;
            Rating = rating;
            Price = price;
        }




        //Constructor  contructors have the same name as your class


        //how do i make a contructor?
        //+Product(string, string, double, double)

        //public Product(string title, string director, double rating, decimal price)
        //{
        //    _title = title;
        //    _director = director;
        //    _rating = rating;
        //    _price = price;

        //}





        //fields 

        //contructors contructors have the same name as your class

        //properties 
        public int UId { get => _uId; private set => _uId = value; }
        public string Title { get => _title; set => _title = value; }
        public string Director { get => _director; set => _director = value; }
        public double Rating { get => _rating; set => _rating = value; }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new Exception("Enter in a value greater than 0");
                }

            }
        }
        //getters

        //public string GetTitle()
        //{
        //    return _title;
        //}//GetTitle()

        ////setters


        //public void SetTitle(string title)
        //{
        //    _title = title;
        //}
        //methods


        //+Product(string, string, double, double) 

        //Jow can you tell this is not a class?

        //A: same format opf a type an a name

    }// class

}// namespace
