namespace Api.Controllers.Users;

public record UserDTO
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public string? PhoneNumber { get; set; }
    public UserRole Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<TicketDTO> Tickets { get; set; } = [];
}
