using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assign2
{

    /*******************************************************************************
        Class      : Form1
        Use        : This method calls constructor form1 to initialize the component
       
    **********************************************************************************/
    public partial class Form1 : Form
    {
        public static List<Person> list = new List<Person>();               
        public static int InUse = 0;                         // declaring int vriable and variable of class type
        public Form1()
        {
            InitializeComponent();                          // component is initialized

        }

        public void printList()                             //function prints the list of the entrees from the text file
        {
            this.Controls.Add(RESULTS);                        //the list is passed to the list box
            RESULTS.MultiColumn = true;
            RESULTS.SelectionMode = SelectionMode.MultiExtended;
            RESULTS.BeginUpdate();
            RESULTS.Items.Add("Name                            OfficeNumber                    TelephoneNumber");
            RESULTS.Items.Add("----------------------------------------------------------------------------------------------");
            foreach (var a in list)
            {

                RESULTS.Items.Add(a.PersonName.PadRight(15) + " " + a.OfficeNumber.PadRight(15) + " " + a.TelephoneNumber + "\n");
            }
            RESULTS.Items.Add("----------------------------------------------------------------------------------------------");
            RESULTS.EndUpdate();
        }

        public static void display()                                            // this function is used to read the input file
        {
            string inputFile = "data1.txt"; string temp = "";
            if (System.IO.File.Exists(inputFile) == true)
            {
                string L1 = temp; string L2 = temp;
                string L3 = temp;
                System.IO.StreamReader s = new System.IO.StreamReader(inputFile);                 
                L1 = s.ReadLine(); L2 = s.ReadLine(); L3 = s.ReadLine();
                Person p;
                p = new Person(L1, L2, L3);
                list.Add(p);
                InUse = InUse + 1;
                while ((L1 = s.ReadLine()) != null)                          //input file is read untill null value is reached
                {
                    L2 = s.ReadLine(); L3 = s.ReadLine();                    // the input values are read into three different strings
                    p = new Person(L1, L2, L3);
                    list.Add(p);
                    InUse = InUse + 1;
                }
                s.Close();
            }
            else
            {
                Console.WriteLine("File could not be opened");              // if the file does not open the error message is displayed
            }
        }
        public int addEntry()                                              // function to allow the user to add or enter values
        {
            string text1 = this.t1.Text;
            string text2 = this.t2.Text;
            string text3 = this.t3.Text;
            if ((string.IsNullOrEmpty(text1)) || (string.IsNullOrEmpty(text2)) || (string.IsNullOrEmpty(text3)))
            {
                RESULTS.Items.Add(" Textbox cannot be blank");                // if the textbox is left blank, then error message is displayed
                return 0;
            }
                string name = text1;
                foreach (var a in list)
                {
                    if (a.PersonName == null)
                    break;
                    string comp1 = name.ToLower();
                    string comp2 = a.PersonName.ToLower();
                    int comp = String.Compare(comp1, comp2);                // compares the entered text with the existing values
                    if (comp == 0)
                    {
                        this.t1.Clear();
                        RESULTS.Items.Add("Person exists");
                        return 1;
                    }

                }
                string office = text2; string telephone = text3;             //if value doesn't exist, adds to the field
                Person p = new Person(name, office, telephone);
                list.Add(p);
                RESULTS.Items.Add("Name added to the list");
                return 1;
            }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void searchName()                                               // searches name in the list
        {
            String name;
            int i = 0; int j = 0;
            int total = list.Count;
            Person p = new Person();
            p.PersonName = name = this.t1.Text;
            foreach (var a in list)
            {
                int comp3 = a.CompareTo(p);
                string comp1 = p.PersonName.ToLower();                           
                string comp2 = a.PersonName.ToLower();
                int comp = String.Compare(comp1, comp2);                        // compares entered text with the existing values
                if (comp == 1)
                {
                    RESULTS.Items.Add("Invalid search");
                    this.t1.Clear();
                    j = j + 1;
                    break;
                }
                if (comp3 != 1)                                                // if the data matches, results are shown
                {
                    this.t1.Clear();
                    RESULTS.Items.Add("PersonName     OfficeNumber       TelephoneNumber");
                    RESULTS.Items.Add(a.PersonName.PadRight(35)+ a.OfficeNumber.PadRight(25) + a.TelephoneNumber);
                    break;
                }
            }

            if (i > total || i == total)
            {
                if (j == 0)
                {
                    RESULTS.Items.Add("Invalid search: no such name found");
                }
            }

        }

        public void searchOfficeNumber()
        {
            string text2;                               // This function searches for entered officenumber in the existing list
            text2 = this.t2.Text;
            int i = 0; int j = 0;
            foreach (var a in list)                     // iterates and ompares with all the existing values
            {
                if (a.PersonName == null)
                    break;
                string comp1 = text2.ToLower();
                string comp2 = a.OfficeNumber.ToLower();
                int comp = String.Compare(comp1, comp2);  // compares the existing value with entered value
                if (comp == 0)
                {
                    i = i + 1;
                    this.t2.Clear();                      // if match found, results are displayed
                    RESULTS.Items.Add("PersonName     OfficeNumber       TelephoneNumber");
                    RESULTS.Items.Add(a.PersonName.PadRight(35) + a.OfficeNumber.PadRight(25) + a.TelephoneNumber);
                }

            }
            if (i == 0)
            {
                if (j == 0)                              // if no match found, invalid search message is displayed
                {
                    RESULTS.Items.Add("Invalid search: no such office number found");
                }
            }
        }
        private void Tb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb1_TextChanged(object sender, EventArgs e)
        {

        }
        public void searchTelephoneNumber()                             // this function searches for telephone number entered with exising values
        {
            string text3 = this.t3.Text;
            int i = 0; int j = 0;
            foreach (var a in list)
            {
                if (a.PersonName == null)
                    break;
                string comp1 = text3.ToLower();
                string comp2 = a.TelephoneNumber.ToLower();
                int comp = String.Compare(comp1, comp2);             //compares entered text with existing values
                if (comp == 0)
                {
                    i = i + 1;                                        //if comparision is true, results are displayed
                    this.t3.Clear();
                    RESULTS.Items.Add("PersonName     OfficeNumber       TelephoneNumber");
                    RESULTS.Items.Add(a.PersonName.PadRight(35) + a.OfficeNumber.PadRight(25) + a.TelephoneNumber);
                }

            }


            if (i == 0 && j == 0)
                RESULTS.Items.Add("Invalid search: TelephoneNumber not found");
        }
        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        /**************************************************************************
         * This Method updates the existing office number for a person
         *************************************************************************/
        public void updateOfficeNumber()                                         
        {

            string text1, text2; int i = 0; int j = 0;
            text1 = this.t1.Text;
            text2 = this.t2.Text;
            int total = list.Count;
            string temp = "";
            int comp = String.Compare(text2, temp);                          //compares the entered text with the existing values
            Person p = new Person();
            p.PersonName = text1;
            string initial = p.PersonName;
            if (comp == 0)
            {
                j = j + 1;
                RESULTS.Items.Add("Invalid entry: cannot update");             //if no match, error message is diaplyed
            }
            foreach (var a in list) // checks for each and every value in the list
            {
                string entry = a.PersonName;
                if (initial != entry)
                {
                    i = i + 1;
                }
                int k = a.CompareTo(p);
                if (k == 0 && k != 1)
                {
                    a.OfficeNumber = text2;
                    RESULTS.Items.Add("Office number updated as requested");      //if match is found, value is updated
                    break;
                }

            }
            if (i > total || i == total)
            {
                if (j == 0)
                {
                    RESULTS.Items.Add("Search Invalid !!");
                }
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }
        /************************************************************************************************
        //On clicking the enter button, action performed for the radio buttons
        **************************************************************************************************/
        private void ok_Click(object sender, EventArgs e)
        {

            if (radio1.Checked)
                printList();
            if (radio2.Checked)
                addEntry();
            if (radio3.Checked)
                searchName();
            if (radio4.Checked)
                searchOfficeNumber();
            if (radio5.Checked)
                searchTelephoneNumber();
            if (radio6.Checked)
                updateOfficeNumber();

            if (radio7.Checked)
            {
                list.Sort();
                printList();
                RESULTS.Items.Add("----------------------List Sorted------------------");
            }
            if (radio8.Checked)
                Application.Exit();
}
        /**************************************************************************************
On clicking the cancel button, following actions are performed using clear method to clear the textboxes, and readiobuttons
****************************************************************************************/
        private void cancel_Click(object sender, EventArgs e)
        {
            RESULTS.Items.Clear();
            t1.Text = String.Empty;
            t2.Text = String.Empty;
            t3.Text = String.Empty;

        }
        private void RadioButtons_CheckChanged(object sender, EventArgs e)
        {
            if (radio1.Checked)                                         //clicking on each of the radio buttons, the other text boxes are made not visible
            {
                cancel_Click(sender, e);
                l.Visible = false;
                l1.Visible = false;
                l2.Visible = false;

                t1.Visible = false;
                t2.Visible = false;
                t3.Visible = false;



            }
            if (radio2.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = true;
                l1.Visible = true;
                l2.Visible = true;

                t1.Visible = true;
                t2.Visible = true;
                t3.Visible = true;
            }

            if (radio3.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = true;
                l1.Visible = false;
                l2.Visible = false;

                t1.Visible = true;
                t2.Visible = false;
                t3.Visible = false;
            }
            if (radio5.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = false;
                l1.Visible = false;
                l2.Visible = true;

                t1.Visible = false;
                t2.Visible = false;
                t3.Visible = true;
            }
            if (radio4.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = false;
                l1.Visible = true;
                l2.Visible = false;

                t1.Visible = false;
                t3.Visible = false;
                t2.Visible = true;


            }
            if (radio6.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = true;
                l1.Visible = true;
                l2.Visible = false;

                t1.Visible = true;
                t2.Visible = true;
                t3.Visible = false;

            }
            if (radio7.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = false;
                l1.Visible = false;
                l2.Visible = false;

                t1.Visible = false;
                t3.Visible = false;
                t2.Visible = false;


            }
            if (radio8.Checked)
            {
                cancel_Click(sender, e);
                l.Visible = false;
                l1.Visible = false;
                l2.Visible = false;

                t1.Visible = false;
                t2.Visible = false;
                t3.Visible = false;


            }

        }

        private void lBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    public class Person : IComparable
    {
        private string personName;
        public string officeNumber;
        private string telephoneNumber;

        public Person(string personName, string officeNumber, string telephoneNumber)
        {
            this.personName = personName;
            this.officeNumber = officeNumber;
            this.telephoneNumber = telephoneNumber;
        }

        public Person()
        {

        }

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }

        public string OfficeNumber
        {
            get { return officeNumber; }
            set { officeNumber = value; }
        }



        //Over -riding the CompareTo method

        public int CompareTo(object OBJ)
        {
            Person per = (Person)OBJ;
            int compare = String.Compare(this.PersonName, per.PersonName);
            if(compare > 0)
            {
                return 1;                                                // it returns positive value for greater than OBJ
            }
            else if (compare < 0)
            {
                return -1;                                               // it returns negative value for less than OBJ
            }
            else
            {
                return 0;                                          // it returns zero for equal OBJ
            }
        }
    }
}

