using System;
using System.Collections.Generic;
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
                {"Piatrou",7}
            };
            int operation;
            string surname;
            int mark;
            //while (operation > 0 && operation < 9)
            {
                Console.WriteLine("Choose an option listed below" + Environment.NewLine +
                "\t1: Add mark of the pupil" + Environment.NewLine +
                "\t2: Change mark of the pupil" + Environment.NewLine +
                "\t3: Delete mark of the pupil" + Environment.NewLine +
                "\t4: Output marks and surnames of pupils" + Environment.NewLine +
                "\t5: Output average mark of the pupils" + Environment.NewLine +
                "\t6: Output pupils with the best mark" + Environment.NewLine +
                "\t7:Output pupils with the mark equal to or more than 8" + Environment.NewLine +
                "\t8: Output pupils with the mark equal to or less than 8");

                operation = int.Parse(Console.ReadLine());
                foreach (KeyValuePair<string, int> surnameAndMark in SurnameAndMarks)
                {
                    //почему выводит только первое значение в словаре? Console.WriteLine($"key:{surnameAndMark.Key}-value:{surnameAndMark.Value}");
                    switch (operation)
                    {
                        case 1:
                            surname = Console.ReadLine();
                            mark = int.Parse(Console.ReadLine());
                            if (SurnameAndMarks.ContainsKey(surname) && SurnameAndMarks.ContainsValue(mark))
                            {
                                surname = surnameAndMark.Key;
                                mark = surnameAndMark.Value;
                                Console.WriteLine($"The pupil key: {surname} mark: {mark} is in the list");
                            }
                            else
                            {
                                SurnameAndMarks.Add(surname, mark);
                                Console.WriteLine($"key:{surname}-value:{mark} has been added");
                            }
                            break;
                        case 2:
                            surname = Console.ReadLine();
                            mark = int.Parse(Console.ReadLine());
                            if (!SurnameAndMarks.ContainsKey(surname) && !SurnameAndMarks.ContainsValue(mark))
                            {
                                surname = surnameAndMark.Key;
                                mark = surnameAndMark.Value;
                                Console.WriteLine($"Pupil key: {surname} value: {mark} hasn't been found");
                            }
                            else
                            {
                                mark = surnameAndMark.Value;
                                Console.WriteLine($"value:{mark} of key: {surname} has been ");
                            }
                            break;
                        case 3:
                            surname = Console.ReadLine();
                            if (SurnameAndMarks.ContainsKey(surname))
                            {
                                surname = surnameAndMark.Key;
                                SurnameAndMarks.Remove(surname);
                            }
                            else
                            {
                                Console.WriteLine($"key:{surname} hasn't been found in the dictionary!");
                            }
                            break;
                        case 4:
                            Console.WriteLine(surnameAndMark);
                            break;
                        case 5:
                            mark = surnameAndMark.Value;
                            int averagemark = mark / 3;
                            for (mark = 0; mark < surnameAndMark.Value; mark++)
                            {
                                //Console.WriteLine($"Average mark of all the pupils is: {averagemark}");
                            }
                            Console.WriteLine($"Average mark of all the pupils is: {averagemark}");
                            break;
                        case 6:
                        default:
                            Console.WriteLine("Please type a valid option");
                            break;
                    }
                // вывести всех:
                // почему выводит только первое значение в словаре? Console.WriteLine(surnameAndMark);
            }

            }
        }
    }
}

