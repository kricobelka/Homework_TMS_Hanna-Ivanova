namespace CodeSamplesL3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region primitiveNumberTypes
            //int numberOfStudents = 14;
            //int number1 = numberOfStudents;

            //int numberOfGoods = 214748375;
            //byte byteNumber = 255;
            //long numberOfGoods1 = 9223372036854775404;
            //double weight = 513123312312.2324322222222223;
            //Console.WriteLine($"numberOfStudents:{numberOfGoods}");
            //Console.WriteLine($"numberOfGoods:{numberOfStudents}");
            //Console.WriteLine($"byteNumber:{byteNumber}");
            //Console.WriteLine($"numberOfGoods1:{numberOfGoods1}");
            //Console.WriteLine($"weight:{weight}");
            #endregion

            #region otherPrimitiveTypes
            //bool isOdd = true;
            //char symbol = 'f';
            ////string name = "Nikita";
            //object objectVariable1 = null;
            //object objectVariable2 = 2;
            //Console.WriteLine($"isOdd:{isOdd}");
            //Console.WriteLine($"symbol:{symbol}");
            ////Console.WriteLine($"name:{name}");
            //Console.WriteLine($"objectVariable1:{objectVariable1}");
            //Console.WriteLine($"objectVariable2:{objectVariable2}");
            #endregion

            #region literals
            //long longNumber1 = 30L;
            //long longNumber2 = 30l;
            //uint uintNumber1 = 30U;
            //uint uintNumber2 = 30u;
            //ulong ulongNumber1 = 30UL;
            //ulong ulongNumber2 = 30ul;

            //float floatNumber1 = 3.15f;
            //float floatNumber2 = 3F;
            //double doubleNumber1 = 3.14D;
            //double doubleNumber2 = 3d;
            //decimal decimalNumber1 = 100M;
            //decimal decimalNUmber2 = -101.6m;

            //char symbol1 = '\n';
            //char symbol3 = 'f';
            //char symbol2 = '\u005C';
            ////Console.WriteLine(symbol1);
            ////Console.WriteLine("symbol3:"+ "\n" + symbol3);
            ////Console.WriteLine("symbol2:" + "\u005C");

            //string stringVariable1 = "Row1 \n Row2";
            //string stringVariable2 = @"Row1 \n there is no Row2";
            //string stringVariable3 = $"Row1 \n {symbol2}\nRow2";
            //Console.WriteLine(stringVariable1);
            // Console.WriteLine(stringVariable2);
            //Console.WriteLine(stringVariable3);

            //bool isOdd = true;
            //bool isEven = false;
            //isOdd = isEven;
            //Console.WriteLine($"isOdd:{isOdd}");
            //Console.WriteLine($"isEven:{isEven}");
            #endregion

            #region ariphmeticOperations
            //int integerNumber1 = 6;
            //int integerNumber2 = 10;
            //int result = integerNumber1 + integerNumber2;
            //Console.WriteLine($"6+10={result}");
            //result = integerNumber2 - integerNumber1;
            //Console.WriteLine($"10-6={result}");
            //result = integerNumber1 * integerNumber2;
            //Console.WriteLine($"6*10={result}");
            //result = integerNumber2 / integerNumber1;
            //Console.WriteLine($"10/6={result}");
            //result = integerNumber2 % integerNumber1;
            //Console.WriteLine($"10%6={result}");

            //double doubleNumber1 = 10d;
            //double doubleNumber2 = 6d;
            //Console.WriteLine(doubleNumber1 / doubleNumber2);
            //Console.WriteLine(doubleNumber1 % doubleNumber2);

            //string hello = "Hello";
            //string world = "World";
            //string helloworld = hello + world;
            //Console.WriteLine(helloworld);
            #endregion

            #region relationalOperations
            //int number1 = 15;
            //int number2 = 15;
            //int number3 = 16;
            //bool isEqual = number1 == number2;

            //Console.WriteLine($"15>15:{number2 > number1}");
            //Console.WriteLine($"16>15:{number3 > number1}");
            //Console.WriteLine($"16<15:{number3 < number1}");
            //Console.WriteLine($"15==15:{isEqual}");
            //Console.WriteLine($"15!=15:{15 != 15}");
            //Console.WriteLine($"15>=15:{15 >= 15}");
            //Console.WriteLine($"15<=15:{15 <= 15}");
            #endregion

            #region unaryOperations
            //int number1 = 1;
            ////number1++;
            //////int oppositeNumber = -number1;
            //////int i = 1;
            //////int j = i++;
            //////Console.WriteLine($"-number1:{oppositeNumber}");
            //Console.WriteLine($"number1++:{number1++}");
            //Console.WriteLine($"number1 after number++:{number1}");
            ////Console.WriteLine($"++number1:{++number1}");
            ////Console.WriteLine($"number1 after ++number:{number1}");
            ////Console.WriteLine(i);
            //Console.WriteLine(j);

            //int number2 = 5;
            ////Console.WriteLine($"--number2:{--number2}");
            ////Console.WriteLine($"number2 after --number2:{number2}");
            ////Console.WriteLine($"number2--:{number2--}");
            ////Console.WriteLine($"number2 after number2--:{number2}");

            //int number3 = number2++;
            ////Console.WriteLine(number3);
            //Console.WriteLine(number2);
            //number3 = ++number2;
            //Console.WriteLine(number3);
            //Console.WriteLine(number2);
            #endregion

            #region assignmentOperations
            //int number1 = 7;
            //int result1 = 24;
            //int result2 = 24;
            ////result1 += number1;
            ////Console.WriteLine($"result1 += number1:{result1}");
            ////result2 = result2 + number1;
            ////Console.WriteLine($"result2 = result2 + number1:{result2}");

            //result1 -= number1;
            //Console.WriteLine($"result -= number1:{result1}");
            ////result2 = result2 - number1;
            ////Console.WriteLine($"result = result - number1:{result2}");

            //result1 /= number1;
            //Console.WriteLine($"result /= number1:{result1}");
            //result2 = result2 / number1;
            //Console.WriteLine($"result = result / number1:{result2}");
            #endregion

            #region logicalOperations
            //bool boolVariable = false;
            //bool opposite = !boolVariable;
            //bool result = boolVariable;
            //Console.WriteLine($"!false:{!boolVariable}");
            //Console.WriteLine($"!true:{!true}");

            //Console.WriteLine($"true && true:{true && true}");
            //Console.WriteLine($"false && true:{false && true}");
            //Console.WriteLine($"true && false:{true && false}");
            //Console.WriteLine($"false && false:{false && false}");

            //Console.WriteLine($"true || true:{true || true}");
            //Console.WriteLine($"false || true:{false || true}");
            //Console.WriteLine($"true || false:{true || false}");
            //Console.WriteLine($"false || false:{false || false}");

            //int firstNumber = 10, secondNumber = 20;

            //result = (firstNumber == secondNumber) || (firstNumber > 5);
            //Console.WriteLine(result);
            //result = (firstNumber == secondNumber) && (firstNumber > 5);
            //Console.WriteLine(result);

            //int firstNumber = 10, secondNumber = 20;

            //result = (firstNumber == secondNumber) | (firstNumber > 5);
            //Console.WriteLine(result);
            //result = (firstNumber == secondNumber) & (firstNumber > 5);
            //Console.WriteLine(result);
            #endregion

            //byte byteNumber = 255;
            //byteNumber++;
            //Console.WriteLine(byteNumber);
            //int number1 = 2147483647;
            //int number2 = ++number1;//2147483648
            //Console.WriteLine(number2);
            //checked
            //{
            //    byte byteNumber = 255;
            //    byteNumber++;
            //    Console.WriteLine(byteNumber);

            //    int x = -2147483648;
            //    int z = --x;
            //    Console.WriteLine(z);
            //}
            //checked
            //{
            //    byte number1 = byte.Parse(Console.ReadLine());
            //    byte number2 = byte.Parse(Console.ReadLine());
            //    byte number3 = (byte)(number2 * number1);
            //    // or int number3 = number2 * number1;
            //    Console.WriteLine(number1);
            //    Console.WriteLine(number2);
            //    Console.WriteLine(number3);
            //}

            //byte number1 = 1;
            //byte number2 = 2;
            //byte number3 = (byte)(number1 * number2);
            //    Console.WriteLine(number3);
            //int minNumber = int.MinValue;
            //    int maxNumber = int.MaxValue;
            //    Console.WriteLine(minNumber);
            //    Console.WriteLine(maxNumber);
                        //short d = 10, f = 12;
                        bool var1 = true, var2 = false;
                        //if (d < f)
                        //    Console.WriteLine("d < f");
                        //if (d <= f)
                        //    Console.WriteLine("d <= f");
                        //if (d != f)
                        //    Console.WriteLine("d != f");
                        //// Следующее условие не выполнится      
                        //if (d > f)
                        //    Console.WriteLine("d > f");
                        // Сравниванием переменные var1 и var2          
                        if (var1 & var2)
                            Console.WriteLine("Данный текст не выведется");
                        if (!(var1 & var2))
                            Console.WriteLine("!(var1 & var2) = true");
                        if (var1 | var2)
                            Console.WriteLine("var1 | var2 = true");
                        if (var1 ^ var2)
                            Console.WriteLine("var1 ^ var2 = true");
                        Console.ReadLine();
                    }
                }
            }