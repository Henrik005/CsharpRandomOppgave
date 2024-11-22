Random rand = new Random();
var randomnNumber = rand.Next(0, 6);
var isRunning = true;
var name = Console.ReadLine();
void RandomHobby()
{

 
        switch (randomnNumber)
        {
            case 0:
                Console.WriteLine($"{name} is now a proffesional griddy hitter!!");
                break;
            case 1:
                Console.WriteLine($"Believe it or not, but {name}'s become the Real Slim Shady");
                break;
            case 2:
                Console.WriteLine($"{name} now enjoys playing League of Legends...a moment of silence...");
                break;
            case 3:
                Console.WriteLine($"{name} is now a minecraft streamer!");
                break;
            case 4:
                Console.WriteLine($"{name} is now a crayfish expert!!!");
                break;
            case 5:
                Console.WriteLine($"{name} is now a painter, let's hope they don't get rejected by art school!");
                break;

        }

}
RandomHobby();