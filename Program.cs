
string [] input=new String[4] {"Hello", "2", "world",";-)"};

string [] result=new String[4]; 


void Print (string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.Write("]");
    Console.WriteLine();
}

Print (input);


 for (int j = 0; j < result.Length; j++)
{
    if (input[j].Length<=3)
    {
        result[j]=input[j];
    }
}

Print(result);

