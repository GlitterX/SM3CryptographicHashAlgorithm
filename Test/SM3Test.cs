using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SM3CryptographicHashAlgorithm;

namespace Test
{
    [TestClass]
    public class SM3Test
    {
        [TestMethod]
        public void TestCreate()
        {
            var sm3 = SM3.Create("SM3");
            var source = "abc";
            var hashBytes = sm3.ComputeHash(Encoding.ASCII.GetBytes(source));
            var result = BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
            Assert.AreEqual("66c7f0f462eeedd9d1f2d46bdc10e4e24167c4875cf2f7a2297da02b8f4ba8e0", result);
        }
    }
}
