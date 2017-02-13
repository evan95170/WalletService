using WalletKata.Exceptions;

namespace WalletKata.Users
{
    public class UserSession
    {
        public static UserSession GetInstance()
        {
            return new UserSession();
        }

        public User GetLoggedUser()
        {
            throw new ThisIsAStubException("UserSession.IsUserLoggedIn() should not be called in an unit test");
        }
    }
}