using static System.Console;

class Factorial
{
    public void factorial()
        {
            int num = 0, factorial = 1;

            Write("Introduce un numero entero positivo: ");
            if (int.TryParse(ReadLine(), out num))
            {

                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                WriteLine("El factorial de {0} es {1}", num, factorial);
            }
            else
                WriteLine("Numero inválido");
        }
} 