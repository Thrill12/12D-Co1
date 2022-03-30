static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> list = GenerateRandomList(10000);

            int normalMS, subtractedMS, flagMS, combinedMS;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            BubbleSort(list);
            watch.Stop();
            normalMS = (int)watch.ElapsedMilliseconds;
            watch.Reset();

            list = GenerateRandomList(10000);

            watch.Start();
            BubbleSortWithSubtraction(list);
            watch.Stop();
            subtractedMS = (int)watch.ElapsedMilliseconds;
            watch.Reset();

            list = GenerateRandomList(10000);

            watch.Start();
            BubbleSortWithFlag(list);
            watch.Stop();
            flagMS = (int)watch.ElapsedMilliseconds;
            watch.Reset();

            list = GenerateRandomList(10000);

            watch.Start();
            BubbleSortWithFlagAndSubtracting(list);
            watch.Stop();
            combinedMS = (int)watch.ElapsedMilliseconds;
            watch.Reset();

            Console.WriteLine($"{normalMS} normal");
            Console.WriteLine($"{subtractedMS} subtracted");
            Console.WriteLine($"{flagMS} flag");
            Console.WriteLine($"{combinedMS} combined");
        }

        static List<int> GenerateRandomList(int maxNumOfElements)
        {
            List<int> returnedList = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < maxNumOfElements; i++)
            {
                returnedList.Add(rand.Next(0, maxNumOfElements));
            }

            return returnedList;
        }

        static void BubbleSort(List<int> list)
        {
            int numOfElements = list.Count - 1;

            int count1 = 0;

            while(count1 < list.Count - 1)
            {
                for (int count2 = 0; count2 < numOfElements; count2++)
                {
                    if(list[count2] > list[count2 + 1])
                    {
                        int temp = list[count2];
                        list[count2] = list[count2 + 1];
                        list[count2 + 1] = temp;
                    }
                }

                count1++;
            }
        }

        static void BubbleSortWithSubtraction(List<int> list)
        {
            int numOfElements = list.Count - 1;

            int count1 = 0;

            while (count1 < list.Count - 1)
            {
                for (int count2 = 0; count2 < numOfElements; count2++)
                {
                    if (list[count2] > list[count2 + 1])
                    {
                        int temp = list[count2];
                        list[count2] = list[count2 + 1];
                        list[count2 + 1] = temp;
                    }
                }

                numOfElements--;

                count1++;
            }
        }

        static void BubbleSortWithFlag(List<int> list)
        {
            int numOfElements = list.Count - 1;

            int count1 = 0;

            bool swapped = true;

            while (count1 < list.Count - 1 && swapped)
            {
                swapped = false;

                for (int count2 = 0; count2 < numOfElements; count2++)
                {
                    if (list[count2] > list[count2 + 1])
                    {
                        int temp = list[count2];
                        list[count2] = list[count2 + 1];
                        list[count2 + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
                else
                {
                    count1++;
                }
            }
        }

        static void BubbleSortWithFlagAndSubtracting(List<int> list)
        {
            int numOfElements = list.Count - 1;

            int count1 = 0;

            bool swapped = true;

            while (count1 < list.Count - 1 && swapped == true)
            {
                swapped = false;

                for (int count2 = 0; count2 < numOfElements; count2++)
                {
                    if (list[count2] > list[count2 + 1])
                    {
                        int temp = list[count2];
                        list[count2] = list[count2 + 1];
                        list[count2 + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }

                numOfElements--;

                count1++;
            }
        }