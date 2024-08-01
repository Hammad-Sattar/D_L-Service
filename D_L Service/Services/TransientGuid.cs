namespace D_L_Service.Services
{
    public class TransientGuid:ITransientGuid
    {
        private readonly Guid Id;
        public TransientGuid()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
