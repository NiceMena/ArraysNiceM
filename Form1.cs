/*
 * Created by: Nice Mena
 * Created on: November 29th 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - Introduction to Arrays
 * This program calculates the average of numbers in the array
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysNiceM
{
    public partial class frmArrayAverage : Form
    {
        // declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();

            // hide the label
            this.lblAverage.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int randomNum;
            int index;
            Random randomNumberGenerator = new Random();

            // clear list box
            this.lstArrays.Items.Clear();

            for (index = 0; index < MAX_ARRAY_SIZE; index++)
            {
                // generate a random number between 1 and the max
                randomNum = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                //assign the andom number to the cell position at index in the array
                arrayOfNumbers[index] = randomNum;

                //add the random number to the list
                this.lstArrays.Items.Add(randomNum);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local vaiables
            double average = 0;
            double sum = 0;
            int index;

            // calculate the sum of all values in the array
            for (index = 0; index < arrayOfNumbers.Length; index++)
            {
                sum = sum + arrayOfNumbers[index];
            }

            // calculate the average of the values in the array
            average = sum / arrayOfNumbers.Length;

            //display the average in the label
            this.lblAverage.Show();
            this.lblAverage.Text = " The Average is " + average;

        }
    }
}
