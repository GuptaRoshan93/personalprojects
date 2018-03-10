using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;/*used for input output file operations*/
using System.Net.Mail;/*Used for email validation*/

namespace Assignment_4
{
    public partial class Invest : Form
    {
        /*Declaring global variable as string for calculation purpose*/
        private string ClientInfo, FirstName, LastName, EmailAddress, Term, FinalBalance, Temp, RateofIntrest, search;

        /*Declared Constant value which wont change in entire programme*/
        private const double Bonus = 5000, OneMonth = 1, ThreeMonth = 3, SixMonth = 6, TwelveMonth = 12;
        private double Month1, Month3, Month6, Month12, TransactionID, Balance, Intrest, IntrestRate, amount, amountBonus6, amountBonus12;
        private const double IntrestRate1 = 0.005, IntrestRate3 = 0.00625, IntrestRate6 = 0.007125, IntrestRate12 = 0.011250;

        /*Assigning values to global variable for calculating compund intrest*/
        private const double DiffIntrestRate1 = 0.006, DiffIntrestRate3 = 0.007250, DiffIntrestRate6 = 0.0081250, DiffIntrestRate12 = 0.012250;
        private decimal TelephoneNumber; /*Declared global variables as decimal data type*/


        private void radioButtonTransactionId_CheckedChanged(object sender, EventArgs e)
        {
            buttonFinalSearch.Enabled = true;
            buttonClear.Enabled = true;
            textBoxSearch.Enabled = true;

        }

        private void radioButtonEmailId_CheckedChanged(object sender, EventArgs e)
        {
            buttonFinalSearch.Enabled = true;
            buttonClear.Enabled = true;
            textBoxSearch.Enabled = true;
        }
        /*Event handler for search Exit button*/
        private void buttonSearchExit_Click(object sender, EventArgs e)
        {
            groupBoxSearchDetails.Visible = false; /*Groupbox will not be visible*/
            panelSearch.Visible = true;
            groupBoxInvest.Visible = true;
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }
        /*Event handler for special functions button to view search and summary functionality*/
        private void buttonSpecialFunctions_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true; /*Panel will be visible*/
            textBoxInputAmount.Clear();
        }

        private void groupBoxSearchDetails_Enter(object sender, EventArgs e)
        {

        }
        /*Event handler for CloseSummary button to close the summary */
        private void buttonCloseSummary_Click(object sender, EventArgs e)
        {

            groupBoxInvest.Visible = true;
            panelSearch.Visible = true;
            groupBoxSummary.Visible = false;
        }
        /*Event handler to close the the entire apllication*/
        private void buttonApplicationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*Event handler to clear details in groupBoxSearchDetails */
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            listBoxDetails.Items.Clear();
            textBoxSearch.Enabled = true; /*Textbox will be enable*/
            textBoxSearch.Focus();
        }
        /*Event handler to display search functionality*/
        private void buttonAdditonalSearchOption_Click(object sender, EventArgs e)
        {
            groupBoxSearchDetails.Visible = true;
            groupBoxInvest.Visible = true;
            panelSearch.Visible = true; /*Groupbox will be visible*/
            groupBoxIntrestRate.Visible = false;
            groupBoxSummary.Visible = false;
            buttonFinalSearch.Enabled = false;
            buttonClear.Enabled = false;
            textBoxSearch.Enabled = false; /*Textbox will be disabled*/


        }
        /*Created a function to search a transaction Id*/
        private void TransactionId(String search) /* Passed arugument search as string data type in function TransactionId*/
        {
            Boolean got = false; /*Declaring variable as boolean datatype for unique transactionId  */
            StreamReader inputFile; /*Declaring a variable inputFile to reference a StreamReader object*/

            inputFile = File.OpenText(@"C: \Users\Rajit\source\repos\Assignment 4\Assignment 4\bin\Debug\TransactionDetails.txt");
            /*Read an entire file content and process the items with boolean values set to false*/
            while (!inputFile.EndOfStream && got == false)
            {
                /*Statement to handle exception and prevent the programme from crashing*/
                try
                {
                    /*Read the first line and store it in variable of string datatype*/
                    String Check = inputFile.ReadLine();

                    if (Check == search)/*Comparing the stored variable with user input */
                    {
                        listBoxDetails.Items.Add(Check);/*Adding the stored variable to listbox*/

                        for (int i = 0; i < 8; i++) /*Reading rest of the line*/
                        {

                            listBoxDetails.Items.Add(inputFile.ReadLine());

                        }
                        got = true;/*Declaring variable as Boolean value*/



                    }
                    else
                    {
                        /*To avoid reading the next lines if match is not found*/
                        for (int j = 0; j < 8; j++)
                        {
                            Check = inputFile.ReadLine();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (got == false)/*Set variable to boolean value to display if no records were found*/
            {
                MessageBox.Show("TransactionId not found,please enter valid search data");
            }
            inputFile.Close();/*Close the file*/
        }
        /*Created a function to search a Email Id*/
        private void SearchEmailId(String search)/*Passed arugument search as string data type in function SearchEmailId*/
        {
            int countsearch = 0;       /*Initializing the counters*/
            StreamReader inputFile;
            /*Open the file in the path and get a StreamReader Object*/
            inputFile = File.OpenText(@"C: \Users\Rajit\source\repos\Assignment 4\Assignment 4\bin\Debug\TransactionDetails.txt");
            while (!inputFile.EndOfStream)
            {
                try
                {
                    String Check1 = inputFile.ReadLine();
                    String Check = inputFile.ReadLine();/*Reading the second line and storing it*/
                    if (Check == search)
                    {
                        countsearch++; /*Incremented the counter when match is found*/
                        listBoxDetails.Items.Add(Check1);
                        listBoxDetails.Items.Add(Check);/*Adding the stored variable to listboxe*/
                        for (int i = 0; i < 7; i++)
                        {

                            listBoxDetails.Items.Add(inputFile.ReadLine());

                        }

                    }
                    else
                    {
                        /*To avoid reading the next lines if match is not found*/
                        for (int k = 0; k < 7; k++)
                        {
                            Check1 = inputFile.ReadLine();
                        }
                    }
                }

                /*Statement will catch any exception thrown by try statement*/

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            /*Checvking if the counter is set to zero to display if no records were found*/
            if (countsearch == 0)
            {
                MessageBox.Show("Email id not found,Please enter valid emailId");
            }
            inputFile.Close();
        }
        /*Created function to validate emaild id entered by the user*/
        private bool ValidationEmailId(String EmailAddress)
        {
            try
            {
                MailAddress emailver = new MailAddress(EmailAddress);
                return true;
            }
            catch (Exception)
            {
                groupBoxDetails.Visible = true;
                groupBoxFullClientDetails.Visible = false;
                MessageBox.Show("Please enter valid email address");
                return false;
            }
        }
        /*Event handler for Final search to display the records of transaction Id and emailId*/
        private void buttonFinalSearch_Click(object sender, EventArgs e)
        {
            /*Statement to handle exception and prevent the programme from crashing*/
            try
            {
                /*If radio button is selected by the user and value is set to true*/
                if (radioButtonTransactionId.Checked)
                {
                    search = textBoxSearch.Text;
                    TransactionId(search); /*calling the function and passing an argument as search*/
                    textBoxSearch.Enabled = false;

                }
                if (radioButtonEmailId.Checked)
                {
                    search = textBoxSearch.Text;
                    SearchEmailId(search);/*calling the function and passing an argument as search*/
                    textBoxSearch.Enabled = false;

                }

            }
            /*Statement will catch any exception thrown by try statement*/
            catch (Exception)
            {

                MessageBox.Show("Enter a valid search ");
            }





        }
        /*Event handler to close the entire application*/
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {

        }

        /*Event handler for radio button to store value in string*/
        private void radioButton3Months_CheckedChanged(object sender, EventArgs e)
        {
            /*If radio button is selected by the user and value is set to true*/
            if (radioButton3Months.Checked)
            {
                /*Storing the string value of radio button into variable Clientinfo*/
                ClientInfo = radioButton3Months.Text;
                buttonProceed.Enabled = true;
            }
        }

        private void groupBoxIntrestRate_Enter(object sender, EventArgs e)
        {

        }
        /*Event handler for radio button to store value in string*/
        private void radioButton6Months_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6Months.Checked)
            {
                ClientInfo = radioButton6Months.Text;
                buttonProceed.Enabled = true;/*Enabled the button*/
            }
        }
        /*Event handler for radio button to store value in string*/
        private void radioButton12Months_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12Months.Checked)
            {
                ClientInfo = radioButton12Months.Text;
                buttonProceed.Enabled = true;

            }
        }
        /*Event handler for final confirm button to store the trasnaction details in a text file*/
        private void buttonFinalConfirm_Click(object sender, EventArgs e)
        {
            /*Confirmation message displayed after transaction done successfully*/
            MessageBox.Show("Transaction Done successfully");

            try
            {  /*Create a new file if there are no files of same name after checking the condition*/
                if (!File.Exists("TransactionDetails.txt"))
                {
                    /*Declared a variable to reference StreamWriter object*/
                    StreamWriter outputFile;
                    /*Open the files in the path and get a StreamWriter object*/
                    outputFile = File.CreateText(@"C: \Users\Rajit\source\repos\Assignment 4\Assignment 4\bin\Debug\TransactionDetails.txt");
                    /*Write the firstline with the values passed of labelTransactionId*/
                    outputFile.WriteLine(labelTransactionId.Text);
                    outputFile.WriteLine(labelEmailAddress.Text);
                    outputFile.WriteLine(labelFirstName.Text);
                    outputFile.WriteLine(labelLastName.Text);
                    outputFile.WriteLine(labelTelephoneNumber.Text);
                    outputFile.WriteLine(labelPrinipalAmount.Text);
                    outputFile.WriteLine(labelTermChoosen.Text);
                    outputFile.WriteLine(labelIntrestRate.Text);
                    outputFile.WriteLine(labelBalanceAmt.Text);
                    outputFile.Close();/*Close the file*/
                }
                else
                { /*If file already exist ,data will be appended*/
                    StreamWriter outputFile;
                    outputFile = File.AppendText(@"C: \Users\Rajit\source\repos\Assignment 4\Assignment 4\bin\Debug\TransactionDetails.txt");
                    outputFile.WriteLine(labelTransactionId.Text);
                    outputFile.WriteLine(labelEmailAddress.Text);
                    outputFile.WriteLine(labelFirstName.Text);
                    outputFile.WriteLine(labelLastName.Text);
                    outputFile.WriteLine(labelTelephoneNumber.Text);
                    outputFile.WriteLine(labelPrinipalAmount.Text);
                    outputFile.WriteLine(labelTermChoosen.Text);
                    outputFile.WriteLine(labelIntrestRate.Text);
                    outputFile.WriteLine(labelBalanceAmt.Text);
                    outputFile.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            panelSearch.Visible = false;/*panel will not be visble*/
        }
        /*Event handler for summary button to view summary report*/
        private void buttonSummary_Click(object sender, EventArgs e)
        {
            int countTerm = 0;/*Initializing the counter*/
            /*Declaring the local variables as double datatype for calculation purpose*/
            double principleamount = 0.00, TotalIntrest, FinalBalanceAmt = 0.00, AvgTerm, TermDuration = 0;
            /*Declaring variable as boolean datatype for unique transactionId  */
            Boolean find = false;
            /*Declaring the local variables as string datatype for calculation purpose*/
            string storing, storing1;
            StreamReader inputFile;
            inputFile = File.OpenText(@"C: \Users\Rajit\source\repos\Assignment 4\Assignment 4\bin\Debug\TransactionDetails.txt");

            while (!inputFile.EndOfStream && find == false)
            {
                storing1 = inputFile.ReadLine();
                Temp = storing1;
                
                listTransactionListbox.Items.Add(Temp);


                for (int i = 0; i <= 7; i++)
                {

                    storing = inputFile.ReadLine();/*Read the line and store into different string */

                    /*Checking the position of lines as per file written earlier,reading principle amount and storing it in different variable*/
                    if (i == 4)
                    {
                        principleamount = principleamount + double.Parse(storing);

                    }
                    /*Checking the position of lines as per file written earlier,reading term and storing it in different variable */
                    else if (i == 5)
                    {

                        TermDuration = TermDuration + double.Parse(storing);
                        countTerm++; /*Incremented the counter to count the Number of time term has been read*/
                    }
                    /*Checking the position of lines as per file written earlier,reading FinalBalancAmt and storing it in different variable */
                    else if (i == 7)
                    {
                        
                        FinalBalanceAmt = FinalBalanceAmt + double.Parse(storing);

                    }


                }

            }

            groupBoxSummary.Visible = true;
            panelSearch.Visible = true;
            groupBoxSearchDetails.Visible = false;

            labelTotalPrincipalAmount.Text = principleamount.ToString("c");
            /*Calculation of total intrest till now by subtracting final amount obtained and principle amount*/
            TotalIntrest = (FinalBalanceAmt - principleamount);
            labelTotalIntrest.Text = TotalIntrest.ToString("c2");
            /*calculating average term by dividing the term duration and number of time term has been read */
            AvgTerm = (TermDuration / countTerm);
            /*Storing the variable in label*/
            labelAverageTerm.Text = AvgTerm.ToString();

        }
        /*Event handler for cancel button to clear all the fields*/
        private void buttonCancel_Click(object sender, EventArgs e)
        {

            groupBoxFullClientDetails.Visible = false;
            groupBoxInvest.Visible = true;
            groupBoxIntrestRate.Visible = false;
            groupBoxDetails.Visible = false;
            panelSearch.Visible = true;
            /*Clear the textbox*/
            textBoxInputAmount.Clear();
            /*Clear the radiobutton selected radio button*/
            radioButton1Month.Checked = false;
            radioButton3Months.Checked = false;
            radioButton6Months.Checked = false;
            radioButton12Months.Checked = false;
            /*Clear the radio button text field */
            radioButton1Month.Text = "";
            radioButton3Months.Text = "";
            radioButton6Months.Text = "";
            radioButton12Months.Text = "";
            textBoxTransactionId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxTelephoneNumber.Clear();
            textBoxEmailAddress.Clear();
            /*cursor will be set to textbox to get input*/
            textBoxInputAmount.Focus();
        }

        /*Event handler for confirm button to store the input values into variables and display them*/
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*Statement to handle exception and prevent the programme from crashing*/
            try
            {
                /*Converting string datatype in double datatype and storing it in variable */
                TransactionID = double.Parse(textBoxTransactionId.Text);
                /*storing the value of textboxes in variable od string datatype*/
                FirstName = textBoxFirstName.Text;
                LastName = textBoxLastName.Text;
                /*Converting string datatype in decimal datatypeand storing it in variable*/
                TelephoneNumber = decimal.Parse(textBoxTelephoneNumber.Text);
                EmailAddress = textBoxEmailAddress.Text;
                /*Validating all the input values so that user enter valid values at every time*/
                if ((System.Text.RegularExpressions.Regex.IsMatch((textBoxFirstName.Text), @"^[a-zA-Z]+$")) && (System.Text.RegularExpressions.Regex.IsMatch((textBoxLastName.Text), @"^[a-zA-Z]+$")) && (System.Text.RegularExpressions.Regex.IsMatch((textBoxTelephoneNumber.Text), @"^[0-9]+$")) && (ValidationEmailId(EmailAddress)))
                {
                    /*Storing the value in labels*/
                    labelFirstName.Text = FirstName;
                    labelLastName.Text = LastName;
                    labelTelephoneNumber.Text = TelephoneNumber.ToString();
                    labelEmailAddress.Text = EmailAddress;
                    labelTransactionId.Text = TransactionID.ToString();

                    groupBoxFullClientDetails.Visible = true;
                    groupBoxIntrestRate.Visible = false;
                    groupBoxDetails.Visible = false;
                    groupBoxInvest.Visible = false;
                    panelSearch.Visible = false;


                    /*Using substring on strings to get the part of the string and then storing in a avariable*/
                    Term = ClientInfo.Substring(4, 2);
                    labelTermChoosen.Text = Term;
                    RateofIntrest = ClientInfo.Substring(30, 8);
                    /*Converting the variable in string data type and storing in labesl*/
                    labelIntrestRate.Text = RateofIntrest.ToString();
                    FinalBalance = ClientInfo.Substring(ClientInfo.IndexOf("=") + 2);
                    labelBalanceAmt.Text = FinalBalance;
                    labelPrinipalAmount.Text = amount.ToString();
                    MessageBox.Show("Press confirm Button for final confirmation else press cancel");
                }
                else
                {
                    groupBoxDetails.Visible = true;
                    groupBoxFullClientDetails.Visible = false;
                    MessageBox.Show("Please enter alphabets for names");


                }
            }
            /*Statement will catch any exception thrown by try statement*/
            catch (Exception)
            {
                MessageBox.Show("Enter all valid values");
            }


        }


        private void textBoxClientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxFullClientDetails_Enter(object sender, EventArgs e)
        {

        }



        private void groupBoxDetails_Enter(object sender, EventArgs e)
        {

        }
        /*Event handler for proceed button */
        private void buttonProceed_Click(object sender, EventArgs e)
        {
            groupBoxDetails.Visible = true;
            panelSearch.Visible = false;
        }


        /*Event handler for radio button to store value in string*/
        private void radioButton1Month_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1Month.Checked)
            {

                ClientInfo = radioButton1Month.Text;
                buttonProceed.Enabled = true;

            }


        }


        public Invest()
        {
            InitializeComponent();
        }
        /*Event handler for initial form*/
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxIntrestRate.Visible = false;
            groupBoxDetails.Visible = false;
            groupBoxFullClientDetails.Visible = false;
            panelSearch.Visible = true;
            groupBoxSearchDetails.Visible = false;
            groupBoxSummary.Visible = false;
            groupBoxInvest.Visible = true;
            textBoxInputAmount.Focus(); /*cursor will be set to textbox to get input*/
        }
        /*Created function for calculating compund intrest and passed different arguments with return value*/
        private double IntrestCalculation(double IntrestRate, double amount, double Month)
        {
            /*calculate the compund intrest and return the final value obtained */
            Balance = amount * (Math.Pow(1 + (IntrestRate / 12), (Month)));
            return Balance;
        }



        /*Event handler to display all the options after entering the amount*/
        private void buttonDisplayOption_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                    /*converting the input value of string datatype into double datatype and storing it*/
                    amount = double.Parse(textBoxInputAmount.Text);
                    groupBoxIntrestRate.Visible = true;
                    groupBoxDetails.Visible = false;
                    buttonProceed.Enabled = false;
                    panelSearch.Visible = false;

                    /*If amount entered by the user is less than 100000 then if condition is executed*/
                    if (amount <= 100000)
                    {
                        /*Calling the function with three parameters and storing the return value in variable*/
                        Month1 = IntrestCalculation(IntrestRate1, amount, OneMonth);
                        /*Displaying the text value in radio button*/
                        radioButton1Month.Text = "For 1  Month Term Investing  @0.50000 % Balance= " + Month1.ToString();

                        Month3 = IntrestCalculation(IntrestRate3, amount, ThreeMonth);
                        radioButton3Months.Text = "For 3  Month Term Investing  @0.62500 % Balance= " + Month3.ToString();

                        Month6 = IntrestCalculation(IntrestRate6, amount, SixMonth);
                        radioButton6Months.Text = "For 6  Month Term Investing  @0.71250 % Balance= " + Month6.ToString();

                        Month12 = IntrestCalculation(IntrestRate12, amount, TwelveMonth);
                        radioButton12Months.Text = "For 12  Month Term Investing @1.12500 % Balance= " + Month12.ToString();



                    }



                    else
                    {
                        /*If amount entered by the user is grater than 100000 then this condition is executed*/
                        if (amount >= 100000)
                        {
                            Month1 = IntrestCalculation(DiffIntrestRate1, amount, OneMonth);
                            radioButton1Month.Text = "For 1  Month Term Investing  @0.60000 % Balance= " + Month1.ToString();

                            Month3 = IntrestCalculation(DiffIntrestRate3, amount, ThreeMonth);
                            radioButton3Months.Text = "For 3  Month Term Investing  @0.72500 % Balance= " + Month3.ToString();



                            /*If amount entered by the user is grater than 1000000 then this condition is executed*/
                            if (amount > 1000000)
                            {

                                Month6 = IntrestCalculation(DiffIntrestRate6, amount, SixMonth);
                                amountBonus6 = (Month6 + Bonus);
                                Month12 = IntrestCalculation(DiffIntrestRate12, amount, TwelveMonth);
                                amountBonus12 = (Month12 + Bonus);

                            /*currency formatting*/
                                radioButton6Months.Text = "For 6  Month Term Investing  @0.81250 % Balance= " + amountBonus6.ToString();

                                radioButton12Months.Text = "For 12  Month Term Investing @1.22500 % Balance= " + amountBonus12.ToString();



                            }

                            else
                            {
                                Month6 = IntrestCalculation(DiffIntrestRate6, amount, SixMonth);
                                radioButton6Months.Text = "For 6  Month Term Investing  @0.81250 % Balance= " + Month6.ToString();
                                Month12 = IntrestCalculation(DiffIntrestRate12, amount, TwelveMonth);
                                radioButton12Months.Text = "For 12  Month Term Investing @1.22500 % Balance= " + Month12.ToString();



                            }

                        }
                    }
                

                
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the valid amount");
            }
        }








    }  

}

