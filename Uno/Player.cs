namespace Uno;

public class Player
{
    public string Name { get; set; } = "";

    public List<Card> Hand { get; set; } = new();

    public bool HasPlayableCard(Card card)
    {
        foreach (Card handCard in Hand)
        {
            if (Card.PlaysOn(handCard, card))
            {
                return true;
            }
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (Card handCard in Hand)
        {
            if (Card.PlaysOn(handCard, card))
            {
                return handCard;
            }
        }
        return null;
    }

    public Color MostCommonColor()
    {
        int red = 0;
        int yellow = 0;
        int blue = 0;
        int green = 0;

        foreach (Card card in Hand)
        {
            switch (card.Color)
            {
                case Color.Red:
                    red++;
                    break;
                case Color.Yellow:
                    yellow++;
                    break;
                case Color.Blue:
                    blue++;
                    break;
                case Color.Green:
                    green++;
                    break;
            }
        }

        if (red >= yellow && red >= blue && red >= green)
        {
            return Color.Red;
        }
        else if (yellow >= blue && yellow >= green)
        {
            return Color.Yellow;
        }
        else if (blue >= green)
        {
            return Color.Blue;
        }
        else
        {
            return Color.Green;
        }
    }



}