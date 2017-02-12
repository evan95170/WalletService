using System;
using System.Collections.Generic;
using WalletKata.Users;
using WalletKata.Exceptions;

namespace WalletKata.Wallets
{
    public class WalletService
    {
        public List<Wallet> GetWalletsByUser(User user, User userWallet, bool isUserLogged)
        {
            try
            {
                User loggedUser = UserSession.GetInstance().GetLoggedUser(isUserLogged);
                bool isFriend = false;

                if (loggedUser != null)
                {
                    foreach (User friend in user.GetFriends())
                    {
                        if (!friend.Equals(userWallet)) continue;
                        isFriend = true;
                        break;
                    }

                    if (isFriend)
                    {
                        return WalletDAO.FindWalletsByUser(user);
                    }

                    return new List<Wallet>();
                }
                else
                {
                    throw new UserNotLoggedInException();
                }
            }
            catch (UserNotLoggedInException ex)
            {
                Console.WriteLine(ex.DisplayError());
                throw;
            }
            
        }         
    }
}