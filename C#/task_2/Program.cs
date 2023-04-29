using static System.Runtime.InteropServices.JavaScript.JSType;
Console.Write("Введите дату в формате 2000-MM-DD – > ");
DateTime date = Convert.ToDateTime(Console.ReadLine());
//водолей
DateTime vodnc = new DateTime(2000, 01, 20);
DateTime vodkc = new DateTime(2000, 02, 18);
//рыбы
DateTime ribnc = new DateTime(2000, 02, 19);
DateTime ribkc = new DateTime(2000, 03, 20);
//овен
DateTime ovenc = new DateTime(2000, 03, 21);
DateTime ovekc = new DateTime(2000, 04, 19);
//телец
DateTime telnc = new DateTime(2000, 04, 20);
DateTime telkc = new DateTime(2000, 05, 20);
//блезнецы
DateTime blznc = new DateTime(2000, 05, 21);
DateTime blzkc = new DateTime(2000, 06, 21);
//рак
DateTime raknc = new DateTime(2000, 06, 22);
DateTime rakkc = new DateTime(2000, 07, 22);
//лев
DateTime levnc = new DateTime(2000, 07, 23);
DateTime levkc = new DateTime(2000, 08, 22); 
//дева
DateTime devnc = new DateTime(2000, 08, 23);
DateTime devkc = new DateTime(2000, 09, 22);
//vвесы
DateTime vesnc = new DateTime(2000, 09, 23);
DateTime veskc = new DateTime(2000, 10, 22);
//скорпион
DateTime skorpnc = new DateTime(2000, 10, 23);
DateTime skorpkc = new DateTime(2000, 11, 22);
//стрелец 
DateTime strelnc = new DateTime(2000, 11, 23);
DateTime strelkc = new DateTime(2000, 12, 21);
//козерог
DateTime koznc = new DateTime(2000, 12, 22);
DateTime kozkc = new DateTime(2000, 01, 19);
//условие в if и if else - вводимая дата(date) больше либо равно начальной дате и меньше либо равно конечной дате
if (vodnc <= date && date <= vodkc)
{
    Console.WriteLine("Водолей");
}
else if (ribnc <= date && date <= ribkc)
{
    Console.WriteLine("Рыбы");
}else if (ovenc <= date && date <= ovekc)
{
    Console.WriteLine("Овен");
}
else if (telnc <= date && date <= telkc)
{
    Console.WriteLine("Телец");
}
else if (blznc <= date && date <= blzkc)
{
    Console.WriteLine("Близнецы");
}
else if (raknc <= date && date <= rakkc)
{
    Console.WriteLine("Рак");
}else if (levnc <= date && date <= levkc)
{
    Console.WriteLine("Лев");
}else if (devnc <= date && date <= devkc)
{
    Console.WriteLine("Дева");
}else if (vesnc <= date && date <= veskc)
{
    Console.WriteLine("Весы");
}else if (skorpnc <= date && date <= skorpkc)
{
    Console.WriteLine("Скорпилон");
}else if (strelnc <= date && date <= strelkc)
{
    Console.WriteLine("Стрелец");
}else if (koznc <= date && date <= kozkc)
{
    Console.WriteLine("Козерог");
}
Console.ReadLine();