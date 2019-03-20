using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raquel_Nunes_Lab03_Ex1
{
    // Delegate for functions IsEven and IsOdd that receives an int and returns a bool
    public delegate bool IsEven(int number);
    public delegate bool IsOdd(int number);   
    
    public partial class Form1 : Form 
    {
        //Declaring and initializing an array of integers with 10 elements
        int[] integers = new int[10];
        double[] doubles = new double[10];
        Char[] chars = new Char[10];

        //Using a list to add up integers, doubles and chars
        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();
        List<char> charList = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input
                int number = int.Parse(txtGetFactorial.Text);

                if (number > 20)
                {
                    MessageBox.Show("Choose a integer number less than or equal to 20 to calculate the Factorial.");
                }
                else
                {
                    // Task to perform Factorial calculation in a separate thread
                    Task<long> factorialTask = Task.Run(() => Factorial(number));

                    // Wait for Task in separate thread to complete
                    await factorialTask;

                    // Display result after Task in separate thread completes
                    label7.Text = factorialTask.Result.ToString();
                }
            }
            catch (Exception ex)
            {
                if(ex is ArgumentException)
                {
                    throw ex;
                }
                if (ex is ArgumentNullException)
                {
                    throw ex;
                }                
            }            
        }
        //Writing recursive version of Factorial
        public long Factorial(long num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num -1);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user's input
                int num = Convert.ToInt32(txtInputNumber.Text);

                // Determine whether an int is even
                IsEven isEven = number => number % 2 == 0;

                // Determine whether an int is odd
                IsOdd isOdd = number => number % 2 == 1;

                if (isEven(num))
                {
                    lblTorF.Text = "Even.";
                }
                else
                {
                    lblTorF.Text = "Odd.";
                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnGenerateValues_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                listBox1.Items.Clear();

                //Generating an integer, double and Char random number from 10-99
                for (int i = 0; i < 10; i++)
                {
                    int intNumber = rnd.Next(10, 99);
                    double minimum = 10;
                    double maximum = 99;
                    char charElement = Convert.ToChar(rnd.Next(10, 99));

                    //Using the Math Round function to narrow the decimal places to 1
                    double doubleNumber = Math.Round(rnd.NextDouble() * (maximum - minimum) + minimum, 1);
                    
                    if (radioButton1.Checked == true)
                    {
                        integers[i] = intNumber;
                        intList.Add(intNumber);
                        listBox1.Items.Add(intNumber);                        
                    }
                    if (radioButton2.Checked == true)
                    {
                        doubles[i] = doubleNumber;
                        doubleList.Add(doubleNumber);
                        listBox1.Items.Add(doubleNumber);
                    }
                    if (radioButton3.Checked == true)
                    {
                        chars[i] = charElement;
                        charList.Add(charElement);
                        listBox1.Items.Add(charElement);
                    }                    
                }
                
            }
            catch (Exception)
            {
              
            }
           
        }
        

        //Exercise 1(d - ii)
        public bool SearchData<T>(List<T> list, T value) where T: IComparable
        {
            if (listBox1 == null)
            {
                return false;
            }

            foreach (var item in list)
            {
                if (value.CompareTo(item) == 0)
                {
                    //  MessageBox.Show(item.ToString());
                    return true;
                }

            }
            return false;
        }
        //Exercise 1(d - ii)
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtValueSearch.Text == null || txtValueSearch.Text == "")
                {
                    MessageBox.Show("Type a value before searching. ");
                }
                if (radioButton1.Checked == true)
                {
                    bool returnElement = SearchData<int>(intList, Int32.Parse(txtValueSearch.Text));
                    MessageBox.Show(returnElement.ToString());
                }
                if (radioButton2.Checked == true)
                {
                    bool returnElement = SearchData<double>(doubleList, double.Parse(txtValueSearch.Text));
                    MessageBox.Show(returnElement.ToString());
                }
                if (radioButton3.Checked == true)
                {
                    bool returnElement = SearchData<char>(charList, txtValueSearch.Text[0]);
                    MessageBox.Show(returnElement.ToString());
                }
            }
            catch (Exception)
            {
                
            }
            
        }

        //Exercise 1(d - iii)
        public List<T> PrintData<T>(List<T> list, int low, int high) where T : IComparable
        {
            List<T> newList = list.Skip(low).Take(high - low + 1).ToList();

            return newList;
        }
        //Exercise 1(d - iii)
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                if (txtLowIndex.Text == null || txtHighIndex.Text == "" || txtHighIndex.Text == null || txtHighIndex.Text == "")
                {
                    MessageBox.Show("Fill low and high index fields from 0 to 9.");
                }

                if (radioButton1.Checked == true)
                {
                    List<int> newList = PrintData<int>(intList, int.Parse(txtLowIndex.Text), int.Parse(txtHighIndex.Text));
                    foreach (var item in newList)
                    {
                        listBox2.Items.Add(item);
                    }
                }
                if (radioButton2.Checked == true)
                {
                    List<double> newList = PrintData<double>(doubleList, int.Parse(txtLowIndex.Text), int.Parse(txtHighIndex.Text));
                    foreach (var item in newList)
                    {
                        listBox2.Items.Add(item);
                    }
                }
                if (radioButton3.Checked == true)
                {
                    List<char> newList = PrintData<char>(charList, int.Parse(txtLowIndex.Text), int.Parse(txtHighIndex.Text));
                    foreach (var item in newList)
                    {
                        listBox2.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {

            }            

        }
    }
}
