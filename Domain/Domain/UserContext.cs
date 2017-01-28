namespace Domain.Domain
{
    public class UserContext
    {
        public string UserId { get; set; }

        public override string ToString()
        {
            return "UserContext [UserId = " + UserId + " ]";
        }
    }
}