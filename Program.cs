

string[] firstArray = new string[5] { "7898", "456", "123", "459", "8787" };
string[] secondArray = new string[firstArray.Length];

GetSecondArray(firstArray, secondArray);
PrintArray(secondArray);

void GetSecondArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
        }
        count++;
    }
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.WriteLine();
}