int MassageAndConsoleINput(string msg)
{
   Console.WriteLine(msg);
   int num = int.Parse(Console.ReadLine());
   return num; 
}

bool IsNumberValid(int number)
{
    if(number < 0)
        return false;

    return true;
}

int M = MassageAndConsoleINput("ВВедите M");
int N = MassageAndConsoleINput("ВВедите N");


///Метод вычисления функции Аккермана:
int AckermannFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
return AckermannFunction(M, N);
}


if(IsNumberValid(N) & IsNumberValid(M))
{
   Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}"); 
}
else
{
    Console.WriteLine("ошибка");
}