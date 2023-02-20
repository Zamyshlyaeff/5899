// Написать программу, которая обменивает элементы первой строки и последней строки
int [,] a=new int [3,3] {{5,4,3},{2,8,5},{9,6,1}};
int [,] OBMEN(int [,]a)
{
    for (int i=0;i<1;i++)
    { int k=0;
    for (int j=0;j<a.GetLength(1);j++)
    {   
        k=a[i,j];
        // Console.WriteLine($"{k}");
        a[i,j]=a[a.GetLength(0)-1,j];
        a[a.GetLength(0)-1,j]=k;
    }
    }
    return a;

}
void PRINT(int [,]a)
{
  for (int i=0;i<a.GetLength(0);i++)
  {
    for (int j=0;j<a.GetLength(1);j++)
    Console.Write($"{a[i,j], 5}");
    Console.WriteLine();
  }
}
OBMEN(a);
PRINT(a);