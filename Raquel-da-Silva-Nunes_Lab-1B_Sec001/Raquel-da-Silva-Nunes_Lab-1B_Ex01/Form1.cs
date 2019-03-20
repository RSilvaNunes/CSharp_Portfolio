using System;
using System.Windows.Forms;

namespace Raquel_da_Silva_Nunes_Lab_1B_Ex01
{
    public partial class Form1 : Form
    {
        //Declaring and initializing an array of integers and doubles with 5 elements
        int[] integers = new int[5];
        double[] doubles = new double[5];
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnGenerateInt_Click(object sender, EventArgs e)
        {
            try
            {
                //Generating an integer random number from 0-99
                Random rnd = new Random();
                int nb1 = rnd.Next(0, 99);
                int nb2 = rnd.Next(0, 99);
                int nb3 = rnd.Next(0, 99);
                int nb4 = rnd.Next(0, 99);
                int nb5 = rnd.Next(0, 99);

                //Positions of my numbers on array
                integers[0] = nb1;
                integers[1] = nb2;
                integers[2] = nb3;
                integers[3] = nb4;
                integers[4] = nb5;

                //Text which will be displeyed on Int Array Textbox 
                txtInt.Text = $"{nb1} - {nb2} - {nb3} - {nb4} - {nb5}";
            }
            catch
            {
               
            }
        }

        private void BtnGenerateDouble_Click(object sender, EventArgs e)
        {
            //Generating a double random number from 0-99
            Random rnd = new Random();
            double minimum = 0;
            double maximum = 99;

            //Using the Math Round function to narrow the decimal places to 1
            double nb1 = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);
            double nb2 = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);
            double nb3 = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);
            double nb4 = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);
            double nb5 = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);

            ////Positions of my doubles on array
            doubles[0] = nb1;
            doubles[1] = nb2;
            doubles[2] = nb3;
            doubles[3] = nb4;
            doubles[4] = nb5;

            //Text which will be displeyed on Double Array Textbox 
            txtDouble.Text = $"{nb1} - {nb2} - {nb3} - {nb4} - {nb5}";
        }

        //Generic method Search, using IComparable<T>
        private int Search<T>(T value, T[] list) where T : IComparable<T>
        {
            //Variable to save the index
            int index = 0;

            //Traversing items in the list
            foreach (var item in list)
            {
                //Comparing the Search key to the elements in the array
                int found = value.CompareTo(item);

                if (found == 0)
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }
            //If the search key is not found
            return -1;
        }

        //Action performed by clicking on Integer Input Key Search button
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIntKey.Text == "")
                {
                    MessageBox.Show("Enter a integer to search.");
                }
                else
                {
                    int value = int.Parse(txtIntKey.Text);
                    int outputInt = Search<int>(value, integers);

                    if (outputInt == -1)
                    {
                        output.Text = "Not found";
                    }
                    else
                    {
                        output.Text = $"Number {value} found at index {outputInt}";
                    }
                }
                
            }
            catch
            {

            }
            
        }

        private void BtnDoubleSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtDoubleKey.Text == "")
                {
                    MessageBox.Show("Enter a double to search.");
                }
                else
                {
                    double value = double.Parse(txtDoubleKey.Text);

                    double outputDouble = Search<double>(value, doubles);

                    if (outputDouble == -1)
                    {
                        output.Text = "Not found.";
                    }
                    else
                    {
                        output.Text = $"Number {value} found at index {outputDouble}";
                    }
                }
                
            }
            catch
            {

            }
            
        }
    }
}
