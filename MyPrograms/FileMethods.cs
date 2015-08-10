using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliKuli.MyPrograms
{
    public static class FileMethods
    {

        /// <summary>
        /// This gets all the old data from the Exclude file. 
        /// </summary>
        /// <param name="fullNameOfExcludeFile"></param>
        /// <returns></returns>
        public  static HashSet<long> GetExcludeFileData(string fullNameOfExcludeFile)
        {
            long noOfElementsInExcludeFile = 0;
            
            HashSet<long> origExcludeFileHset = new HashSet<long>();
            string[] excludeFileStrArray = new string[noOfElementsInExcludeFile];
            try
            {
                string[] tempexcludeFileStrArray = File.ReadAllLines(fullNameOfExcludeFile);
                excludeFileStrArray = tempexcludeFileStrArray;
            }
            catch
            {
                throw;
            }
            //string[] excludeFileStrArray = string[]
            if (excludeFileStrArray != null)
            {
                for (long i = 0; i < excludeFileStrArray.Count();i++ )
                {
                    if (!string.IsNullOrEmpty(excludeFileStrArray[i]))
                    {
                        //incase the value is NOT a long.
                        long temp = 0;
                        bool success = long.TryParse(excludeFileStrArray[i], out temp);
                        if (success)
                        {
                            origExcludeFileHset.Add(temp);
                        }
                    }
                }
            }
            return origExcludeFileHset;
        }

        public static void CreateExludeFile(string[] allNumbers)
        {
            //Now write a new file
            string currDir = Directory.GetCurrentDirectory();

            File.WriteAllLines(Path.Combine(currDir, AliKuli.Constants.excludeFileName), allNumbers);
        }
        public static void GetListOfFilesAndAllTheirValues(out HashSet<long> selectedValuesHset,  out List<string> listOfFilesSelected)
        {
            selectedValuesHset = new HashSet<long>();
            listOfFilesSelected = new List<string>();

            OpenFileDialog od = new OpenFileDialog();
            od.Title = "Select/Multi-Select the scratchcard files.";
            od.Filter = "GenFil*.txt|GenFile*.txt|Text|*.txt|All|*.*";
            od.Multiselect = true;

            if (od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //string tempFolder = System.IO.Path.GetTempPath();

                //Add the values
                foreach (string filename in od.FileNames)
                {
                    //readInTheValuesOfTheFile -This might have duplicates
                    string[] currFile = File.ReadAllLines(filename);

                    listOfFilesSelected.Add(filename);
                    if (currFile != null)
                    {
                        //add the currFile to the oldValues hashSet
                        foreach (string s in currFile)
                        {
                            selectedValuesHset.Add(long.Parse(s));
                        }
                    }
                }
            }
        }

        public static void CheckFileName(string fileName)
        {

            if (string.IsNullOrEmpty(fileName))
            {
                string errorStr = "No file name - Please enter one.";
                throw new Exception(errorStr);

            }

            char[] charFilename = fileName.ToCharArray();
            string illegalCharString = "";
            char[] illegalChars = Path.GetInvalidFileNameChars();

            foreach (var item in charFilename)
            {
                if (illegalChars.Contains(item))
                {
                    illegalCharString += string.Format("'{0}',", item);
                }

            }
            if (illegalCharString.Length > 0)
            {
                string errorStr = string.Format("The following illegal charecters are in the file name: '{0}'", illegalCharString.Substring(0, illegalCharString.Length - 1));
                throw new Exception(errorStr);

            }

        }

        public static void CreateBackupCopyOfExcludeFile(string fileName)
        {
            string backupFileName = Path.Combine(Directory.GetCurrentDirectory(), AliKuli.Constants.backUpExcludeFile);
            CreateBackUpCopy(fileName, backupFileName);
        }

        /// <summary>
        /// This function makes a backup copy of the file
        /// </summary>
        /// <param name="infile"></param>
        /// <param name="outfile"></param>
        public static void CreateBackUpCopy(string infile, string outfile)
        {

            if (string.IsNullOrEmpty(infile))
                throw new Exception("The Incoming Filename is null or Empty");

            if (string.IsNullOrEmpty(outfile))
                throw new Exception("The outgoing Filename is null or Empty");

            if(!File.Exists(infile))
                throw new Exception("The incoming file does not exist!");

            try
            {
                CheckFileName(infile);
            }
            catch
            {
                throw;
            }

            try
            {
                CheckFileName(outfile);
            }
            catch
            {
                throw;
            }


            try
            {
                File.Copy(infile, outfile);
            }
            catch (Exception ex)
            {
                string error = string.Format("Unable to create backup copy of '{0}'. Error: {1}", infile, ex.Message);
                throw new Exception(error);
            }

        }
    }
}
