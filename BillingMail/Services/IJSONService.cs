namespace BillingMail.Services
{
    public interface IJSONService
    {
        public T Deserialize<T>(string json);

        public string Serialize<T>(T data);
    }
}
