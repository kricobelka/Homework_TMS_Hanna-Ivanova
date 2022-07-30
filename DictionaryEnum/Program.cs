using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryEnum
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
            string surname = null;
            int mark = 0;
            int intResponse = 0;
            while (intResponse != 9)
            {
                Console.WriteLine("Choose an option listed below");
            //foreach (string name in Enum.GetNames(typeof(Menu)))
            //{
            //    Console.WriteLine(name);
            //}
            foreach (int value in Enum.GetValues(typeof(Menu)))
            {
                Console.WriteLine(value);
            }
            //string stringResponse = Console.ReadLine();
            intResponse = int.Parse(Console.ReadLine());
            Menu operation = (Menu)intResponse;
                switch (operation)
                {
                    case Menu.Add:
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
                    case Menu.Change:
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
                    case Menu.Delete:
                        {
                            Console.WriteLine("Please type the pupil's surname you would like to delete from the dictionary");
                            surname = Console.ReadLine();
                            if (SurnameAndMarks.ContainsKey(surname))
                            {
                                SurnameAndMarks.Remove(surname);
                                Console.WriteLine($"{surname} has been removed from the dictionary");
                                Console.WriteLine(SurnameAndMarks.ContainsKey(surname));
                            }
                            else
                            {
                                Console.WriteLine($"key:{surname} hasn't been found in the dictionary!");
                            }
                            break;
                        }
                    case Menu.MarksSurnames:
                        {
                            foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                            {
                                Console.WriteLine($"The key and value from the dictionary are: key:{surnameAndMark.Key}-value:{surnameAndMark.Value}");
                            }
                            break;
                        }
                    case Menu.AverageMark:
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
                    case Menu.BestMarks:
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
                    case Menu.Mark8:
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
                    case Menu.Mark4:
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
                    case Menu.Exit:
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
