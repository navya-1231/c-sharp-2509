using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_Part_5
{
    class FileReader
    {
        public void ReadFile(string path)
        {
            StreamReader reader = null;//initialize reader to null

            try
            {
                //attempt to open a file
                reader = new StreamReader(path);
                string content = reader.ReadToEnd();//read the content
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                //ensure file is closed
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File closed.");
                }
            }
        }
    }
}
