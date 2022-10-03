string[] array = new string[3] {"///", "cat", "12345"};
string[] array2 = new string[array.Length];
void FinishedArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void WriteArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FinishedArray(array, array2);
WriteArray(array2);