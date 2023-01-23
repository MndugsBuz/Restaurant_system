using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Restaurant_system.Entities
{
    public class ReadFileExceptions
    {
        public bool ReadFileException()
        {
            bool readed = false;

            try
            {
                string readjson = File.ReadAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221117 advanced code mb C#AdvancedEgzaminas/Restaurant_system/Restaurant_system/tables.json");
                readed = true;
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e1)
            {
                Console.WriteLine(e1.Message);
            }

            catch (DirectoryNotFoundException e2)
            {
                Console.WriteLine(e2.Message);
            }
            catch (FileNotFoundException e3)
            {
                Console.WriteLine(e3.Message);
            }

            Console.WriteLine("Still working");

            return readed;

        }

    }
}
