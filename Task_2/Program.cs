int x = 1;
int y = 1;

if (x>0 && y>0){
    Console.WriteLine($"№1");
}
else if (x<0 && y>0){
    Console.WriteLine($"№2");
}
else if (x<0 && y<0){
    Console.WriteLine($"№3");
}
else if (x>0 && y<0){
    Console.WriteLine($"№4");
}