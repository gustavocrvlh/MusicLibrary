namespace MusicLibrary.Models;

internal class Rating
{
    public Rating(int ratingValue)
    {
        if (ratingValue <= 0) ratingValue = 0;
        if (ratingValue >= 10) ratingValue = 10;
        RatingValue = ratingValue;
    }

    public int RatingValue { get; }

    public static Rating Parse(string text)
    {
        int ratingValue = int.Parse(text);
        return new Rating(ratingValue);
    }
}