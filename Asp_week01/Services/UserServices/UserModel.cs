namespace Services
{
    public class UserModel
    {
        private static int idIncrementer = 0;
        private int idField;
        public int Id { get { return idField; } }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public UserModel()
        {
            this.idField = ++idIncrementer;
        }

    }
}