using MyVaccine.WebApi.Dtos;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Services.Contracts;

public interface IUserService
{
    Task<AuthRespondeDto> AddUserAsync(RegisterRequetDto request);
    Task<AuthRespondeDto> Login(LoginRequestDto request);
    Task<AuthRespondeDto> RefreshToken(string email);
    Task<User> GetUserInfo(string email);





}

