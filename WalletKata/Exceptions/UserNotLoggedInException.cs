using System;

namespace WalletKata.Exceptions
{
    public class UserNotLoggedInException : Exception
    {
        public string DisplayError()
        {
            return "The current user is not logged in";
        }
    }
}
