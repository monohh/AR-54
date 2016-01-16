using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AR_54.Common.Model;

namespace AR_54.Test.Core
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Unit_Creation_Valid_HP()
        {
            string Ident = "Unit Name";
            int HP = 100;

            try
            {
                Unit Dummy = new DummyUnit(Ident, HP);
            } catch(ArgumentException ae)
            {
                Assert.Fail("Expected no exception, but got: " + ae.Message);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid HP value: -1")]
        public void Test_Unit_Creation_InValid_HP()
        {
            string Ident = "Unit Name";
            int HP = -1;

            Unit Dummy = new DummyUnit(Ident, HP);
            

        }
    }

    class DummyUnit : Unit
    {

        public DummyUnit(string ident, int hp): base(ident, hp)
        {
            
        }

    }
    
}
