namespace MusicLibrary.Models;

internal interface IRetable
{
    void Rate(Rating ratingValue);
    double AverageRating { get; }
}