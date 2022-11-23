int[] CreatArray()
{
    int[] ints = new int[8];
    Random random = new Random();
    for (int i = 0; i < ints.Length; i++) { ints[i] = random.Next(); }
return ints;
}

string GetArrayAsString(int[] array) 
{
    string resalt = "";
    for (int i = 0; i < array.Length; i++)
    {
        resalt += $"{array[i].ToString()}, ";
    }

    return resalt;  
}

Console.WriteLine(GetArrayAsString(CreatArray()));