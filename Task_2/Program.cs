int x;
int y;

int coordChapter = 0;

int users_try = 0;

string whereAreYou;

coordChapter = iCalculateChapterOnCoordPlane();

whereAreYou = iDrawCoordinatePlane(coordChapter);

System.Console.WriteLine(whereAreYou);






//WARNING!!! TECNICAL PART OF PROGRAM.

int iCalculateChapterOnCoordPlane(){

    System.Console.WriteLine("Вас приветствует программа вычисляющая очень сложные алгоритмы.");
    System.Console.WriteLine("Просьба проявить терпение во время вычислений, это может занять время.");
    System.Console.WriteLine("Программа ожидает ввода целочисленных значений для координаты Х...");
    System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

    x = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Программа ожидает ввода целочисленных значений для координаты Y...");
    System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

    y = int.Parse(Console.ReadLine());

    users_try++;

    if (x == 0 | y == 0){

        System.Console.WriteLine("Некорректные значения. Кооридинаты точек X и Y должны быть не равны нулю!");
        System.Console.WriteLine("Желаете повторить попытку? Нажмите Y, если Да или N, если НЕТ.");

        var request_from_user = Console.ReadKey();

        if (request_from_user.KeyChar == 'y' || request_from_user.KeyChar == 'Y'){

            while((x == 0 || y == 0) && request_from_user.KeyChar != 'n' && request_from_user.KeyChar != 'N' && users_try < 3){

                if(users_try == 2){

                    System.Console.WriteLine("Упсс! Вновь некорректные значения. Кооридинаты точек X и Y должны быть не равны нулю!");
                    System.Console.WriteLine("Желаете повторить попытку? Нажмите Y, если Да или N, если Нет.");

                    request_from_user = Console.ReadKey();

                    if(request_from_user.KeyChar == 'y' || request_from_user.KeyChar == 'Y'){

                        System.Console.WriteLine("\nПрограмма ожидает ввода целочисленных значений для координаты Х...");
                        System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

                        x = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("\nПрограмма ожидает ввода целочисленных значений для координаты Y...");
                        System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

                        y = int.Parse(Console.ReadLine());

                        users_try++;
                    }else if(request_from_user.KeyChar == 'n' || request_from_user.KeyChar == 'N'){
                        users_try = 3;
                        return 0;
                    }else{
                        users_try = 3;
                        return 0;
                    }
                }else{

                    System.Console.WriteLine("\nПрограмма ожидает целочисленных значений для координаты Х...");
                    System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

                    x = int.Parse(Console.ReadLine());

                    System.Console.WriteLine("\nПрограмма ожидает целочисленных значений для координаты Y...");
                    System.Console.WriteLine("Значения в диапазоне от " + int.MinValue + " до " + int.MaxValue);

                    y = int.Parse(Console.ReadLine());

                    users_try++;
                }

            }
            
        }else if(request_from_user.KeyChar == 'n' || request_from_user.KeyChar == 'N'){
            users_try = 3;
            return 0;
        }else{
            users_try = 3;
            return 0;
        }

    }

    //Ниже, именно то решение, которое и требовалось сделать по ДЗ,
    //но делать его просто вот так было скучно и поэтому немного разнообразия.
    if(x > 0 & y > 0){
        return 1;
    }else if( x > 0 & y < 0){
        return 4;
    }else if(x < 0 & y > 0){
        return 2;
    }else if(x < 0 & y < 0){
        return 3;
    }else{
        return 0;
    }

}

string iDrawCoordinatePlane(int coordChapter){

    int count = 0;
    if (coordChapter != 0){

        if(coordChapter == 2){

            while(count != 8){
                if (count == 3){
                    System.Console.WriteLine("     I'm here!      |");
                    count++;
                }else if(count == 4){
                    System.Console.WriteLine("         *          |");
                    count++;
                }else if(count == 5){
                    System.Console.WriteLine("     Chapter 2      |");
                    count++;
                }else{
                    Console.WriteLine("                    |");
                    count++;
                }
            }

        }else if(coordChapter == 1){

            while(count != 8){
                if (count == 3){
                    System.Console.WriteLine("                    |     I'm here!");
                    count++;
                }else if(count == 4){
                    System.Console.WriteLine("                    |         *");
                    count++;
                }else if(count == 5){
                    System.Console.WriteLine("                    |     Chapter 1");
                    count++;
                }else{
                    Console.WriteLine("                    |");
                    count++;
                }
            }
        }else{
            while(count != 8){
                System.Console.WriteLine("                    |");
                count++;
            }
        }

        count = 0;

        while(count != 21){
            Console.Write("--");
            count++;
        }

        count = 0;

        if(coordChapter == 3){

            System.Console.WriteLine(" ");
            while(count != 8){
                if (count == 3){
                    System.Console.WriteLine("     I'm here!      |");
                    count++;
                }else if(count == 4){
                    System.Console.WriteLine("         *          |");
                    count++;
                }else if(count == 5){
                    System.Console.WriteLine("     Chapter 3      |");
                    count++;
                }else{
                    Console.WriteLine("                    |");
                    count++;
                }
            }
        }else if(coordChapter == 4){

            System.Console.WriteLine(" ");

            while(count != 8){
                if (count == 3){
                    System.Console.WriteLine("                    |     I'm here!");
                    count++;
                }else if(count == 4){
                    System.Console.WriteLine("                    |         *");
                    count++;
                }else if(count == 5){
                    System.Console.WriteLine("                    |     Chapter 4");
                    count++;
                }else{
                    Console.WriteLine("                    |");
                    count++;
                }
            }
        }else{

            System.Console.WriteLine(" ");

            while(count != 8){
                System.Console.WriteLine("                    |");
                count++;
            }
        }
        
        return "\n Поздравдяю, вы нашли меня в " + coordChapter + " четверти";
    }else{
        return "\n К сожалению вы использовали все свои попытки: " + users_try + ". Работа программы заверешена.";
    }
}
