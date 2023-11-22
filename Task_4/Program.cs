int number = 8414;
int resultNumber = 1;

if (number<=10){
    Console.WriteLine($"{number}");
}
while (number>0){
    resultNumber = number%10;
    number = number/10;
    if (number>0){
        Console.Write(resultNumber + ", ");
    }
    else{
        Console.Write(resultNumber);
    }
}