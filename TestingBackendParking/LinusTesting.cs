using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingBackendParking
{
    public partial class UnitTesting
    {
        [TestMethod]
        public void FuckOff()
        {
            Console.WriteLine("Dont run my fucking method!");
            int x = 1;
            int y = 1;

            //Assert.AreSame == minnesplats
            //Assert.AreE

            //Assert.AreSame(x, y);
            Assert.AreEqual(x, y);
        }
    }
}
