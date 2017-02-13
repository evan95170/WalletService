using System.Collections.Generic;
using System.Linq;
using WalletKata.Users;

namespace WalletKata.Wallets
{
    public interface IWalletDao
    {
        List<Wallet> FindWalletsByUser(User user);
    }

    public class WalletDao : IWalletDao
    {
        public List<Wallet> FindWalletsByUser(User user)
        {
            return user.GetWallets().ToList();
            //throw new ThisIsAStubException("WalletDAO.FindWalletsByUser() should not be called in an unit test");
        }
    }
}