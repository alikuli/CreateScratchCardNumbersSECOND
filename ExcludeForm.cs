using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AliKuli.MyPrograms;

namespace CreateScratchCardNumbers
{
    public partial class ExcludeForm : Form
    {
        public ExcludeForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// By the end of this procedure you will have a new Exclude File with new data that has either been added, subtracted or the old exclude File has been subtracted from New data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectFiles_Click(object sender, EventArgs e)
        {
            labelListOfFilesSelecte.Text = string.Empty;


            HashSet<long> selectedValuesHset = new HashSet<long>();
            HashSet<long> NewValuesHset = new HashSet<long>();
            HashSet<long> origExcludeFileHset = new HashSet<long>();
            HashSet<long> resultHashset = new HashSet<long>();
            List<string> listOfFilesSelected = new List<string>();

            string fullNameOfExcludeFile = Path.Combine(Directory.GetCurrentDirectory(), AliKuli.Constants.excludeFileName);



            try
            {
                FileMethods.GetListOfFilesAndAllTheirValues(out selectedValuesHset, out listOfFilesSelected);
             
                //Get values of Exclude File
                origExcludeFileHset = FileMethods.GetExcludeFileData(fullNameOfExcludeFile);

                //origExcludeFileHset: Now all the original Exclude file is in
                //selectedValuesHset: All the new selected files data


                //Now we will add these or subtract these from the Exclude file
                //Final value will come in origExcludeFileHset

                //Create a backup Exclude File if a file exists
                if (origExcludeFileHset!=null)
                    FileMethods.CreateBackupCopyOfExcludeFile(fullNameOfExcludeFile);
            }
            catch(Exception ex)
            {
                this.labelInfo.Text = ex.Message;
            }


            if (selectedValuesHset != null)
            {
                if (radioButtonAdd.Checked || RadioButtonExcludedDataLessNewData.Checked)
                {
                    foreach (var item in selectedValuesHset)
                    {
                        //This adds the new data to the old Exclude File
                        if (radioButtonAdd.Checked)
                        {
                            origExcludeFileHset.Add(item);
                        }

                        //This removes the data from the old Exclude File
                        if (RadioButtonExcludedDataLessNewData.Checked)
                        {
                            origExcludeFileHset.Remove(item);
                        }
                    }

                    //Now the updated originalEcludeFileHSet becomes the result set
                    resultHashset = origExcludeFileHset;
                }


                if(RadioButtonNewDataLessExcludedData.Checked)
                {
                    //this removes the Exclude File Data from the new data
                    foreach (var item in origExcludeFileHset)
                    {
                        selectedValuesHset.Remove(item);
                    }
                
                    //Now the new selectedValuesHSet becomes the new result set
                    resultHashset = selectedValuesHset;
                }

            }

            //Now all the final data is in the resultHasSet
            string[] resultHasSetArr = new string[resultHashset.Count()];

            //Convert the resultHashSet into a string array.
            long counter = 0;
            foreach (var item in resultHashset)
            {
                //this is where the number of digits should come
                resultHasSetArr[counter] = item.ToString("0000000000000000");
                counter++;
            }

            //Write the resultHasset into the Exclude File i.e. the result hashSet has become the new Exclude File.
            File.WriteAllLines(fullNameOfExcludeFile, resultHasSetArr);

            //Now make a list of the file names to display on screen
            if (listOfFilesSelected != null)
            {
                string fileList = "";
                foreach (string f in listOfFilesSelected)
                {
                    fileList += f + Environment.NewLine;
                }
                labelListOfFilesSelecte.Text = fileList;
            }

            

        }



        private void buttonOpenGenerateScratchCardNumbers_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

    }
}
