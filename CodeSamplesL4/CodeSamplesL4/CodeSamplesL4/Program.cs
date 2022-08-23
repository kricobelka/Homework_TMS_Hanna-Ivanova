namespace CodeSamplesL4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region arrayExample
            //int[] ints;
            //ints = new int[3];
            //for(int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            //bool[] bools = new bool[3];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(bools[i]);
            //}

            //string[] strings = new string[3];
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.WriteLine(strings[i]);
            //}



            //int[] ints1 = new int[4] { 1, 2, 3 };
            //int[] ints1 = new int[4] { 1, 2, 3, 4 };
            //int[] ints2 = new int[] { 1, 2, 3 };
            //int[] ints3 = new [] { 1, 2, 3 };
            //int[] ints4 = { 1, 2, 3 };



            //int[] ints = new int[3];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int intNumber in ints)
            //{
            //    Console.WriteLine(intNumber);
            //    //intNumber = 0;
            //}
            ////Console.WriteLine(ints[6]);

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] = 0;
            //}


            //int lengthOfArray = int.Parse(Console.ReadLine());
            //int[] ints1 = new int[lengthOfArray];
            //for (int i = 0; i < ints1.Length; i++)
            //{
            //    ints1[i] = int.Parse(Console.ReadLine());
            //}

            //int[] ints2 = ints1;
            //for (int i = 0; i < ints1.Length; i++)
            //{
            //    ints1[i] = 0;
            //}

            //foreach (int item in ints2)
            //{
            //    Console.WriteLine(item);
            //}



            //int[] ints3 = new int[2];
            //int[] ints3 = new int[5];
            //ints1.CopyTo(ints3, 4);
            //int[] ints3 = new int[5];
            //ints1.CopyTo(ints3, 0);
            //for (int i = 0; i < ints1.Length; i++)
            //{
            //    ints1[i] = 0;
            //}

            //foreach (int item in ints3)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] arraySquare1 = new int[10, 2];
            //int[,,] arrayCube = new int[3, 2, 5];
            //int[,] arraySquare2 = new int[2, 3] { { 1, 2, 3 }, { 2, 3, 4 } };
            //for(int i = 0; i < arraySquare2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arraySquare2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arraySquare2[i,j]);
            //    }
            //}

            //int[][] table;
            //table = new int[2][];
            //table[0] = new int[3];
            //table[1] = new int[5];
            //table[1][3] = 2;
            //table[0][4] = 3;

            #endregion

            #region listExample
            List<string> list = new List<string>();
            list.Add("Nikita");
            list.Add("Ivan");
            list.Add("Alena");
            list.AddRange(new List<string>()
            {
                "Mila",
                "Sergey",
            });
            list.Insert(1, "Hec");


            //foreach (string name in list)
            //{
            //name = "something";
            //    Console.WriteLine(name);
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list.Contains("Ivan"));
            //Console.WriteLine(list.Contains("Ivan1"));


            //list.Insert(6, "Inserted Item");
            //list.Insert(1, "Hec");
            //Console.WriteLine(list[3]);
            ////Console.WriteLine(list[6]);
            //Console.WriteLine(list[1]);

            //list.InsertRange(2, new List<string>()
            //{
            //    "Mila",
            //    "Sergey",
            //});
            //Console.WriteLine(list.Contains(list[2]));
            //foreach (string name in list)
            //{
            //    Console.WriteLine(name);
            //}

            //    bool wasRemoved = list.Remove("Ivan");
            //Console.WriteLine(wasRemoved);
            //wasRemoved = list.Remove("Ivan2");
            //Console.WriteLine(wasRemoved);

            //Console.WriteLine(list.Count);
            ////list.RemoveAt(4);
            ////list.RemoveAt(1);

            //Console.WriteLine(list.IndexOf("Nikita"));
            //Console.WriteLine(list.IndexOf("Ivan"));
            //Console.WriteLine(list.LastIndexOf("Nikita"));

            //List<string> list2 = new List<string>(list);
            ////List<string> list2 = list.GetRange(1, list.Count-1);

            //Console.WriteLine(list2.Count);
            //list.Clear();
            //Console.WriteLine(list2.Count);

            #endregion

            #region stackExample
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            ////stack.Push(4);


            //foreach (int number in stack)
            //{
            //    Console.WriteLine(number);
            //}
            //if (stack.Contains(3))
            //{
            //    Console.WriteLine("Stack contains 3");
            //}
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Count);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Count);

            //int result = 0;
            //bool isPopSuccessfull = stack.TryPop(out result);
            //Console.WriteLine(isPopSuccessfull);
            //Console.WriteLine(result);
            ////isPopSuccessfull = stack.TryPop(out result);
            ////Console.WriteLine(isPopSuccessfull);
            ////Console.WriteLine(result);

            //bool isPeekSuccessfull = stack.TryPeek(out result);
            //Console.WriteLine(isPeekSuccessfull);
            //Console.WriteLine(result);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(isPeekSuccessfull);





            ////Stack<int> stack1 = new Stack<int>(stack); = Stack<int> stack2 = stack;
            //Stack<int> stack2 = stack;
            //int[] arrayFromStack = stack.ToArray();
            //Stack<int> stack2 = new Stack<int>(arrayFromStack);
            //stack.Pop();
            //stack.Pop();
            //foreach (int number in stack2)
            //{
            //    Console.WriteLine(number);
            //}

            //stack.Clear();
            //Console.WriteLine(stack.Count);
            #endregion

            #region queueExample
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);


            //foreach (int number in queue)
            //{
            //    Console.WriteLine(number);
            //}

            //if (queue.Contains(3))
            //{
            //    Console.WriteLine("Queue contains 3");
            //}


            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Count);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());

            //int result = 0;
            //bool isDequeueSuccessfull = queue.TryDequeue(out result);
            //Console.WriteLine(isDequeueSuccessfull);
            //Console.WriteLine(result);
            //isDequeueSuccessfull = queue.TryDequeue(out result);
            //Console.WriteLine(isDequeueSuccessfull);
            //Console.WriteLine(result);

            //bool isPeekSuccessfull = queue.TryPeek(out result);
            //Console.WriteLine(isPeekSuccessfull);
            //Console.WriteLine(result);




            ////Queue<int> queue2 = queue;
            //int[] arrayFromQueue = new int[4];
            //queue.CopyTo(arrayFromQueue, 0);
            ////2 способ: int[] arrayfromqueue = queue.ToArray();
            ////Queue<int> queue = new Queue<int>(arrayfromqueue);

            //////Queue<int> queue2 = new Queue<int>(queue);
            //Queue<int> queue2 = new Queue<int>(arrayFromQueue);
            //Console.WriteLine(queue2.Count);
            //queue2.Dequeue();
            //queue2.Dequeue();
            //Console.WriteLine(queue2.Count);
            //foreach (int number in queue2)
            //{
            //    Console.WriteLine(number);
            //}


            //queue.Clear();
            //Console.WriteLine(queue.Count);
            #endregion

            #region dictionaryExample
            Dictionary<string, int> marks = new Dictionary<string, int>()
            {
                {"Nikita",8 },
                {"Ivan", 9 },
                {"Alena", 10 }
            };

            //Console.WriteLine("");

            ////foreach (KeyValuePair<string, int> mark in marks)
            ////{
            ////    Console.WriteLine($"key:{mark.Key}-value:{mark.Value}");
            ////}

            ////marks.Add("Iv", 2);
            //////marks.Add("Sergey", 5);

            foreach (KeyValuePair<string, int> mark in marks)
            {
                Console.WriteLine($"key:{mark.Key}-value:{mark.Value}");
                Console.WriteLine(marks.Count());
            }
            ////Console.WriteLine(marks["Nikita"]);
            ////Console.WriteLine(marks["Sergey"]);
            ////Console.WriteLine(marks["Nastya"]);


            //marks["Nikita"] = 2;
            //marks["Nastya"] = 5;
            //Console.WriteLine(marks["Nikita"]);
            //if (marks.ContainsKey("Nastya"))
            //{
            //    Console.WriteLine(marks["Nastya"]);
            //}
            //else
            //{
            //    Console.WriteLine("There is no Nastya");
            //}
            //foreach (KeyValuePair<string, int> mark in marks)
            //{
            //    Console.WriteLine($"key:{mark.Key}-value:{mark.Value}");
            //}

            //int nastyasMark = 0;
            //bool markExists = marks.TryGetValue("Nastya", out nastyasMark);
            //Console.WriteLine(markExists);
            //Console.WriteLine(nastyasMark);

            //markExists = marks.TryGetValue("Nastya1", out nastyasMark);
            //Console.WriteLine(markExists);
            //Console.WriteLine(nastyasMark);

            //Console.WriteLine(marks.ContainsKey("Nikita"));
            //marks.Remove("Nikita");
            //Console.WriteLine(marks.ContainsKey("Nikita"));

            //foreach (string name in marks.Keys)
            //{
            //    Console.WriteLine(name);
            //}

            //foreach (int mark in marks.Values)
            //{
            //    Console.WriteLine(mark);
            //}

            Console.WriteLine(marks.Count);
            marks.Clear();
            Console.WriteLine(marks.Count);

            //Dictionary<string, int> marks1 = new Dictionary<string, int>(marks);
            #endregion
        }
    }
}