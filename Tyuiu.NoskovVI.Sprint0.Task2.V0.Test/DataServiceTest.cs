using Tyuiu.NoskovVI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.NoskovVI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Виталий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Виталий", res);
        }
    }
}