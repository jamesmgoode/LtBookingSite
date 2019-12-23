using LtBookingSite.Models;
using LtBookingSite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Data
{
    public class CharacterDetailsHelper : ICharacterDetailsHelper
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CharacterDetailsHelper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public CharacterDetailsViewModel GetCharacterDetailsViewModel(string email)
        {
            var character = _applicationDbContext.Characters.FirstOrDefault(c => c.EmailAddress == email) ?? new Character();

            return new CharacterDetailsViewModel
            {
                CharacterName = character.CharacterName
            };
        }

        public void SaveCharacterDetails(string email, CharacterDetailsViewModel characterDetailsViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
