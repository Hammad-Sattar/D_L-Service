namespace D_L_Service.Services
{
    public class SingletonGuid:ISingletonGuid
    {
        private readonly Guid Id;
        public SingletonGuid()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
