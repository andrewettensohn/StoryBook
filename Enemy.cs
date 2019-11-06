namespace StoryBook
{
    public class Enemy
    {
        public Goblin goblin {get; set;}
        public Enemy(string enemyType)
        {
            if(enemyType == "Goblin")
            {
                goblin = new Goblin();
            }
        }
    }
    public class Goblin
    {
        public int attack = 3;
        public int defense = 1;
        public int health = 3;
        public string actionDescription = "The goblin attacks with his shortsword!";
    }
}