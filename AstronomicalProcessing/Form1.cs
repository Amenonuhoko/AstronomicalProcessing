// Riza Arianne, Group One, Sprint One
// Date: 20/10/2022
// Version: 1.0
// Astronomical Processing
// An application to record and process values in an array of size 24

using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;

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
                    
                    listBox1.SetSelected(mid, true);
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
        // Sequential Search
        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            int target;
            bool found = false;
            if (!(Int32.TryParse(textBox1.Text, out target)))
            {
                MessageBox.Show("You must enter an integer");
                return;
            }
            for (int x = 0; x < arraySize; x++)
            {
                if (dataArray[x] == target)
                {
                    listBox1.SetSelected(x, true);
                    MessageBox.Show(" Found at index " + (x + 1));
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
            }
            if (!found)
            {
                MessageBox.Show("Not Found, try again.");
                textBox1.Clear();
                textBox1.Focus();
            }
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


        // Math Buttons
        // Mid-Extreme
        private void btnMidExtreme_Click(object sender, EventArgs e)
        {
            if (sorted)
            {
                int lowestValue = dataArray[0];
                int highestValue = dataArray[dataArray.Length - 1];
                int midValue = (lowestValue + highestValue) / 2;

                textBoxDisplay.Clear();
                textBoxDisplay.Text = midValue.ToString();
            }

        }
        // Mode
        private void btnMode_Click(object sender, EventArgs e)
        {
            int count = 0;
            int maxCount = 0;
            int maxValue = 0;
            int item = 0;

            for (int i = 0; i < dataArray.Length; i++)
            {
                item = dataArray[i];
                maxCount = 0;

                for (int j = 0; j < dataArray.Length; j++)
                {
                    if (dataArray[j] == item)
                    {
                        maxCount++;
                    }
                }
                if (maxCount > maxValue)
                {
                    count = item;
                    maxValue = maxCount;
                }

            }
            textBoxDisplay.Clear();
            textBoxDisplay.Text = count.ToString() + ":  " + maxValue + "times";
        }
        // Average
        private void btnAverage_Click(object sender, EventArgs e)
        {
            int average = 0;

            for (int i = 0; i < dataArray.Length; i++)
            {
                average += dataArray[i];
            }

            average = average / dataArray.Length;

            textBoxDisplay.Text = average.ToString();
        }
        // Range
        private void btnRange_Click(object sender, EventArgs e)
        {

            if(sorted)
            {
                int range = dataArray[dataArray.Length - 1] - dataArray[0];

                textBoxDisplay.Text = range.ToString();
            }
            else
            {
                MessageBox.Show("Please Sort First");
            }
        }


        #endregion

        
    }
}