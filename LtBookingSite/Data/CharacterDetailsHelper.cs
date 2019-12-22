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
            throw new NotImplementedException();
        }

        public void SaveCharacterDetails(string email, CharacterDetailsViewModel characterDetailsViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
