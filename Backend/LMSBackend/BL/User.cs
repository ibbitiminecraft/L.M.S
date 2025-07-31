namespace libary.classes
{
    public class User
    {

        public static List<User> _userlist = new List<User>
        {
            new User{Username = "ibrahim" ,Age = 9,Password = "1234"},
            new User{Username = "dede" ,Age = 3,Password = "1234"},
            new User{Username = "adan" ,Age = 7,Password = "1234"},
            new User{Username = "mama" ,Age = 38,Password = "1234"}
        };


        public string? Username { get; set; }
        public string? Password { get; set; }
        public int Age { get; set; }



        public static bool Iscorrect(string username, string password)
        {
            foreach (var user in _userlist)
            {
                if (username == user.Username && password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}