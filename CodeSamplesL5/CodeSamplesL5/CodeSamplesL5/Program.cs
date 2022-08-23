using System.Globalization;
using System.Text;

namespace CodeSamplesL5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CharSymbols
            //char symbol1 = 'A';
            //char symbol2 = '\u006A';
            //char symbol3 = '\x006A';
            //char symbol4 = (char)106;
            ////Console.WriteLine(symbol1);
            ////Console.WriteLine(symbol2);
            ////Console.WriteLine(symbol3);
            ////Console.WriteLine(symbol4);

            ////int number = (int)symbol1;
            ////Console.WriteLine(number);


            ////Console.WriteLine(char.IsWhiteSpace(symbol1));
            ////symbol1 = ' ';
            ////Console.WriteLine(char.IsWhiteSpace(symbol1));

            ////Console.WriteLine(char.IsLetter(symbol1));
            ////symbol1 = 'A';
            ////Console.WriteLine(char.IsLetter(symbol1));

            ////Console.WriteLine(char.IsDigit(symbol1));
            ////symbol1 = '2';
            ////Console.WriteLine(char.IsDigit(symbol1));

            ////Console.WriteLine(char.IsLetterOrDigit(symbol1));
            ////symbol1 = ' ';
            ////Console.WriteLine(char.IsLetterOrDigit(symbol1));

            ////Console.WriteLine(char.IsPunctuation(symbol1));
            ////symbol1 = ',';
            ////Console.WriteLine(char.IsPunctuation(symbol1));

            //Console.WriteLine(char.IsLower(symbol1));
            //symbol1 = 'a';
            //Console.WriteLine(char.IsLower(symbol1));
            //Console.WriteLine(char.IsUpper(symbol1));
            #endregion


            #region Strings
            //string stringFromLiteral = "Hello world";
            //string stringFromArray = new string(new char[] { 'H', 'e', 'l', 'l', '0' });
            //string symbols = new string('A', 10);
            ////Console.WriteLine(stringFromLiteral);
            ////Console.WriteLine(stringFromArray);
            ////Console.WriteLine(symbols);

            //////foreach (char symbol in stringFromLiteral)
            //////{
            //////    //symbol = 'A';
            //////    Console.WriteLine(symbol);
            //////}

            ////for (int i = 0; i < stringFromLiteral.Length; i++)
            ////{
            ////    //stringFromLiteral[i] = 'A';
            ////    Console.WriteLine(stringFromLiteral[i]);
            ////}

            ////string upperString = stringFromLiteral.ToUpper();
            ////Console.WriteLine(upperString);
            ////string lowerString = stringFromLiteral.ToLower();
            ////Console.WriteLine(lowerString);
            ////Console.WriteLine(stringFromLiteral);



            ////ESSENTIAL//
            ////string s = "iii";
            ////string invariant = s.ToUpperInvariant();//III
            ////Console.WriteLine(invariant);
            ////var culture = new CultureInfo("tr-TR");
            ////string cultured = s.ToUpper(culture);//İİİ
            ////Console.WriteLine(cultured);

            ////Console.WriteLine(string.Empty == "");



            ////int indexOfW = stringFromLiteral.IndexOf('W');
            ////int indexOfSubstring = stringFromLiteral.IndexOf("orl");
            //string newString = stringFromLiteral.Replace('l', 'A');
            ////Console.WriteLine(indexOfW);
            ////Console.WriteLine(stringFromLiteral);
            ////Console.WriteLine(indexOfSubstring);
            ////Console.WriteLine(newString);
            ////Console.WriteLine(stringFromLiteral.Substring(4, 5));
            ////Console.WriteLine(stringFromLiteral.Substring(4, 5));



            ////newString = stringFromLiteral.Replace("Hello", "Bye");
            ////Console.WriteLine(stringFromLiteral);
            ////Console.WriteLine(newString);

            ////newString = stringFromLiteral.Insert(4, " my ");
            //////Console.WriteLine(stringFromLiteral);
            ////Console.WriteLine(newString);

            //string newString2 = newString.Remove(4, 4);
            ////Console.WriteLine(stringFromLiteral);
            //Console.WriteLine(newString2);
            //почему после удаления выводит целую строку hello world?


            //string stringWithWhiteSpaces = "Ivan Nikita Alena Mila Sergey Nastya";
            ////string[] arrayOfStrings = stringWithWhiteSpaces.Split(' ');
            ////foreach (string item in arrayOfStrings)
            ////{
            ////    Console.WriteLine(item);
            //}

            //string enteredString = Console.ReadLine();
            //Console.WriteLine(enteredString);
            //Console.WriteLine(enteredString.Length);

            //string trimmedString = enteredString.Trim();
            //Console.WriteLine(trimmedString.Length);
            //Console.WriteLine(trimmedString);
            //trimmedString = enteredString.TrimStart();
            //Console.WriteLine(trimmedString.Length);
            //trimmedString = enteredString.TrimEnd();
            //Console.WriteLine(trimmedString.Length);


            //enteredString = Console.ReadLine();
            //Console.WriteLine(enteredString);
            //Console.WriteLine(enteredString.Length);
            //trimmedString = enteredString.Trim('_');
            //Console.WriteLine(trimmedString.Length);
            //Console.WriteLine(trimmedString);


            //string concattedString = string.Concat("He", "llo ", "Wor", "ld");
            //Console.WriteLine(concattedString);
            //concattedString = "He" + "llo " + "Wor" + "ld";
            //string str1 = "He";
            //string str2 = "llo ";
            //string str3 = "Wor";
            //string str4 = "ld";
            //concattedString = str1 + str2 + str3 + str4;
            //Console.WriteLine(concattedString);
            //string[] items = new string[] { "String1", "String2", "String3" };
            //concattedString = string.Join("|separator|", items);
            //Console.WriteLine(concattedString);
            //concattedString = string.Join(' ', items);
            //Console.WriteLine(concattedString);

            //Console.WriteLine(string.IsNullOrEmpty("fds"));
            //Console.WriteLine(string.IsNullOrEmpty(string.Empty));
            //Console.WriteLine(string.IsNullOrWhiteSpace("    "));

            ////string enteredString = Console.ReadLine();
            ////if (!string.IsNullOrEmpty(enteredString))
            ////{
            //    Console.WriteLine("Is not null or empty");
            //}
            //else
            //{
            //    Console.WriteLine("Null or empty");
            //}
            //if (enteredString != null && enteredString != string.Empty)
            //{
            //    Console.WriteLine("Is not null or empty");
            //}

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //Console.WriteLine(str1 == str2);
            //Console.WriteLine(string.Compare(str1, str2));
            //Console.WriteLine(string.Compare(str1, str2, true));

            //var s1 = "HelloWorld";
            //var s2 = "HelloWorld";
            //var s3 = "Hello" + "World";
            ////объявили три объекта, это три ссылки, они равны между собой, применяется только для строк
            //Console.WriteLine(ReferenceEquals(s1, s2));
            //Console.WriteLine(ReferenceEquals(s1, s3));

            //////строку заменяем:
            //s2 = s2 + "!";
            //Console.WriteLine(s2);
            //Console.WriteLine(ReferenceEquals(s1, s2));
            ////// output: false

            //decimal price = 17.36m;
            //string s = string.Format("The current price is {0:C2}", price);
            //Console.WriteLine(s);
            //decimal temp1 = 36.93434m, temp2 = 39.5234234m;
            //s = string.Format("The temperature is between {0:N0} degrees - {1:N0} degrees", temp1, temp2);
            //Console.WriteLine(s);

            //s = $"price:{price}, temp1:{temp1}, temp2:{temp2}";
            //Console.WriteLine(s);
            #endregion

            #region StringBuilder
            //StringBuilder stringBuilder = new StringBuilder("str", 300);
            //for (int i = 1; i < 10; i++)
            //{
            //    stringBuilder.AppendLine("123");
            //}

            //string s = stringBuilder.ToString();





            //int sLen = 30, Loops = 5000;
            //string sSource = new string('X', sLen);
            //string sDest = "";

            //// Time string concatenation.
            //var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < Loops; i++)
            //{
            //    sDest += sSource;
            //}
            //stopwatch.Stop();
            //Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms.");

            //// Time StringBuilder.
            //stopwatch.Restart();
            //StringBuilder sb = new StringBuilder((int)(sLen * Loops * 1.1));
            //for (int i = 0; i < Loops; i++)
            //{
            //    sb.Append(sSource);
            //}
            //sDest = sb.ToString();
            //stopwatch.Stop();
            //Console.WriteLine($"String Builder took {stopwatch.ElapsedMilliseconds} ms.");
            #endregion
        }
    }
}