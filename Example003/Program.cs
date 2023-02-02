// See https://aka.ms/new-console-template for more information
Console.Write("Введите число а:");
int a = int.Parse(Console.ReadLine());
if(a%2 == 0){
    Console.WriteLine($" Число {a}четное");
}else{
    Console.WriteLine($" Число {a}не четное");
}
