using System.Threading.Tasks;
using CarRental.Api.Data;
using CarRental.Api.Dto;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Api.Services
{

    public class RentalService : IRentalService
    {
        private readonly AppDbContext _context;

        public RentalService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<RentalResultDto> CreateRentalAsync(RentalDto rentalDto)
        {
            if (rentalDto.StartDate >= rentalDto.EndDate)
                return new RentalResultDto { Success = false, Error = "Invalid rental period." };

            var car = await _context.Cars.FindAsync(rentalDto.CarId);
            if (car == null)
                return new RentalResultDto { Success = false, Error = "Car not found." };

            bool isCarAvailable = !await _context.Rentals.AnyAsync(r =>
                r.CarId == rentalDto.CarId &&
                (
                    (rentalDto.StartDate >= r.StartDate && rentalDto.StartDate < r.EndDate) ||
                    (rentalDto.EndDate > r.StartDate && rentalDto.EndDate <= r.EndDate) ||
                    (rentalDto.StartDate <= r.StartDate && rentalDto.EndDate >= r.EndDate)
                ));

            if (!isCarAvailable)
                return new RentalResultDto { Success = false, Error = "Car is not available for the selected period." };

            var totalDays = (rentalDto.EndDate - rentalDto.StartDate).Days;
            if (totalDays <= 0)
                return new RentalResultDto { Success = false, Error = "Rental must be at least one day." };

            var totalPrice = totalDays * car.Price;

            var rental = new Rental
            {
                UserId = rentalDto.UserId,
                CarId = rentalDto.CarId,
                StartDate = rentalDto.StartDate,
                EndDate = rentalDto.EndDate,
                Price = totalPrice
            };

            _context.Rentals.Add(rental);
            await _context.SaveChangesAsync();

            return new RentalResultDto
            {
                Success = true,
                Rental = rental,
                TotalPrice = totalPrice
            };
        }
    }
}