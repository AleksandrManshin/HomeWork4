void MathPow()
{
    Console.Write("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {A} в степни {B} равно {Math.Pow(A, B)}");
}
MathPow();