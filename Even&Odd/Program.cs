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
int Even(int[] array)
{
int CountEven=0;
    for (int i=0;i<array.Length;i++)
        {
        if (array[i]%2==0) 
        {CountEven++;}
        }
    return CountEven;   
}
int Odd(int[] array)
{
    int CountOdd=0;
    for (int i=0; i<array.Length;i++)
    {
       if (array[i]%2!=0) 
   {CountOdd++;}
    }
    return CountOdd;

}
Console.Write("Enter size of array: " ); 
int size = int.Parse(Console.ReadLine() ?? "0"); 
int[] array = CreateArray(size,100,999); 
Console.Write("Your array: "); 
PrintArray(array); 
var even = Even(array);
var odd = Odd(array);
Console.WriteLine();
Console.WriteLine ($"Number of even numbers: {even} Number of odd numbers {odd}");