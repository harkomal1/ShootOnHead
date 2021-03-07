using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShootOnHead;
namespace ShootOnHead_UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        Logic Obj_Logic = new Logic();
        [TestMethod]
        public void TestMethod1()
        {
            int num_rand = Obj_Logic.Rand();
            Assert.IsTrue(num_rand < 7);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num_rand = Obj_Logic.Rand();
            Assert.IsTrue(num_rand > 0 );
        }
    }
}
