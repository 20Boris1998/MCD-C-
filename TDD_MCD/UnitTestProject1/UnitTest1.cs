using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_MCD;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        public void CalcularPositivoMCDTestMethod1()
        {
            double nro1 = 12;
            double nro2 = 18;
            double nro3 = 24;
            double nro4 = 36;
            double esperado = 6;
            double prueba = MCD.Calcular_MCD_Cuatro(nro1, nro2, nro3, nro4);
            Assert.AreEqual(esperado, prueba);
        }

        public void CalcularNegativoMCDTestMethod2()
        {
            double nro1 = -12;
            double nro2 = -18;
            double nro3 = -24;
            double nro4 = -36;
            double esperado = 6;
            double prueba = MCD.Calcular_MCD_Cuatro(nro1, nro2, nro3, nro4);
            Assert.AreEqual(esperado, prueba);
        }
        public void CalcularPositivoConCeroMCDTestMethod3()
        {
            double nro1 = 0;
            double nro2 = 18;
            double nro3 = 24;
            double nro4 = 36;
            double esperado = 6;
            double prueba = MCD.Calcular_MCD_Cuatro(nro1, nro2, nro3, nro4);
            Assert.AreEqual(esperado, prueba);
        }
        public void CalcularNegativoConCeroMCDTestMethod4()
        {
            double nro1 = 0;
            double nro2 = -18;
            double nro3 = -24;
            double nro4 = -36;
            double esperado = 6;
            double prueba = MCD.Calcular_MCD_Cuatro(nro1, nro2, nro3, nro4);
            Assert.AreEqual(esperado, prueba);
        }
        public void CalcularConMismoValorMCDTestMethod5()
        {
            double nro1 = 18;
            double nro2 = 18;
            double nro3 = 18;
            double nro4 = 18;
            double esperado = 18;
            double prueba = MCD.Calcular_MCD_Cuatro(nro1, nro2, nro3, nro4);
            Assert.AreEqual(esperado, prueba);
        }

    }
}
