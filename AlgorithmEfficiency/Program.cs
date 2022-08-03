//Наименьший общий делитель НОД Алгоритм Евклида
int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if(n > m)
        n = n - m;
    else
        m = m - n;
    Console.WriteLine(n);
    Console.WriteLine(m);
    Console.WriteLine();
}
// Наименьшее общее кратное НОК(а,в) = а*в/НОД(а,в)
Console.WriteLine(count/n);

// constant algorithm

/* int n = 0;
if (n >= 0)
    n++;
else
    n*=2; */

// linear algorithm

/* int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= n; i++)
{
    result = result * i;
}
Console.WriteLine(result); */


