using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WalletKata.Users;
using WalletKata.Wallets;

namespace WalletKata.Test
{
    public class WalletServiceTest
    {
        [Test] 
        public void TestCase1()
        {
            var user1 = new User();
            var user2 = new User();
            var walletService = new WalletService();
            walletService.GetWalletsByUser(user2, user1, false); //false because user2 not logged
        }

        [Test]
        public void TestCase2()
        {
            //User1 and User2 are not friends
            var walletsEmpties = new List<Wallet>();
            var user1 = new User();
            var user2 = new User();
            var walletService = new WalletService();
            var wallets = walletService.GetWalletsByUser(user2, user1, true); //true because user2 is logged
            Assert.AreEqual(wallets, walletsEmpties, "OK");
        }

        [Test]
        public void TestCase3()
        {
            //User1 and User2 are friends
            var walletsMocked = new List<Wallet> {new Wallet {Label = "Wallet1"}, new Wallet {Label = "Wallet2"}};
            var user1 = new User();
            var user2 = new User();
            user2.AddFriend(user1);
            var walletService = new WalletService();
            var wallets = walletService.GetWalletsByUser(user2, user1, true);//true because user2 is logged
            Assert.AreEqual(wallets.Select(s => s.Label), walletsMocked.Select(s => s.Label), "OK");
        }
    }
}
