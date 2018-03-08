using LiMS.Controller;
using LiMS.Database;
using LiMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiMS.FileInputOutput
{
    class ImportClass
    {
        public static int[] ImportMembers(string table, string filePath)
        {
            int[] successFail = new int[2];
            //Read form file
            try
            {   // Open the text file using a stream reader.
                using(StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadLine();
                    string[] columns = line.Split('\t');
                    int columnCount = columns.Length;

                    string[] rows;
                    while((line = sr.ReadToEnd()) != null)
                    {
                        rows = line.Split('\t');

                        try
                        {
                            SQLInsertCommandModel insert = new SQLInsertCommandModel()
                            {
                                Table = table,
                                Columns = columns,
                                Data = rows

                            };
                            SQLCommandController.InsertInto(insert);

                            successFail[0]++;
                        }
                        catch(Exception)
                        {
                            successFail[1]++;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return successFail;
        }

        public static void SaveServer(ServerModel server, string filePath)
        {
            try
            {   // Open the text file using a stream reader.
                using(StreamReader sr = new StreamReader(filePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadLine();
                    System.IO.File.WriteAllLines(filePath,
                        new string[] { server.UserID, server.Password, server.Server });
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
