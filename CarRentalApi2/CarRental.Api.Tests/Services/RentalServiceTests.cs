using Xunit;
using CarRental.Api.Data;
using CarRental.Api.Services;
using CarRental.Api.Dto;
using CarRental.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

public class RentalServiceTests
{
    private AppDbContext GetDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        return new AppDbContext(options);
    }

    [Fact]
    public async Task CreateRentalAsync_ReturnsError_WhenPeriodInvalid()
    {
        using var context = GetDbContext();
        var service = new RentalService(context);

        var rentalDto = new RentalDto
        {
            CarId = 1,
            UserId = 1,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddDays(-1)
        };

        var result = await service.CreateRentalAsync(rentalDto);

        Assert.False(result.Success);
        Assert.Equal("Invalid rental period.", result.Error);
    }

    [Fact]
    public async Task CreateRentalAsync_ReturnsError_WhenCarNotFound()
    {
        using var context = GetDbContext();
        var service = new RentalService(context);

        var rentalDto = new RentalDto
        {
            CarId = 999,
            UserId = 1,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddDays(2)
        };

        var result = await service.CreateRentalAsync(rentalDto);

        Assert.False(result.Success);
        Assert.Equal("Car not found.", result.Error);
    }

    [Fact]
    public async Task CreateRentalAsync_ReturnsError_WhenCarNotAvailable()
    {
        using var context = GetDbContext();
        context.Cars.Add(new Car { Id = 1, Brand = "Ford", Model = "Fiesta", Price = 100, Year = 2024 });
        context.Rentals.Add(new Rental
        {
            CarId = 1,
            UserId = 2,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddDays(3),
            Price = 300
        });
        await context.SaveChangesAsync();

        var service = new RentalService(context);

        var rentalDto = new RentalDto
        {
            CarId = 1,
            UserId = 1,
            StartDate = DateTime.Today.AddDays(1),
            EndDate = DateTime.Today.AddDays(2)
        };

        var result = await service.CreateRentalAsync(rentalDto);

        Assert.False(result.Success);
        Assert.Equal("Car is not available for the selected period.", result.Error);
    }

    [Fact]
    public async Task CreateRentalAsync_ReturnsSuccess_WhenRentalIsValid()
    {
        using var context = GetDbContext();
        context.Cars.Add(new Car { Id = 1, Brand = "Ford", Model = "Fiesta", Price = 100, Year = 2024 });
        await context.SaveChangesAsync();

        var service = new RentalService(context);

        var rentalDto = new RentalDto
        {
            CarId = 1,
            UserId = 1,
            StartDate = DateTime.Today,
            EndDate = DateTime.Today.AddDays(2)
        };

        var result = await service.CreateRentalAsync(rentalDto);

        Assert.True(result.Success);
        Assert.NotNull(result.Rental);
        Assert.Equal(200, result.TotalPrice);
        Assert.Equal(rentalDto.CarId, result.Rental.CarId);
        Assert.Equal(rentalDto.UserId, result.Rental.UserId);
    }
}