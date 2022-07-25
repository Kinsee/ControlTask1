//Console.WriteLine("Введите массив:");
string [] input=new String[3] {"Гоgh", "бывалый", "гудb"};

// 2 варианта адания массива
//string [] result=new String[3]; 
string[] result = new string[0]; 

void Print (string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + ";");

    }
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
// Console.Write(input);
