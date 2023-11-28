namespace MyVaccine.WebApi.Dtos;

public class AuthRespondeDto
{
    public String Token { get; set; }
    public DateTime Expiration { get; set; }
    public bool IsSuccess { get; set; }
    public String[] Errors { get; set; }
}

