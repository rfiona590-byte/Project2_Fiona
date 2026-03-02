/*this is an extreamly dumb way to make the items work, because its going to be a pain to impliment new items and even 
a bit of a pain to edit current items, but im pretty sure this is the end of the project and I dont have the brainpower
to work out a better way to do so... */
using System.Collections;

static public class Item
{
    public static int maisyBonusConfidence = 0;
    public static int chickenBonusConfidence = 0;
    public static int confidenceScaler = 0;
    public static int chickenConfidenceScaler = 0;
    public static int itemFreshness = 0;

    /// <summary>
    /// changes maisy's item to an selected item. also refreshes item freshness.
    /// </summary>
    /// <param name="newItem"> An int relating to the selected item, if there is not a valid assisiated item, or the item number is 0, it selects "no item"</param>
    static public void ChangeItem(int newItem)
    {
    maisyBonusConfidence = 0;
    chickenBonusConfidence = 0;
    confidenceScaler = 0;
    chickenConfidenceScaler = 0;
    itemFreshness = 0;

        switch (newItem)
        {
            case 1:
                // stick
                confidenceScaler = 2;
                itemFreshness = 1;
                break;
            case 2:
                // old shoe
                maisyBonusConfidence = 5;
                break;
            case 3:
                // strange egg
                maisyBonusConfidence = 10;
                chickenBonusConfidence = 2;
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// runs after each action. if the current item has been held for more than 4 actions, makes the chicken gain twice as much confidence.
    /// </summary>
    public static void ItemStaleing()
    {
        itemFreshness ++;

        if (itemFreshness >= 4)
        {
            chickenConfidenceScaler = 2;
        }
    }
}