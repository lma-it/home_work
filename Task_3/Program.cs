int from_10_to_99 = 10;
int users_try = 0;


System.Console.WriteLine("Введите число в диапазон от 10 до 99.");
from_10_to_99 = int.Parse(Console.ReadLine());

users_try++;

System.Console.WriteLine("Спасибо, выполняю проверку введенных данных...");

if(from_10_to_99 > 99 || from_10_to_99 < 10){
    System.Console.WriteLine("Вы ввели неправильное число. Хотите попробовать заново?");
    System.Console.WriteLine("Если Да, то нажмите Y, если нет, то N");

    var request_from_user = Console.ReadKey();

    if (request_from_user.KeyChar == 'y' || request_from_user.KeyChar == 'Y'){

        while((from_10_to_99 < 10 || from_10_to_99 > 99) && request_from_user.KeyChar != 'n' && request_from_user.KeyChar != 'N' && users_try < 3){

            users_try++;
            System.Console.WriteLine("\nВведите число в диапазон от 10 до 99.");
            from_10_to_99 = int.Parse(Console.ReadLine());

            if((from_10_to_99 > 99 || from_10_to_99 < 10) && users_try < 3){
                System.Console.WriteLine("Вы повторно ввели неверное число. Повторите попытку.");
            }

        }

    }else if(request_from_user.KeyChar == 'n' || request_from_user.KeyChar == 'N'){

        System.Console.WriteLine("Спасибо за внимание.");

    }
    
    if((from_10_to_99 > 99 || from_10_to_99 < 10) && users_try <= 3){

        System.Console.WriteLine("Вы использовали все ваши попытки: " + users_try + " и программа вынужденно закрылась.");

    }

}else{

    int firstNumber = from_10_to_99 / 10;
    int secondNumber = from_10_to_99 % 10;

    if(firstNumber > secondNumber){
        System.Console.WriteLine("Наибольшая цифра числа: " + from_10_to_99 + " - " + firstNumber);
    }else if(secondNumber > firstNumber){
        System.Console.WriteLine("Наибольшая цифра числа: " + from_10_to_99 + " - " + secondNumber);
    }else{
        System.Console.WriteLine("Цифры числа: " + from_10_to_99 + " равны между собой: " + firstNumber + " = " + secondNumber);
    }

}


