using Adventure;

static class Chicken
{
    //attributes for chicken you challenge at end
    static public string Name = " "; //chicken/mortal enemy name
    static public string StartingConfidence = " ";
    static public int Confidence = 100;

    /// <summary>
    /// constructs chicken
    /// </summary>
    /// <param name="selectName"> Chicken name.</param>
    /// <param name="inputChickenConfidence"> The inputed confidence.</param>
    static public void MakeChicken(string selectName, string inputChickenConfidence)
    {
        Name = selectName;
        StartingConfidence = inputChickenConfidence;
        Confidence = int.Parse(inputChickenConfidence);
    }

    static public void EnemyStrengthens(int increaseScale, bool decrease = false)
    {
        if (decrease == true)
        {
            Confidence -= Game.Rand.Next(1,5) * increaseScale;
        }
        else
        {
            Confidence += Game.Rand.Next(1,5) * increaseScale;
        }
    }
}