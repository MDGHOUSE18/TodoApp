namespace TodoApp.WebApi.Dtos.Responses
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = null!;
        public DateTime ExpiresAt { get; set; }
        public string UserId { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
