Console.WriteLine("Введите размеры массива");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = new Random().Next(0,50);  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите номер позиции элемента массива :");
 int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());
 if (a>m && b>n)
 Console.WriteLine("Такого числа нет");
 else
 {
 object c = array.GetValue(a,b);
 Console.WriteLine(c);
 }



        
   
     
        

