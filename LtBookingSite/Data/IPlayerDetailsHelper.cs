using LtBookingSite.Models.ViewModels;

namespace LtBookingSite.Data
{
    public interface IPlayerDetailsHelper
    {
        PlayerDetailsViewModel GetPlayerDetailsViewModel(string email);

        void SavePlayerDetails(string email, PlayerDetailsViewModel playerDetailsViewModel);
    }
}
