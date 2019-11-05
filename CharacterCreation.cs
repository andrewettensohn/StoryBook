namespace StoryBook
{
    public class CharacterCreation
    {
        public static void NewCharacter()
        {
            System.Console.Write("Character Name: ");
            var characterName = System.Console.ReadLine();
            var player = new Player(characterName);
            System.Console.WriteLine($"Created new player {player.name}");
            LevelOutside.TombEntrance(player);
        }
    }

}