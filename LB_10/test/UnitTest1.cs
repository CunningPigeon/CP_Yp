using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LB_10;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            LB_10.Program.Product Sheep = new LB_10.Program.Product();
            Sheep.Move();
            Sheep.Examination();
        }

        [TestMethod]
        public void TestMethod2()
        {
            LB_10.Program.Party Cow = new LB_10.Program.Party();
            Cow.Move();
            Cow.Examination();
        }

        [TestMethod]
        public void TestMethod3()
        {
            LB_10.Program.Kit Box = new LB_10.Program.Kit();
            Box.Move();
            Box.Examination();
        }

        [TestMethod]
        public void TestMethod4()
        {
            LB_10.Program.Product Sheep = new LB_10.Program.Product();
            Sheep.Name = "Мясо";
            Sheep.cost = 5;
            Sheep.quantity = 12; // кол-во
            Sheep.time = "12.12.2024";
            Sheep.timeI = 2;

            Sheep.Move();
            Sheep.Examination();
        }

        [TestMethod]
        public void TestMethod5()
        {
            LB_10.Program.Product Sheep = new LB_10.Program.Product();
            LB_10.Program.Party Cow = new LB_10.Program.Party();
            LB_10.Program.Kit Box = new LB_10.Program.Kit();

            Sheep.Move();
            Sheep.Examination();
            Cow.Move();
            Cow.Examination();
            Box.Move();
            Box.Examination();
        }
    }
}
