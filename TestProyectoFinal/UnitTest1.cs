using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProyectoFinal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCobroConsumoPlan()
        {
            string result = ProyectoFinalArqui.Program.cobroConsumoPlan("XL",60);
            Assert.AreEqual("El consumo es: " + 60, result);
            string result2 = ProyectoFinalArqui.Program.cobroConsumoPlan("M",5);
            Assert.AreEqual("El consumo es: " + 5, result2);
        }

        [TestMethod]
        public void TestMontoPlanes()
        {
            double result = ProyectoFinalArqui.Program.tipoPlan("PREPAGO LIBRE");
            Assert.AreEqual(1.70, result);
            double result2 = ProyectoFinalArqui.Program.tipoPlan("Plan S a medida");
            Assert.AreEqual(50, result2);
            double result3 = ProyectoFinalArqui.Program.tipoPlan("PLAN WAO");
            Assert.AreEqual(200, result3);
        }
        
        [TestMethod] 
        public void TestCostoCorrectoAddons()
        {
            double result = ProyectoFinalArqui.Program.cobroAddons("Plan S a medida", "DATOS XS");
            Assert.AreEqual(10, result);
            double result2 = ProyectoFinalArqui.Program.cobroAddons("PREPAGO LIBRE", "DATOS XS");
            Assert.AreEqual(0, result2);
            double result3 = ProyectoFinalArqui.Program.cobroAddons("Plan L a medida", "DATOS S");
            Assert.AreEqual(33, result3);
            double result4 = ProyectoFinalArqui.Program.cobroAddons("Plan S a medida", "DATOS XXL");
            Assert.AreEqual(353, result4);
        }
        [TestMethod] 
        public void TestMontoCorrectoAddons()
        {
            double result = ProyectoFinalArqui.Program.cantidadAddons("Plan S a medida", "DATOS XS");
            Assert.AreEqual(400, result);
            double result2 = ProyectoFinalArqui.Program.cantidadAddons("PREPAGO LIBRE", "DATOS XS");
            Assert.AreEqual(0, result2);
            double result3 = ProyectoFinalArqui.Program.cantidadAddons("Plan L a medida", "DATOS S");
            Assert.AreEqual(1200, result3);
            double result4 = ProyectoFinalArqui.Program.cantidadAddons("Plan S a medida", "DATOS XXL");
            Assert.AreEqual(23200, result4);
        }
        [TestMethod] 
        public void TestAddonCredito()
        {
            double result = ProyectoFinalArqui.Program.addonCredito("Addon on", "M");
            Assert.AreEqual(20, result);
            double result2 = ProyectoFinalArqui.Program.addonCredito("Addon on", "L");
            Assert.AreEqual(50, result2);
            double result3 = ProyectoFinalArqui.Program.addonCredito("Addon on", "XL");
            Assert.AreEqual(80, result3);
            double result4 = ProyectoFinalArqui.Program.addonCredito("Addon off", "XL");
            Assert.AreEqual(0, result4);
        }
        
        // [TestMethod]
        // public void TestVigencia()
        // {
        //     bool result = ProyectoFinalArqui.Program.validarVigencia("1-05-2022", "30-05-2022");
        //     Assert.AreEqual(29, result);
        // }
        [TestMethod]
        public void TestMonto()
        {
            double result = ProyectoFinalArqui.Program.totalCosto("Plan S a medida", "DATOS M", "Youtube");
            Assert.AreEqual(182, result);
        }
        [TestMethod] 
        public void TestAcceso()
        {
            bool result = ProyectoFinalArqui.Program.accesoAddon("Plan S a medida");
            Assert.AreEqual(true, result);
            bool result2 = ProyectoFinalArqui.Program.accesoAddon("PLAN WAO");
            Assert.AreEqual(true, result2);
            bool result3 = ProyectoFinalArqui.Program.accesoAddon("PREPAGO LIBRE");
            Assert.AreEqual(false, result3);
        }
        
        [TestMethod] 
        public void testCantidadAddonMinutos()
        {
            double result = ProyectoFinalArqui.Program.cantidadAddonMinutos("S");
            Assert.AreEqual(60, result);
            double result2 = ProyectoFinalArqui.Program.cantidadAddonMinutos("M");
            Assert.AreEqual(120, result2);
        }
    }
}
