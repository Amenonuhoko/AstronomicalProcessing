// Riza Arianne, Group One, Sprint One
// Date: 20/10/2022
// Version: 1.0
// Astronomical Processing
// An application to record and process values in an array of size 24

using System;
using System.Diagnostics;
using System.Globalization;

namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        // Global Variables
        static int arraySize = 24;
        static int[] dataArray = new int[arraySize];
        static int index = 0;
        static bool sorted = false;

        // Initial
        public Form1()
        {
            InitializeComponent();
            FillArray();
        }

        // Functions
        #region FUNCTIONS
        // Fill array with random numbers
        public void FillArray()
        {

            //
            Random random = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                dataArray[i] = random.Next(10, 99);

            }
            FillListBox();
        }
        // Fill listbox with array
        public void FillListBox()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dataArray.Length; i++)
            {

                listBox1.Items.Add(dataArray[i]);
            }
        }
        #endregion


        // Events
        #region EVENTS
        // Single click event
        private void listBox1_Click(object sender, EventArgs e)
        {

            textBox1.Text = listBox1.SelectedItem.ToString();
            index = listBox1.SelectedIndex;
        }
        #endregion


        // BUTTONS
        #region BUTTONS
        // Binary Search Button
        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a number!");
                Debug.WriteLine(sorted);
                return;
            }
            if (!sorted)
            {
                MessageBox.Show("Please sort first!");
                return;
            }
            int target = Int32.Parse(textBox1.Text);
            int min = 0;
            int max = arraySize - 1;


            while (min <= max) // "<" to check the last one on the left. ~~~ index[0]
            {

                int mid = (min + max) / 2;
                if (dataArray[mid] == target)
                {
                    MessageBox.Show("Number found");
                    return;
                }
                else if (dataArray[mid] >= target)
                {
                    max = mid - 1;


                }
                else
                {
                    min = mid + 1;


                }
            }
            MessageBox.Show("That number does not exist!");

        }

        // Bubble Sort Button
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {

            bool flag = true;
            for (int i = 1; (i <= (arraySize - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (arraySize - 1 - (i - 1)); j++) // - (i-1)  ---> more efficent!!
                {

                    if (dataArray[j + 1] < dataArray[j])
                    {
                        int temp = dataArray[j];
                        dataArray[j] = dataArray[j + 1];
                        dataArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            sorted = true;
            FillListBox();
        }

        // Edit Button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && index != -1)
            {
                dataArray[index] = Int32.Parse(textBox1.Text);
                FillListBox();
            }

        }
        #endregion
    }
}