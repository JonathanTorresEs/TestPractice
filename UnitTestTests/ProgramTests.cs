using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void HashTest()
        {
            Assert.AreEqual(Program.Hash("leepadg"), 680131659347);
        }
    }
}