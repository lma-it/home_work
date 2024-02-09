//Написать программу, которая будет определять кратность вводимого числа на 7 и 23

System.Console.WriteLine("Пожалуйста, ниже введите число, кратность которого хотите проверить:");
int number = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Спасибо за доверие, я незамедлительно проверю ваше число.");

if (number % 7 == 0 & number % 23 == 0){
    System.Console.WriteLine("Число кратно числам 7 и 23");
}else{
    if (number % 7 != 0){
        System.Console.Write("Число не кратно числу 7, остаток от деления равен: " + number % 7 + " ");
    }
    if (number % 23 != 0){
        System.Console.Write("Число не кратно числу 23, остаток от деления равен: " + number % 23 + " ");
    }
}
    