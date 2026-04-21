namespace Exercise2.Services
{
    public class MockEmailUniquenessService : IEmailUniquenessService
    {
        private readonly HashSet<string> _takenEmails = new(StringComparer.OrdinalIgnoreCase)
        {
            "taken@example.com",
            "admin@example.com"
        };

        public async Task<bool> IsEmailUniqueAsync(string email, CancellationToken ct = default)
        {
            await Task.Delay(600, ct);
            return !_takenEmails.Contains(email);
        }

        public void RegisterEmail(string email)
        {
            _takenEmails.Add(email);
        }

        public void UnregisterEmail(string email)
        {
            _takenEmails.Remove(email);
        }
    }
}