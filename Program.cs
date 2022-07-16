void Task1(){

    /*
    Напишите программу, которая с помощью деления выводит 
    третью цифру заданного числа или сообщает, что третьей цифры нет.
    */

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number);
    string result = " - третья цифра данного числа";

    while(number > 999){
        number /= 10;
    }

    if(number < 100){
        result = "Третьей цифры нет";
    }
    else{
        result = number % 10 + result;
    }

    Console.WriteLine(result);

}

void Task2(){

    /*
    Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
    и проверяет, является ли этот день выходным.
    */

    Console.Write("Введите число от 1 до 7: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = "Введено неверное число";

    string monday = "Понедельник";
    string tuesday = "Вторник";
    string wednesday = "Среда";
    string thursday = "Четверг";
    string friday = "Пятница";
    string saturday = "Суббота";
    string sunday = "Воскресенье";

    while(number > 7 || number < 1){
        Console.WriteLine(result);
        Console.Write("Введите число от 1 до 7 ещё раз: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    if(number < 8){
        result = "Не выходной день - ";
        if(number == 6 || number == 7){
            result = "Выходной день - ";
            if(number == 6){
                result += saturday;
            }
            if(number == 7){
                result += sunday ;
            }
        }
        else{
            if(number == 1){
                result += monday;
            }
            if(number == 2){
                result += tuesday;
            }
            if(number == 3){
                result += wednesday;
            }
            if(number == 4){
                result += thursday;
            }
            if(number == 5){
                result += friday;
            }
        }
    }

    Console.WriteLine(result);

}

Task1();
// Task2();
