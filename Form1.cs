using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AliKuli.RandomNumber;
using CreateScratchCardNumbers.Models;
using AliKuli.MyPrograms;
using System.Diagnostics;

namespace CreateScratchCardNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.lengthOfNumber = 16;
            this.textBoxMaxNumber.Text = Global.MaxNo;
            this.radioButton16.Checked = true;
        } 


        private HashSet<long> scratchList = new HashSet<long>();
        private HashSet<long> oldValuesList = new HashSet<long>();
        private void buttonGetNewName_Click(object sender, EventArgs e)
        {
            this.textBoxFileName.Text = string.Format("GenFile_{0}_{1}", DateTime.Now.ToLongDateString(), DateTime.Now.Ticks);
            this.Text = "File Created: " +this.textBoxFileName.Text; 

        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            long quantity=0;  //This is the number of new scratch numbers required
            long quantityOfOldValues = 0; //These are the old qty of scratch numbers
            long minNumber=0; //This is the min number a scratch number can have
            long maxNumber=0; //This is the max number a scratch number can have
            this.labelProcessing.Text = "";
            this.labelProcessing.Refresh();

            this.labelInfo.Text = string.Empty; //This is where all the results are displayed
            this.labelInfo.Refresh();
            
            
            bool error=false;

            
            //Check to see if the incoming numbers are valid.
            try
            {
                error=IsThereError(this.textBoxQuantity.Text.ToString(), this.textBoxMinNumber.Text.ToString(), this.textBoxMaxNumber.Text.ToString());
            }
            catch(Exception ex)
            {
                error = true;
                this.labelInfo.Text = string.Format("Error: " + ex.Message);
            }


            if(!error)
            {
                HashSet<long> hSet = new HashSet<long>();
                minNumber = long.Parse(this.textBoxMinNumber.Text);
                maxNumber = long.Parse(this.textBoxMaxNumber.Text);
                quantity = long.Parse(this.textBoxQuantity.Text);
                long actualCount = 0; //This counts the value in the loop

                if (quantity > 0)
                {
                    //generate the numbers and keep generating them until you have 5000.
                    //we have to do this set of code using Hset so that we do not get duplicates
                    this.buttonViewFile.Focus();
                    this.buttonGenerate.Enabled = false;
                    long qtyRequired=0;
                    long counter = 0;
                    
                    //We are going to load the old values into the hashset so that we do not get duplicates in the future
                    if (this.checkBoxIncludeExcludeFile.Checked)
                    {
                        string fullPath = Path.Combine(Directory.GetCurrentDirectory(), AliKuli.Constants.excludeFileName);


                        //Read in all the values
                        try
                        {
                            oldValuesList = FileMethods.GetExcludeFileData(fullPath);
                            hSet = FileMethods.GetExcludeFileData(fullPath);
                        }
                        catch
                        {
                            //a small change
                        }
                    }

                    do
                    {
                        ////create the tempScratchList
                        List<long> tempScratchList = new List<long>();


                        //Now old values are loaded into hset. We need to account for these values and remove them from the new set so that there are no difficulties in the future.

                        
                        quantityOfOldValues = hSet.Count();
                        qtyRequired = quantity - quantityOfOldValues;

                        if (qtyRequired > 0)
                        {
                            //Get the random numbers
                            tempScratchList = AliKuli.RandomNumber.ScratchCardNoGenerator.GenerateNumbers(quantity - actualCount, minNumber, maxNumber).ToList();
                        }

                        if (tempScratchList != null)
                        {
                            //move the scratchlist to a hashset to get rid of any duplicates
                            foreach (var item in tempScratchList)
                            {
                                hSet.Add(item);
                                counter++;
                                if (counter % 10 == 0)
                                {
                                    this.labelProcessing.Text = "Processing...  " + (counter).ToString();
                                    this.labelProcessing.Refresh();
                                }


                                if (actualCount > hSet.Count() - 1 - quantityOfOldValues)
                                    break;
                            }
                            //Now count how many non-duplicate scratch numbers have been created.
                            actualCount = qtyRequired-hSet.Count();
                        }

                    } while (actualCount > 0);//check to see if more need to be created.

                }
                //hSet contains old values and new values
                //tempScratchList no longer exists.
                //Get the data from the hSet


                //REMOVE old values, ADD new values to Scratchlist
                string theFile=this.textBoxFileName.Text.ToString()+".txt";

                string thePath = Path.Combine(
                    Directory.GetCurrentDirectory(), theFile);
                

                //test
                //Add an old Exclude value
                //hSet.Add(699291923592);

                try
                {
                    FileMethods.CheckFileName(theFile);
                    if (hSet != null)
                    {

                        //Now remove the old values from the hSet
                        foreach (var item in oldValuesList)
                        {
                           hSet.Remove(item);
                        }
                    
                        //Now all the old values have been removed from the hset

                        long [] theAns = hSet.ToArray();
                        string[] theAnsString = new string [theAns.Count()];
                    
                        for (long i=0;i<theAns.Count();i++)
                        {
                            theAnsString [i]= MyPrograms.PrintNumber.Print( theAns[i]);
                        }

                    
                        File.WriteAllLines(thePath,theAnsString);

                        this.labelProcessing.Text += " (Done! " + theAns.Count().ToString() + ")";
                }
                else
                {
                    File.WriteAllText (thePath,"No Data!");
                }
                }

                catch(Exception ex)
                {
                    this.labelInfo.Text=ex.Message;
                }

                

            }
            //else
            //{
            //    this.labelInfo.Text += "Error!";

            //}

        }

        private bool  IsThereError(string _qty, string _minNum, string _maxNum)
        {
            long quantity=0;
            bool error=false;
            this.labelInfo.Text = string.Empty; ;
            bool qtySuccess = long.TryParse(_qty, out quantity);


            if (!qtySuccess)
            {
                string errorStr = "The number in the Quantity is not valid. Please re-enter it.";
                error=true;
                throw new Exception (errorStr);
                //this.labelInfo.Text += string.Format("{0}{1}", errorStr, Environment.NewLine);

            }



            long minNumber = 0;
            bool minNumberSuccess = long.TryParse(_minNum, out minNumber);

            if (!minNumberSuccess)
            {
                string errorStr = "The 'min number' is not valid. Please re-enter it.";
                error=true;

                throw new Exception (errorStr);
                //this.labelInfo.Text += string.Format("{0}{1}", errorStr, Environment.NewLine);

            }


            long maxNumber = 0;
            bool maxNumberSuccess = long.TryParse(_maxNum, out maxNumber);

            if (!maxNumberSuccess)
            {
                string errorStr = "The 'max number' is not valid. Please re-enter it.";
                error=true;

                throw new Exception (errorStr);
                //this.labelInfo.Text += string.Format("{0}{1}", errorStr, Environment.NewLine);
            }

            bool minNumberSmallerOrEqualToMaxNo = minNumber > maxNumber == false;
            if (!minNumberSmallerOrEqualToMaxNo)
            {
                string errorStr = "The 'min number' is greater than the 'max number.'  This is not a valid state. Please re-enter it.";
                error=true;
                throw new Exception(errorStr);

                //this.labelInfo.Text += string.Format("{0}{1}", errorStr, Environment.NewLine);
            }
            
            try
            {
                AliKuli.MyPrograms.FileMethods.CheckFileName(this.textBoxFileName.Text);
            }
            catch
            {
                error=true;
                throw;
            }
            return error;
        }


        public void EnableDisableGenerateButton(bool error)
        {
            try
            {
                this.buttonGenerate.Enabled = !IsThereError(this.textBoxQuantity.Text.ToString(), this.textBoxMinNumber.Text.ToString(), this.textBoxMaxNumber.Text.ToString());
            }
            catch
            {
                throw;
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {

                EnableDisableGenerateButton(false);
            }
            catch(Exception ex)
            {
                this.labelInfo.Text = ex.Message;
            }
        }

        private void textBoxMaxNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnableDisableGenerateButton(false);
            }
            catch (Exception ex)
            {
                this.labelInfo.Text = ex.Message;
            }

        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

            try
            {
                EnableDisableGenerateButton(false);
            }
            catch (Exception ex)
            {
                this.labelInfo.Text = ex.Message;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBoxMinNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                EnableDisableGenerateButton(false);
            }
            catch (Exception ex)
            {
                this.labelInfo.Text = ex.Message;
            }

        }

        private void buttonSelectFiles_Click(object sender, EventArgs e)
        {
            labelListOfFilesSelecte.Text = string.Empty;

            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text|*.txt";
            od.Multiselect=true;

            HashSet<string> oldValues = new HashSet<string>();
            List<string> listOfFilesSelected = new List<string>();

            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string tempFolder = System.IO.Path.GetTempPath();
                foreach (string filename in od.FileNames)
                {
                    //readInTheValuesOfTheFile
                    string[] currFile = File.ReadAllLines(filename);
                    listOfFilesSelected.Add(filename);
                    if (currFile != null)
                    {
                        foreach (string s in currFile)
                        {
                            oldValues.Add(s);
                        }
                    }

                }


                //Convert the list to a string[]
                string[] allNumbers= oldValues.ToArray();

                //This will lose the value of the previous ExcludeFile
                CreateExcludeFile(allNumbers);

                //Now make a list of the file names to display on screen
                if (listOfFilesSelected!=null)
                {
                    string fileList = "";
                    foreach(string f in listOfFilesSelected)
                    {
                        fileList += f + Environment.NewLine;
                    }
                    labelListOfFilesSelecte.Text = fileList;
                }
                
            }
        }
        
        private static void CreateExcludeFile(string[] allNumbers)
        {
            //Now write a new file
            string currDir = Directory.GetCurrentDirectory();

            File.WriteAllLines(Path.Combine(currDir, AliKuli.Constants.excludeFileName), allNumbers);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void excludeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void buttonOpenExclude_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcludeForm exclude = new ExcludeForm();
            exclude.Show();
            
        }

        private void labelListOfFilesSelecte_Click(object sender, EventArgs e)
        {

        }

        private void labelProcessing_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewExcludeFile_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Directory.GetCurrentDirectory(), AliKuli.Constants.excludeFileName));
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void radioButton_Checked(object sender)
        {
            RadioButton r = (RadioButton)sender;
            if (r.Checked)
            {
                Global.lengthOfNumber = int.Parse(r.Text.Substring(0, 2));
                this.labelInfo.Text = Global.lengthOfNumber.ToString();
                this.labelInfo.Refresh();

                this.textBoxMaxNumber.Text = Global.MaxNo;
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Checked(sender);
        }

        private void buttonViewFile_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Directory.GetCurrentDirectory(), this.textBoxFileName.Text+".txt"));
        }


        
    }
}

