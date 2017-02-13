using System.Collections.Generic;
using System.Linq;
using WalletKata.Users;
using WalletKata.Exceptions;

namespace WalletKata.Wallets
{
    public class WalletService
    {
        private User _loggedUser => UserSession.GetInstance().GetLoggedUser();

        public List<Wallet> GetWalletsByUser(User user, WalletDao walletDao)
        {
            if (_loggedUser != null)
            {
                return user.GetFriends().Contains(_loggedUser) ? walletDao.FindWalletsByUser(user) : new List<Wallet>();
            }
            else
            {
                throw new UserNotLoggedInException();
            }      
        }         
    }
}