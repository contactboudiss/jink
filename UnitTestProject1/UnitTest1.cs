using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;


using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expect= "boudiss";
        [TestMethod]
        public void TestMethod1()
        {

            using(var a =new StringWriter())
                {


                Console.SetOut(a);
                jinkinistest.Program.Main();

                var result = a.ToString().Trim();


                Assert.AreEqual(Expect,result);
            }


        }
    }
}
