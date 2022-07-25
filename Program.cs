//Console.WriteLine("Введите массив:");
string [] input=new String[3] {"Годный", "бывалый", "гудеж"};
string [] result=new String[3];

void Print (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");

    }
    Console.WriteLine();
}

Print (input);

// for (int i = 0; i < input.Length; i++)
// {
//     Console.Write(input[i]);
    
// }



// for (int j = 0; j < result.Length; j++)
// {
//     Console.WriteLine("Строки менее 3х символов "+ result[j]);
// }


// Console.Write(input);
