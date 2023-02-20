/* В двумерном массиве n×k заменить четные элементы на противоположные 
по значению (a[i,j]=-a[i,j]). Написать отдельную */
int [,] INIT(int n, int k, int min, int max)
{   int[,]a=new int[n,k];
    Random random=new Random();
 for (int i=0;i<a.GetLength(0);i++)
 {
    for (int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(min,max);
}
return a;
}
int [,] MINUS(int[,]a) 
{  
 for (int i=0;i<a.GetLength(0);i++)
 {
    for (int j=0;j<a.GetLength(1);j++)
    a[i,j]=a[i,j]*(-1);
}
    return a;
}
void WRITE(int[,]a)
{ for (int i=0;i<a.GetLength(0);i++)
   { for (int j=0;j<a.GetLength(1);j++)
   Console.Write($"{a[i,j], 5}");
   Console.WriteLine();
   }
}

int[,]a=INIT(6,3,4,13);
MINUS(a);
WRITE(a);