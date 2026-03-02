Wizard wizardA = new Wizard("Villa", 5);
Wizard wizardB = new Wizard("Goblin", 10);

Console.WriteLine("Permainan dimulai...");
Console.WriteLine("Statistik awal");
wizardA.ShowStats();
wizardB.ShowStats();

string pilihan;

while (true)
{
    Console.WriteLine($"1. {wizardA.Name} Menyerang {wizardB.Name}");
    Console.WriteLine($"2. {wizardB.Name} Menyerang {wizardA.Name}");
    Console.WriteLine($"3. {wizardA.Name} melakukan heal");
    Console.WriteLine($"4. {wizardB.Name} melakukan heal");

    Console.WriteLine("\nPilihan (1/2/3/4): ");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.Attack(wizardB);
    else if (pilihan == "2") wizardB.Attack(wizardA);
    else if (pilihan == "3") wizardA.Heal();
    else if (pilihan == "4") wizardB.Heal();
    else Console.WriteLine(" Pilihan Tidak Valid");

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("Permainan berakhir");
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Energy} berhasil dikalahkan");
            Console.WriteLine($"{wizardA.Energy} keluar sebagai pemenang");
        }
        else
        {
            Console.WriteLine($"{wizardA.Energy} berhasil dikalahkan");
            Console.WriteLine($"{wizardB.Energy} keluar sebagai pemenang");
        }

        break;
    }

}

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);
//wizardA.Heal();

Console.WriteLine("Permainan Selesai...\n");
Console.WriteLine("Statistik Akhir");
wizardA.ShowStats();
wizardB.ShowStats();
public class Wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }
    public void ShowStats()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Energy : {Energy}\n");
    }

    public void Attack(Wizard enemyObj)
    {
        enemyObj.Energy -= Damage;
        Console.WriteLine($"{Name} Menyerang {enemyObj.Name}");
        Console.WriteLine($"Sisa energi {enemyObj.Name}: {enemyObj.Energy}");
    }

    public void Heal()
    {
        Energy += 5;

        if (Energy < 100)
        {
            Energy += 5;
            Console.WriteLine($"{Name} melakukan heal. sisa energy sekarang: {Energy}");
        }
        else
        {
            Energy += 5;    
        }
        Console.WriteLine($"{Name} berhasil melakukan heal. Energy meningkat mejnadi {Energy}");

    }
}
