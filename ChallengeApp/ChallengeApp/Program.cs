﻿string name = "Blazej";
int age = 26;
char sex = 'M';

if (sex == 'K')
{
    Console.WriteLine("Kobieta poniżej 30 lat.");

}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30.");

}
else if (sex == 'M' && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}