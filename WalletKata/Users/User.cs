using System.Collections.Generic;
using WalletKata.Wallets;

namespace WalletKata.Users
{
    public class User
    {
        private readonly List<User> _friends = new List<User>();
        private readonly List<Wallet> _wallets = new List<Wallet>();

        public IEnumerable<User> GetFriends()
        {
            return _friends;
        }

        public IEnumerable<Wallet> GetWallets()
        {
            return _wallets;
        }

        public void AddFriend(User friend)
        {
            _friends.Add(friend);
        }
    }
}