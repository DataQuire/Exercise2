namespace Exercise2.Services
{
    public interface IEmailUniquenessService
    {
        Task<bool> IsEmailUniqueAsync(string email, CancellationToken ct = default);
        void RegisterEmail(string email);
        void UnregisterEmail(string email);
    }
}