namespace WalletKata.Users
{
    public class UserSession
    {
        private static readonly UserSession _userSession = new UserSession();

        private UserSession() { }

        public static UserSession GetInstance()
        {
            return _userSession;
        }

        public User GetLoggedUser(bool isUserLogged)
        {
            return isUserLogged ? new User() : null;
        }
    }
}