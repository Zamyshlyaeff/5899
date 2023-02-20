//Показать двумерный массив размером m×n заполненный целыми случайными числами
int [,] Massiv2D(int n, int m, int min, int max)
{   int [,] a=new int[n,m];
    Random random=new Random();
    for (int i=0;i<a.GetLength(0);i++)
    {
    for (int j=0;j<a.GetLength(1);j++)
      
          a[i,j]=random.Next(min,max);
    }
    return a; 
}
void PRINT2D(int [,]a)
{
  for (int i=0;i<a.GetLength(0);i++)
   { for (int j=0;j<a.GetLength(1);j++)
    
        System.Console.Write($"{a[i,j], 5}");
        System.Console.WriteLine();

   }
}
int [,]a=Massiv2D(5,4,1,10);
PRINT2D(a);