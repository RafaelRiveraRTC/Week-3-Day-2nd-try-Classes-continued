using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week_3_Day_2nd_try_Classes_continued
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //create an instance of an amaxzon order
            AmazonOrder order1 = new AmazonOrder("123478", "Will Cram", .1m);

            //Add 3 products
            //listname.Add(Product)
            order1.Products.Add(new Product("Eternal sunshine of a spotless mind" , "Michelle Gondry", 10,14.00m));

            order1.Products.Add(new Product("El Dorado", "Howard Hawks", 10,17.00m)); 
            order1.Products.Add(new Product("Robocop", "Paul Verrhoven", 10, 13.00m));


            MessageBox.Show(order1.TotalPrice().ToString("c"));

            //Write the code to calculate the products
            //Display the final oprice with a single method cell

        }
    }
}