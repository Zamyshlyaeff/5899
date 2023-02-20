/*В двумерном массиве заменить элементы, у которых оба индекса чётные на
 их квадраты по значению.*/
int[,] a=new int[5,3] {{1,2,3},{2,3,5},{4,9,8},{2,5,1},{2,5,8}};
int[,] KVADRAT(int[,]a)
{ for (int i=0;i<a.GetLength(0);i++)
  { for (int j=0;j<a.GetLength(1);j++)
  if (j%2==0 && i%2==0)
   { 
    a[i,j]=a[i,j]*a[i,j];
   
   }
   }
   return a;
}
void PRINT(int[,]a)
{ for (int i=0;i<a.GetLength(0);i++)
 {
    for (int j=0;j<a.GetLength(1);j++)
    Console.Write($"{a[i,j], 5}");
    Console.WriteLine();
 }
}
int[,]b=KVADRAT(a);
PRINT(b);