Console.WriteLine("podaj wysokość:");
int wysokosc = int.Parse(Console.ReadLine());
int szerokosc = 0;
for (int i = 0; i < wysokosc; i++)
{
    szerokosc++;
    Console.WriteLine();
    for (int j = 0; j < szerokosc; j++)
    {
        Console.Write(" *");
    }

}
