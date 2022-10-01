// ######## ЗАДАЧА №1 ######################
Console.WriteLine("введи первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введи второе число:");
int num2 = int.Parse(Console.ReadLine()!);
if (num1>num2){
     Console.WriteLine($"max={num1}");
}
 else if (num2>num1){
     Console.WriteLine($"max={num2}");;
}