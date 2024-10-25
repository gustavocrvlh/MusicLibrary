namespace MusicLibrary.Models;

internal class Rating
{
    public Rating(int ratingValue)
    {
        RatingValue = ratingValue;
    }

    public int RatingValue { get; }
}