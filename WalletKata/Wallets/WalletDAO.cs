using System.Collections.Generic;
using WalletKata.Exceptions;
using WalletKata.Users;

namespace WalletKata.Wallets
{
    public class WalletDAO
    {
        public static List<Wallet> FindWalletsByUser(User user)
        {
            //Mocking two wallets
            return new List<Wallet> {new Wallet {Label = "Wallet1"}, new Wallet {Label = "Wallet2"}};
        }
    }
}