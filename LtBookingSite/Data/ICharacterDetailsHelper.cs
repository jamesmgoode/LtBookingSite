using LtBookingSite.Models.ViewModels;

namespace LtBookingSite.Data
{
    public interface ICharacterDetailsHelper
    {
        CharacterDetailsViewModel GetCharacterDetailsViewModel(string email);

        void SaveCharacterDetails(string email, CharacterDetailsViewModel characterDetailsViewModel);
    }
}
