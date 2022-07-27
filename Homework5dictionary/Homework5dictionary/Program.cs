using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> SurnameAndMarks = new Dictionary<string, int>()
            {
                {"Buel", 9},
                {"Belova", 8},
                {"Piatrou",7},
                //{"Zhukovets", 10},
                {"Zubovich", 9},
                {"Rjeutskaya", 6}
            };
            int operation = 0;
            string surname = null;
            int mark = 0;
            while (operation != 9)
            {
                Console.WriteLine("Choose an option listed below" + Environment.NewLine +
                "\t1: Add mark of the pupil" + Environment.NewLine +
                "\t2: Change mark of the pupil" + Environment.NewLine +
                "\t3: Delete mark of the pupil" + Environment.NewLine +
                "\t4: Output marks and surnames of pupils" + Environment.NewLine +
                "\t5: Output average mark of the pupils" + Environment.NewLine +
                "\t6: Output pupils with the best mark" + Environment.NewLine +
                "\t7:Output pupils with the mark equal to or more than 8" + Environment.NewLine +
                "\t8: Output pupils with the mark equal to or less than 4" + Environment.NewLine +
                "\t9: Exit");

                operation = int.Parse(Console.ReadLine());
                //foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                //{
                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine("Please type the pupil's surname you would like to see in the dictionary");
                            surname = Console.ReadLine();
                            Console.WriteLine("Please type a mark of this pupil");
                            mark = int.Parse(Console.ReadLine());
                            if (SurnameAndMarks.ContainsKey(surname))
                            {
                                //surname = SurnameAndMark.Key;
                                //mark = SurnameAndMark.Value;
                                Console.WriteLine($"The pupil key: {surname} mark: {mark} is in the list");
                            }
                            else
                            {
                                SurnameAndMarks.Add(surname, mark);
                                Console.WriteLine($"key:{surname}-value:{mark} has been added");
                                //Console.WriteLine(SurnameAndMarks.TryGetValue(surname, out mark));
                                Console.WriteLine(SurnameAndMarks.ContainsKey("Picky"));
                                //Console.WriteLine(SurnameAndMarks.Count());
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Please type the pupil's surname of the pupil to update the mark");
                            surname = Console.ReadLine();
                            Console.WriteLine("Please insert a new mark received by this pupil");
                            mark = int.Parse(Console.ReadLine());
                            if (!SurnameAndMarks.ContainsKey(surname))
                            {
                                Console.WriteLine($"Pupil key: {surname} value: {mark} hasn't been found");
                            }
                            else
                            {
                                SurnameAndMarks[surname] = mark;
                            }
                            Console.WriteLine($"value:{mark} of key: {surname} has been updated");
                            Console.WriteLine($"Pupil key: {surname} value: {mark}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Please type the pupil's surname you would like to delete from the dictionary");
                            surname = Console.ReadLine();
                            if (SurnameAndMarks.ContainsKey(surname))
                            {
                                SurnameAndMarks.Remove(surname);
                                Console.WriteLine(SurnameAndMarks.ContainsKey(surname));
                            }
                            else
                            {
                                Console.WriteLine($"key:{surname} hasn't been found in the dictionary!");
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                Console.WriteLine($"The key and value from the dictionary are: key:{surnameAndMark.Key}-value:{surnameAndMark.Value}");
                            }
                            break;
                        }
                    case 5:
                        {
                            double averagesum = 0;
                            double sum = 0;
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                sum += surnameAndMark.Value;
                            }
                            averagesum = sum / SurnameAndMarks.Count;
                            Console.WriteLine($"Average mark received by the pupils from the dictionary is {averagesum}");
                            break;
                        }
                    case 6:
                        {
                            int max = 0;
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                //for (mark = 0; mark < SurnameAndMarks[mark]; mark++)
                                if (max <= surnameAndMark.Value)
                                {
                                    max = surnameAndMark.Value;
                                }
                            }
                            Console.WriteLine($"The highest marks in the class are {max}");
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                if (max == surnameAndMark.Value)
                                {
                                    surname = surnameAndMark.Key;
                                    Console.WriteLine($"The highest marks {max} are received by {surname}");
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"The marks more than or equal to (8) have been received by:");
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                if (surnameAndMark.Value >= 8)
                                {
                                    surname = surnameAndMark.Key;
                                    Console.WriteLine($"surname: {surnameAndMark.Key}, marks: {surnameAndMark.Value}");
                                    //mark = surnameAndMark.Value;
                                }
                            }
                            break;
                        }
                    case 8:
                        {
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                if (surnameAndMark.Value <= 4)
                                {
                                    surname = surnameAndMark.Key;
                                    Console.WriteLine($"The marks that are less than (4) are {surnameAndMark.Value}");
                                    //mark = surnameAndMark.Value;
                                    Console.WriteLine($"The marks less than (4) {surnameAndMark.Value} have been received by {surname}");
                                }
                                else
                                {
                                    Console.WriteLine("There are no such pupils!");
                                }
                            }
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Exit the program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please type a valid option");
                            break;
                        }
                }
            }
        }
    }
}