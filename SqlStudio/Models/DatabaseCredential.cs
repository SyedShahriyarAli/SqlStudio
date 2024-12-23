namespace SqlStudio.Models
{
    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }

    public class DatabaseCredential
    {
        public string Name { get; set; }
        public string Subdomain { get; set; }
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string TxnSource { get; set; }
        public string Email { get; set; }
    }
}
