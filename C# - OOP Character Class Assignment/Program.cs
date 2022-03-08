using System;
public class character
{
    // TASK ONE //
    // Variables
    public string name, phraseOne, phraseTwo;
    public int level;
    // Class Constructor
    public character (string newName, string newPhraseOne, string newPhraseTwo)
    {
        this.name = newName;
        this.phraseOne = newPhraseOne;
        this.phraseTwo = newPhraseTwo;
        this.level = 0;
    }
    // Make Character Speak Method
    public void speak (int phraseNum)
    {
        if (phraseNum == 1)
        {
            Console.WriteLine(this.phraseOne);
        } else if (phraseNum == 2)
        {
            Console.WriteLine(this.phraseTwo);
        }
    }
    // Set New Level Method
    public void setLevel (int newCharlevel)
    {
        this.level = newCharlevel;
        Console.WriteLine("level " + this.level);
    }
    // Main Method
    public static void Main(string[] args)
    {
        // TASK TWO //
        var charOne = new character("Batman", "I'm vengeance", "Fear is a tool");
        var charTwo = new character("Garfield", "I hate mondays", "I love lasagna");

        // TASK THREE //
        charOne.speak(1);
        charOne.setLevel(2);
        charTwo.speak(2);
    }
}