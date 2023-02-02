// See https://aka.ms/new-console-template for more information

Console.Write("Ввведите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ввведите число b: ");
int b = int.Parse(Console.ReadLine());
int max;
if(a>b){
    Console.WriteLine($"max = {a} min={b}");

}else{
     Console.WriteLine($"max = {b} min={a}");
}
Console.Clear();
Console.Clear();
