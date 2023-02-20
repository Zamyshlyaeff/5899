/* Показать двумерный массив размером m×n заполненный вещественными
 случайными числами */
double [,] PRINT2D(int m, int n, int min, int max)
{  double[,]a=new double[m,n];
Random random=new Random();
 for(int i=0;i<a.GetLength(0);i++)
  { for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(min,max)/1.5;
       
  }
  return a;
}
void PRINT(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
  { for(int j=0;j<a.GetLength(1);j++)
     System.Console.Write($"{a[i,j], 5}");
     System.Console.WriteLine();
}
}
double[,] a=PRINT2D(5,4,5,10);
PRINT(a);
