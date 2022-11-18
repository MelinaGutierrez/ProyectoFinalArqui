using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProyectoFinal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = ProyectoFinalArqui.Program.Something();
            Assert.AreEqual("Algo", result);
        }

        [TestMethod]
        public void TestPlanPrepago()
        {
            double result = ProyectoFinalArqui.Program.tipoPlan("PREPAGO LIBRE");
            Assert.AreEqual(1.70, result);
        }
        /*
        [TestMethod] 
        public void TestPlanCorrecto()
        {
            bool result = ProyectoFinalArqui.Program.cobroAddons("Plan S a medida", "DATOS XS");
            Assert.AreEqual(10, result);
        }


        [TestMethod]
        public void TestVigencia()
        {
            bool result = ProyectoFinalArqui.Program.validarVigencia("1-05-2022", "30-05-2022");
            Assert.AreEqual(29, result);
        }

        public void TestMonto()
        {
            bool result = ProyectoFinalArqui.Program.totalCosto("Plan S a medida", "DATOS M", "Youtube");
            Assert.AreEqual(182, result);
        }

        public void TestAcceso()
        {
            bool result = ProyectoFinalArqui.Program.accesoAddon("Plan S a medida");
            Assert.AreEqual(true, result);
        }
        */
    }
}
