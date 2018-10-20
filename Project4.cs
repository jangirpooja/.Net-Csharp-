/************************************************************

   CSCI 680-00V3 Assignment 4      Spring 2018                                             
                                                          
   Programmers: Pooja Jangir (Z1831882)
                Raghavendra Pavan Kumar Veeramraju ( Z1831902)

   Date Due:   03/28/2018                                                            


 ***********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   //Initialises the componenets in the form
        }
        /**********************************************************************************
               function name  : button1_Click
               Purpose        : button wwhich takes user entered value as input and adds as a point to the chart
               Parameters     : sender, e

        **********************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
                if (!(String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))) //checks if the textbox is empty
                {
                double input;
                input = Convert.ToDouble(textBox1.Text);
                this.chart1.Series["Series1"].Points.AddY(input);   //Adds the input to the chart
                }
                else
                {
                 MessageBox.Show("No value entered: Please enter the value");
                }
        }
        /**********************************************************************************
               function name  : button3_Click
               Purpose        : button 
               Parameters     : sender, e         

        **********************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (double value in list)                          //each value is added
            {
                this.chart1.Series["Series1"].Points.AddY(value);   //Takes values from the list and displays on the chart
            }
            list.Clear();
        }
        /**********************************************************************************
         function name : button3_Click
         Purpose       : button which uses random class to generate random points in a range 0 to 30
                      and add it to the chart
         Parameters :  sender, e

        **********************************************************************************/
        private void button3_Click(object sender, EventArgs e)
        {
            Random number; double point;
            number = new Random();
            point = number.NextDouble() * (30.0 - 0.0) + 0.0;      // generates random numbers from 0 to 30 using the Next function from the random class
            this.chart1.Series["Series1"].Points.AddY(point);      // adds value to the chart
        }

        /**********************************************************************************
         Function name  : button4_Click
         Purpose        : button which provides user an option to choose file and adds the selected file to points and to the chart
         Parameters :  sender, e

        **********************************************************************************/
        List<double> list = new List<double>();
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();      //OpenFileDialog instance is created   
            open.InitialDirectory = ".";                     // Initial directory is set as .
            open.Title = "Browse Text Files";
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)         // if given path exists and verified
            {
                list.Clear();   
                string FileName;
                FileName = open.FileName;
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(FileName.ToString()); //reads input from the text file
                while ((line = file.ReadLine()) != null)
                {
                    list.Add(double.Parse(line)); //adds the input file to the list
                }
            }
                /*foreach (double s in list)
                    {
                        this.chart1.Series["Series1"].Points.AddY(s);
                    } */
           
        }
        /**********************************************************************************
         function   : closeButton_Click
         Use        : button which is used to exit the application

         Parameters :  sender, e

        **********************************************************************************/
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        /**********************************************************************************
         Function name : clearButton_Click
         Purpose       : button clears the points of the chart
         Parameters    : sender, e

        **********************************************************************************/
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].Points.Clear();
        }
              
        /**********************************************************************************
         Function    : textBox1_TextChanged
         Purpose     : event when ever incorrect format of string is put into the textbox
         Parameters  : sender, e

        **********************************************************************************/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double userInput;
            if (!double.TryParse(textBox1.Text, out userInput))    //checks if the user entered input is correct
            {
                MessageBox.Show("Incorrect format: Please enter a double value");
                return;
            }
        }

        /**********************************************************************************
        Form is loaded with three default points on the chart
        **********************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            /*this.chart1.Series["Series1"].Points.AddY(10);
            this.chart1.Series["Series1"].Points.AddY(20);
            this.chart1.Series["Series1"].Points.AddY(30);*/
        }

        /**********************************************************************************
              Function      : radiobutton1_checkedchanged
              Purpose       : radio button to change the chart to column type
              Parameters    : sender, e

        **********************************************************************************/

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; 
        }

        /**********************************************************************************
              Function      : radiobutton2_checkedchanged
              Purpose       : radio button to change the chart to pie type
              Parameters    : sender, e

        **********************************************************************************/
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          this.chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        /**********************************************************************************
              Function      : radiobutton3_checkedchanged
              Purpose       : radio button to change the chart to bar type
              Parameters    : sender, e

        **********************************************************************************/
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          this.chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        /**********************************************************************************
              Function      : radiobutton4_checkedchanged
              Purpose       : radio button to change the chart to bubble type
              Parameters    : sender, e

        **********************************************************************************/
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
        }
}

