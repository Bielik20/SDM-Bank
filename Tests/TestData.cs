using BankingSystem.ClassLib;
using System.Collections.Generic;

namespace Test
{
    public static class TestDataClass
    {
        private static readonly List<object[]> _data
            = new List<object[]>
                {
                    new object[] { new DebitAccount(new Account("96249000055837397999610889", 140000)),  new Bank(1020)},
                    new object[] { new DebitAccount(new Account("65249000052432307916340798", 1400)), new Bank(400)},
                    new object[] { new Account("44102000038758212314035006", 2000), new Bank(700)},
                    new object[] { new Account("86249000056109003464828622", 5210), new Bank(900) }
                };

        public static IEnumerable<object[]> TestData
        {
            get { return _data; }
        }
    }
}
