int numberToDigits = 0;
int tempNumber = 0;

System.Console.WriteLine("Введите число для разбиения числа на цифры в его составе:");
numberToDigits = int.Parse(Console.ReadLine());

if(numberToDigits < 10){
    System.Console.WriteLine("Здесь только цифра " + numberToDigits);
}else if(numberToDigits < 100){

    tempNumber = numberToDigits / 10;
    System.Console.Write(tempNumber + ", ");

    tempNumber = numberToDigits % 10;
    System.Console.Write(tempNumber + ".");

}else{//Без отладчика очень тяжело работать, поэтому в этой части кода нужные значения подбирались путем проб и ошибок.

    int countOfCapacity = 0;

    tempNumber = numberToDigits;

    while(tempNumber / 10 != 0){

        countOfCapacity++;
        tempNumber /= 10;

    }

    for(int i = countOfCapacity; i >= 0; i--){

        tempNumber = (int)(numberToDigits % Math.Pow(10, i));

        numberToDigits = (int)(numberToDigits / Math.Pow(10, i));

        if(i == 0){
            Console.Write(numberToDigits + ".");
        }else{
            Console.Write(numberToDigits + ", ");
        }

        numberToDigits = tempNumber;

    }

}