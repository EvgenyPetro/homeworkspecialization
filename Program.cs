
string[] arr1 = { "hello", "2", "world", ":-)" };
string[] arr2 = { "1234", "1567", "-2", "computer sience" };
string[] arr3 = { "Russia", "Denmark", "Kazan" };

string[] GetNewArray(String[] array)
{
    string[] tempArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArray[temp] = array[i];
            temp++;
        }
    }

    string[] resultArray = new string[temp];
    for (int i = 0; i < temp; i++)
    {
        resultArray[i] = tempArray[i];
    }
    return resultArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

PrintArray(GetNewArray(arr1));
PrintArray(GetNewArray(arr2));
PrintArray(GetNewArray(arr3));