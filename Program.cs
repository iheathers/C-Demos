int heroScore = 10;
int monsterScore = 10;

Random random = new Random();

while (heroScore > 0 && monsterScore > 0)
{



    int randomHeroAttack = random.Next(1, 5);
    int randomMonsterAttack = random.Next(1, 5);

    if (heroScore > 0)
    {
        monsterScore -= randomHeroAttack;
        Console.WriteLine($"Monster was damaged and lost {randomHeroAttack} health and now has {monsterScore} health.");

        if (monsterScore < 0)
        {
            Console.WriteLine("Hero Wins");
        }
    }

    if (monsterScore > 0)
    {
        heroScore -= randomMonsterAttack;
        Console.WriteLine($"Hero was damaged and lost {randomMonsterAttack} health and now has {heroScore} health.");

        if (heroScore < 0)
        {
            Console.WriteLine("Monster wins.");
        }
    }




}