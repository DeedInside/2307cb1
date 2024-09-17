namespace _2307cb1.Model
{
    /// <summary>
    /// public commit
    /// </summary>
    public class User
    {
        /// <summary>
        /// commit
        /// </summary>
        /// <param name="name">commit params 1</param>
        /// <param name="email">commit params 2</param>
        /// <param name="password">commit params 3</param>
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        /// <summary>
        ///  indentity user
        /// </summary>
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{Name} - {Email} - {Email} - {Password}";
        }
    }
}
