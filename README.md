# Week 3 Day 2nd try Classes continued

We are learning to organize data

we will revisit classes,fields properties,methods,etc. Also classes inside of classes

we will rig up a gui possibly asking for purchasing info

The uml tells you the field required 

"+" this means it's public


 +string _title
        +string _director
        +double _rating
        +double _price
        +Product(string, string, double, double)

        these are the fields and contructors

        contructors have the same name as your class


        This is a defualt contructor
        public Product(){

        }

         a method is a box



         Highlight fields right click click quick actions and refactories, click generate contructor.

         Method overloading:allows multiple methods to have the same name with different parameter types


         Can't have two mehtod signitures with the same number of name and tytpes as parameters


         getters give permission to look at a field

          public string GetTitle()
        {
            return _title;
        }//GetTitle()

         setters give permission to change a field
         
        public void SetTitle(string title)
        {
            _title = title;
        }

        SetTitle only works if it is written before the GetTitle not after


        
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


        a method is a verb ba action vsn perform will always gave access




        Product charlesMovie = new Product("El Dorado", "Howard Hawks");


            //charlesMovie.SetTitle("MallRats"); //<-------- MallRats is value
            //MessageBox.Show(charlesMovie.GetTitle());

            try
            {
                charlesMovie.Price = -5;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
         Product charlesMovie = new Product("El Dorado", "Howard Hawks");


            //charlesMovie.SetTitle("MallRats"); //<-------- MallRats is value
            //MessageBox.Show(charlesMovie.GetTitle());

            try
            {
                charlesMovie.Price = -5;
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


              public decimal TotalPrice()
        {
            decimal totalPrice = 0m;


            //looping thrpough our product list

            foreach (Product product in _products)
            {
                totalPrice += product.Price;    
            }

            return totalPrice;
        }

        make sure to retuen total price so intelle doesn't yell at you

        AmazonOrder order1 = new AmazonOrder("123478", "Will Cram", .1m); 

        the .1m is the tax rate aka 10 percent

          order1.Products.Add(new Product("Eternal sunshine of a spotless mind" , "Michelle Gondry", 10,14.00m));

            order1.Products.Add(new Product("El Dorado", "Howard Hawks", 10,17.00m)); 
            order1.Products.Add(new Product("Robocop", "Paul Verrhoven", 10, 13.00m));

            the 10 is jsut the rating
