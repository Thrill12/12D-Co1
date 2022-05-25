private static void AskForFileCreation()
        {
            Console.WriteLine("Enter string to save to file");
            string strToSave = Console.ReadLine();
            string fileName = string.Empty;

            Console.WriteLine("Enter file name to save in");
            fileName = Console.ReadLine();

            while (File.Exists(fileName))
            {
                Console.WriteLine("Enter file name to save in");
                fileName = Console.ReadLine();

                if (!File.Exists(fileName))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }

            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(strToSave);
            writer.Close();
        }

        private static string AskForProductID()
        {
            string input = "";
            int len = 5;

            Console.WriteLine("please enter your product ID");
            input = Console.ReadLine();
            len = input.Length;

            int charsleft = 5 - len;

            for (int i = 0; i < charsleft; i++)
            {
                input += "0";
            }

            input = input.Substring(0, 5);
            Console.WriteLine("Padded product ID is " + input);
            return input;
        }

        private static void EnterSOr1To9()
        {
            string input = "";

            int inputIntParsed;

            while (input != "S" || !Int32.TryParse(input, out inputIntParsed))
            {
                if(Int32.TryParse(input, out inputIntParsed))
                {
                    if(inputIntParsed > 0 && inputIntParsed < 10)
                    {
                        break;
                    }
                }
                else if(input == "S")
                {
                    break;
                }

                Console.WriteLine("Please enter the capital S or a number between 1 and 9");
                input = Console.ReadLine();
            }
        }

        private static void Replacestring()
        {
            Console.WriteLine("Enter a string to encrypt badly");
            string input = Console.ReadLine();
            string encrypted = ReplaceOAndE(input);
            Console.WriteLine(encrypted);
        }

        private static string ReplaceOAndE(string input)
        {
            string returnedString = "";

            returnedString = input.Replace("e", "?");
            returnedString = returnedString.Replace("o", " .");

            return returnedString;
        }