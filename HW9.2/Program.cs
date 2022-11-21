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


int M = MassageAndConsoleINput("Введите первое натрульно число");

int N = MassageAndConsoleINput("Введите второе натрульно число");
int count = 0;
if(IsNumberValid(M) & IsNumberValid(N))
{
    if(M<N) // что бы работало даже если второе введеное число больше, ведь нам нужна сумма промежутка
    {
        for(int i=M;i<=N;i++)
        {
            count = count + i;
        }
        Console.WriteLine(count);
    }
    else
    {
        for(int i=N;i<=M;i++)
        {
            count = count + i;
        }
        Console.WriteLine(count);
    }
}
else
{
    Console.WriteLine("ввели не натуральное число");
}