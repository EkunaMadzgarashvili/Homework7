using System.Numerics;
#region Task1
using System.Runtime.CompilerServices;

Console.WriteLine("Enter the minimum number");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the maximum number");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
int ans = getListCount(min, max, n, list);
Console.WriteLine($"The number of answers is {ans}. Here are them: " + string.Join(" ,", list) + ".");

static int getListCount(int min, int max, int n, List<int> list)
{
    for (int i = min; i <= max; i++)
    {
        try
        {
            double root = Math.Pow(i, 1.0 / n);
            if (root == Math.Round(root))
            {
                list.Add(i);

            }
        }
        catch (Exception)
        {
            Console.WriteLine($"N equals to {n}");
        }


    }
    return list.Count;

}
#endregion

#region Task2
string str = Console.ReadLine();
Dictionary<char, int> socks = getDictionary(str);
int answer = getCount(socks);
Console.WriteLine($"The count of socks is {answer}");
static Dictionary<char, int> getDictionary(string str)
{
    Dictionary<char, int> socks1 = new Dictionary<char, int>();
    foreach (char ch in str)
    {
        if (!socks1.ContainsKey(ch))
        {
            socks1.Add(ch, 1);
        }
        else
        {
            socks1[ch]++;
        }
    }
    return socks1;
}

static int getCount(Dictionary<char, int> socks)
{
    int count = 0;
    int pairCount = 2;
    foreach (KeyValuePair<char, int> pair in socks)
    {
        if (pair.Value == pairCount)
        {
            count++;
        }
    }
    return count;
}



#endregion

#region Task3

string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
int k = 1;
int index = getIndex(s1, s2);
string line = getLine(index, s1, s2);
Console.WriteLine(line);
static int getIndex(string s1, string s2)
{
    if (s1.Length > s2.Length)
    {
        return s2.Length - 1;

    }
    return s1.Length - 1;

}
static string getLine(int index, string s1, string s2)
{
    string s = "";
    int k = 1;
    while (index >= 0)
    {
        if (s2[index] == s1[s1.Length - k])
        {
            s = s2[index] + s;
            k++;
        }
        else
        {
            break;
        }
        index--;

    }
    return s;
}

#endregion

#region Task5
string input = Console.ReadLine();
int startIndex = 0;
getCharacters(input, startIndex);

static void getCharacters(string input, int startIndex)
{
    if (startIndex == input.Length)
    {
        return;
    }
    Console.Write(input[startIndex]);
    if(startIndex != input.Length - 1)
    {
        Console.Write(" - ");
    }
    startIndex++;
    getCharacters(input, startIndex);

}
#endregion

#region Task6
List<int> array = new List<int>() { 1, 3, 2, 1 };
bool hasDuplicates = getBoolean(array);
static bool getBoolean(List<int> array) {
    Dictionary<int, int> dic = new Dictionary<int, int>();
    foreach (int num in array)
    {
        if (!dic.ContainsKey(num))
        {
            dic.Add(num, 1);
        }
        else
        {
            Console.WriteLine("Array has duplicates");
            return true;


        }
    }
    Console.WriteLine("Array doesn't have duplicates");
    return false;
}
#endregion
