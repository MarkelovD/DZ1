// ######## ЗАДАЧА №1 ######################
// Console.WriteLine("введи первое число:");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введи второе число:");
// int num2 = int.Parse(Console.ReadLine()!);
// if (num1>num2){
//      Console.WriteLine($"max={num1}");
// }
//  else if (num2>num1){
//      Console.WriteLine($"max={num2}");;
// }
//######## ЗАДАЧА №2 ######################

Console.WriteLine("введи первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи второе число:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи третье число:");
int num3 = int.Parse(Console.ReadLine()!);
if (num1>num2 & num1>num3){
    Console.WriteLine($"max={num1}");;
}
else if (num2>num1 & num2>num3){
    Console.WriteLine($"max={num2}");
}
else if (num3>num1 & num3>num2){
    Console.WriteLine($"max={num3}");
 }