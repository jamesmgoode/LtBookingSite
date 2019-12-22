using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LtBookingSite.Data
{
    public class CharacterDetailsHelper
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CharacterDetailsHelper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


    }
}
