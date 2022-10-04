/*/
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

/*/

Console.WriteLine("Введите день недели");
int A = int.Parse(Console.ReadLine());

if (A > 0 && A < 8)
    if (A == 6 || A == 7) Console.WriteLine("да"); else Console.WriteLine("нет");
else Console.WriteLine("Неверный день недели");


/*/
bool [] Days={false,false,false,false,false,true,true};
if (A>0 && A<8)
 if (Days[A-1]) Console.WriteLine("да"); else Console.WriteLine("нет");
else Console.WriteLine("Неверный день недели");
/*/



