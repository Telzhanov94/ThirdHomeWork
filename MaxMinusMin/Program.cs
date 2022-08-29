void PrintArray(int[] array) 
{ 
foreach(var element in array) 
Console.Write($"{element} "); 
} 
int[] CreateArray(int size, int minimum, int maximum) 
{ 
int[] array= new int[size]; 
var random = new Random(); 
for(int i=0;i<size;i++) 
array[i] = random.Next(minimum,maximum+1); 
return array; 
} 
int MaxMin(int[] array) //Для большей универсальности можно былоб разбить на 2 отдельные функции
{   int Maxmin=0;
    int max = 0;
    int min= array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>max){max=array[i];}
        if (array[i]<min){min=array[i];}
    }
    Console.WriteLine($"Max = {max} Min = {min}");
    Maxmin=max-min;
    return Maxmin;
}
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,0,999); 
Console.Write("Your array: "); 
PrintArray(array); 
int Maxmin=MaxMin(array);
Console.WriteLine();
Console.Write ($"The difference between Max and Min is: {Maxmin}");