using LtBookingSite.Models;
using LtBookingSite.Models.ViewModels;

namespace LtBookingSite.Data
{
    public class PlayerDetailsHelper
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public PlayerDetailsHelper(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public PlayerDetailsViewModel GetPlayerDetailsViewModel(string email)
        {
            var player = _applicationDbContext.Players.Find(email) ?? AddNewPlayer(email);
            var medicalDetails = _applicationDbContext.MedicalDetails.Find(player.MedicalDetailsId) ?? new MedicalDetails();

            return new PlayerDetailsViewModel
            {
                FirstName = player.FirstName,
                LastName = player.LastName,
                PlayerId = player.PlayerId,
                DateOfBirth = player.DateOfBirth,
                EmergencyContactName = medicalDetails.EmergencyContactName,
                EmergencyContactPhoneNumber = medicalDetails.EmergencyContactPhoneNumber,
                Notes = medicalDetails.Notes
            };
        }

        public void SavePlayerDetails(string email, PlayerDetailsViewModel playerDetailsViewModel)
        {
            var player = _applicationDbContext.Players.Find(email) ?? AddNewPlayer(email);
            var medicalDetails = _applicationDbContext.MedicalDetails.Find(player.MedicalDetailsId) ?? AddNewMedicalDetails();

            player.FirstName = playerDetailsViewModel.FirstName;
            player.LastName = playerDetailsViewModel.LastName;
            player.DateOfBirth = playerDetailsViewModel.DateOfBirth.Value;
            player.PlayerId = playerDetailsViewModel.PlayerId;
            player.MedicalDetailsId = medicalDetails.MedicalDetailsId;

            _applicationDbContext.Players.Update(player);

            medicalDetails.EmergencyContactName = playerDetailsViewModel.EmergencyContactName;
            medicalDetails.EmergencyContactPhoneNumber = playerDetailsViewModel.EmergencyContactPhoneNumber;
            medicalDetails.Notes = playerDetailsViewModel.Notes;

            _applicationDbContext.MedicalDetails.Update(medicalDetails);

            _applicationDbContext.SaveChanges();
        }

        private Player AddNewPlayer(string email)
        {
            var medicalDetails = _applicationDbContext.MedicalDetails.Add(new MedicalDetails()).Entity;
            var player = new Player { EmailAddress = email, MedicalDetailsId = medicalDetails.MedicalDetailsId };
            _applicationDbContext.Players.Add(player);
            
            _applicationDbContext.SaveChanges();

            return player;
        }

        private MedicalDetails AddNewMedicalDetails()
        {
            var medicalDetails = _applicationDbContext.MedicalDetails.Add(new MedicalDetails { EmergencyContactName = "", EmergencyContactPhoneNumber = "" }).Entity;

            _applicationDbContext.SaveChanges();

            return medicalDetails;
        }
    }
}
