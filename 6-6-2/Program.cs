namespace _6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        class User()
        {
            private string login;
            private string mail;

            public string Login
            {
                get { 
                return login;
                }
                set {
                    if (login.Length < 3)
                        Console.WriteLine("Логин должен содержать больше двух символов");
                    else login = value;
                }
            }

            public string Mail
            {
                get { return mail;}
                set
                {
                    if (mail.Contains("@"))
                        mail = value;
                    else
                        Console.WriteLine("Поле не содержит @");

                }
            }
        }
        
    }
}
