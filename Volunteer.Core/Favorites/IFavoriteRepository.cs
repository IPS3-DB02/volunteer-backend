namespace Volunteer.Core.Favorites
{
    public interface IFavoriteRepository
    {
        Favorite GetFavorite(int Id);
        IEnumerable<Favorite> GetFavorites(string UserId);
        Favorite AddFavorite(Favorite favorite);
        Favorite RemoveFavorite(Favorite favorite);
    }
}
