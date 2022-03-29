List<int> list = new List<int> { 6, 3, 4, 8, 5 };

List<int> ordered = MergingClass.MergeSort(list, 1, 5);

foreach (var item in ordered)
{
    Console.Write($"{item} ");
}

public static class MergingClass
{
    static int callNumber = 0;

    public static List<int> MergeSort(List<int> L, int s, int e)
    {
        if (s < e)
        {
            int m = (s + e) / 2;
            List<int> l1 = MergeSort(L, s, m);
            List<int> l2 = MergeSort(L, m + 1, e);

            callNumber++;

            Console.Write($"|{callNumber}|  {s}|{e}|{m}");
            foreach (int i in Merge(l1, l2)) Console.Write($"[{i}]");

            Console.WriteLine();

            return Merge(l1, l2);
        }
        else
        {
            callNumber++;

            Console.Write($"|{callNumber}|  {s}|{e}|___");

            Console.WriteLine();

            return Append(new List<int>(), L[s - 1]);
        }
    }

    static List<int> Append(List<int> list, int element)
    {
        return list.Append(element).ToList();
    }

    static void RemoveFirstItem(List<int> list)
    {
        list.RemoveAt(0);
    }

    static List<int> Merge(List<int> l1, List<int> l2)
    {
        List<int> l3 = new List<int>();

        while (l1.Count > 0 && l2.Count > 0)
        {
            if (l1[0] < l2[0])
            {
                l3 = Append(l3, l2[0]);
                RemoveFirstItem(l2);
            }
            else
            {
                l3 = Append(l3, l1[0]);
                RemoveFirstItem(l1);
            }
        }

        while (l1.Count > 0)
        {
            l3 = Append(l3, l1[0]);
            RemoveFirstItem(l1);
        }

        while (l2.Count > 0)
        {
            l3 = Append(l3, l2[0]);
            RemoveFirstItem(l2);
        }

        return l3;
    }
}