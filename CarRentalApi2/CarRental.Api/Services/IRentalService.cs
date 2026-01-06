using CarRental.Api.Dto;

namespace CarRental.Api.Services
{
    public interface IRentalService
    {
        Task<RentalResultDto> CreateRentalAsync(RentalDto rentalDto);
    }
}