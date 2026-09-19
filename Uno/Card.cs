namespace Uno;

public enum CardType
{
    Number, Wild, Draw2, WildDraw4, Skip, Reverse
}

public enum Color
{
    Red, Yellow, Blue, Green, Wild
}

public class Card
{

    public CardType Type { get; set; }
    public Color Color { get; set; }
    public int? Number { get; set; }


    public static bool PlaysOn(Card card1, Card card2, Color? currentColor = null)
    {

        if (card1.Type == CardType.Wild || 
            card1.Type == CardType.WildDraw4)
        {
            return true;
        }

        if (card2.Type == CardType.Wild || 
            card2.Type == CardType.WildDraw4)
        {
            return !currentColor.HasValue || card1.Color == currentColor.Value;
        }

        if (card1.Color == card2.Color)
        {
            return true;
        }

        if (card1.Type == CardType.Number && 
            card2.Type == CardType.Number && 
            card1.Number == card2.Number)
        {
            return true;
        }

        return card1.Type == card2.Type && card1.Type != CardType.Number;
    }
    public override string ToString()
    {
        //TODO handle other card types
        switch (Type)
        {
            case CardType.Number:
                return $"{Color} {Number}";
            case CardType.Wild:
                return $"Wild";
            case CardType.Draw2:
                return $"{Color} Draw2";
            case CardType.WildDraw4:
                return $"WildDraw4";
            case CardType.Skip:
                return $"{Color} Skip";
            case CardType.Reverse:
                return $"{Color} Reverse";
            default:
                return "";
        }
    }

}