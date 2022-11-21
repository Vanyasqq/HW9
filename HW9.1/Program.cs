int MassageAndConsoleINput(string msg)
{
   Console.WriteLine(msg);
   int num = int.Parse(Console.ReadLine());
   return num; 
}

bool IsNumberValid(int number)
{
    if(number < 1)
        return false;

    return true;
}

void FlipOverArray(int []array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[array.Length -i]+", ");
    }
        Console.Write(array[0]+".");
}

int N = MassageAndConsoleINput("введите натруально не меньше 1");

int[] array = new int [N]; 

if(IsNumberValid(N))
{
    for(int i=0; i<array.Length;i++)
    {
        array[i] = i+1;
    }
}
else 
{
    Console.WriteLine("не корректный ввод");
}

FlipOverArray(array);