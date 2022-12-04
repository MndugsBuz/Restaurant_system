using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Restaurant_system.Entities;

namespace Restaurant_system.Repositories
{
    public class TablesRepository
    {
        private List<Tables> tables { get; set; } = new List<Tables>();

        public List<Tables> GenerateTablesDataToJson()
        {
            // List<Tables> tables = new List<Tables>();

            for (int i = 1; i < 19; i++)

                if (i < 4)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "inside" + i,
                        WaiterId = "Monika01",
                        TableStatus = false,
                        NumberofSeats = 3,
                    });
                }
                else if (i >= 4 && i < 7)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "inside" + i,
                        WaiterId = "Aurelija01",
                        TableStatus = false,
                        NumberofSeats = 6,
                    });
                }
                else if (i >= 7 && i < 10)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "outside" + i,
                        WaiterId = "Monika01",
                        TableStatus = false,
                        NumberofSeats = 6,
                    });
                }
                else if (i >= 10 && i < 13)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "outside" + i,
                        WaiterId = "Deividas01",
                        TableStatus = false,
                        NumberofSeats = 6,
                    });
                }
                else if (i >= 13 && i < 16)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "inside" + i,
                        WaiterId = "Deividas01",
                        TableStatus = false,
                        NumberofSeats = 3,
                    });
                }
                else if (i >= 16 && i < 19)
                {
                    tables.Add(new Tables()
                    {

                        TableId = "table" + i,
                        TableName = "outside" + i,
                        WaiterId = "Aurelija01",
                        TableStatus = false,
                        NumberofSeats = 3,
                    });

                }



                    File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221017 code mb paskaita Basic_C#_exam/Order System/Order System/orders.json",
                JsonConvert.SerializeObject(tables));

            return tables;
        }


        public List<Tables> WriteToJson()
        {
            File.WriteAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221117 advanced code mb C#AdvancedEgzaminas/Restaurant_system/Restaurant_system/tables.json",
            JsonConvert.SerializeObject(tables));
            Console.WriteLine("tables writed to JSON file");

            return tables;
        }

        public List<Tables> ReadFromJson()
        {
            string readjson = File.ReadAllText("C:/desktop ml/Renkuosi programuoti/Back-End C Sharp code/221117 advanced code mb C#AdvancedEgzaminas/Restaurant_system/Restaurant_system/tables.json");
            tables = JsonConvert.DeserializeObject<List<Tables>>(readjson);
            Console.WriteLine("tables readed to JSON file");


            return tables;
        }
     

        public void PrintTables()
        {
            Console.WriteLine("Restaurant Tables:");
            int index = 1;
            Console.WriteLine("| TableID | TableName | WaiterID | TableStatus | Number Of Seats |");
            foreach (var items in tables)
            {
                Console.Write(index + ". ");
                Console.Write(items.TableId + " | ");
                Console.Write(items.TableName + " | ");
                Console.Write(items.WaiterId + " | ");
                if (items.TableStatus = true) { Console.Write(" free table | "); }
                else { Console.Write(" occupied | "); }
                Console.Write(items.NumberofSeats + " | ");
                Console.WriteLine();
                index++;
            }
            Console.WriteLine();
        }


    }

}
