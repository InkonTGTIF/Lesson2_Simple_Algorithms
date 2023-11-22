int number = 61;

int firstNumber = number /10;
int secondNumer = number % 10;
int maxNumber = number;

if (number>99){
    Console.WriteLine($"Число должно быть меньше 99");
}
else if(firstNumber<secondNumer){
    Console.WriteLine($"{secondNumer}");
}
else {
    Console.WriteLine($"{firstNumber}");
}