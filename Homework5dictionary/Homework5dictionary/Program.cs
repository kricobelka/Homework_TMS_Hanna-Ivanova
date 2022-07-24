using System;
using System.Collections.Generic;
namespace Homework5dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, int> SurnameAndMarks = new Dictionary<string, int>()
            {
                {"Buel", 9},
                {"Belova", 8},
                {"Piatrou",7}
            };
            int operation;
            string surname;
            int mark;
            //while (operation > 0 && operation < 9)
            //{
                Console.WriteLine("Choose an option listed below" + Environment.NewLine +
                "\t1: Add mark of the pupil" + Environment.NewLine +
                "\t2: Change mark of the pupil" + Environment.NewLine +
                "\t3: Delete mark of the pupil" + Environment.NewLine +
                "\t4: Output marks and surnames of pupils" + Environment.NewLine +
                "\t5: Output average mark of the pupils" + Environment.NewLine +
                "\t6: Output pupils with the best mark/t" + Environment.NewLine +
                "\t7:Output pupils with the mark equal to or more than 8/t" + Environment.NewLine +
                "\t8: Output pupils with the mark equal to or less than 8/t");
               
            operation = int.Parse (Console.ReadLine());
            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
            {
                switch (operation)
                {
                    case 1:

                        surname = Console.ReadLine();
                        mark = int.Parse (Console.ReadLine());
                        if (SurnameAndMarks.ContainsKey(surname) && SurnameAndMarks.ContainsValue (mark))
                        {
                            surname = surnameAndMark.Key;
                            mark = surnameAndMark.Value;
                            Console.WriteLine("This pupil is in the list");
                        }
                        else 
                        {
                            SurnameAndMarks.Add(surname, mark);
                        }
                            Console.WriteLine($"key:{surnameAndMark.Key}-value:{surnameAndMark.Value}");
                            break;
                        }
                }

            }
        }
    }

