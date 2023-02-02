// See https://aka.ms/new-console-template for more information

Console.Write("Введите число а:");
int a = int.Parse(Console.ReadLine());
int i = 1;
while(i<=a){
    if(i%2==0){
    Console.Write($"{i},");
    }
    i++;
}
    
