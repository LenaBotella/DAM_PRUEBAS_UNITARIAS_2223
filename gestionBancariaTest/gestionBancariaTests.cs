using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests

    {
        [TestMethod]

        public void validarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo la cuenta no es correcto");
        }

        [TestMethod]

        public void validarMetodoIngreso2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1500;
            double ingreso = 600;
            double saldoActual = 0;
            double saldoEsperado = 2100;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo la cuenta no es correcto");
        }

        [TestMethod]

        public void validarMetodoReintegro()
        {
            // preparación del caso de prueba
            double cantidad = 500;
            double saldoActual = 2000;
            double saldoEsperado = 1500;
            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            // Método a probar
            cuenta.realizarReintegro(cantidad);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void validarMetodoIngresoError()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarIngreso(ingreso);
            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void validarMetodoReintegroError1()
        {
            double cantidad = -500;
            double saldoActual = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarMetodoReintegroError2()
        {
            double cantidad = 500;
            double saldoActual = 400;
            gestionBancaria cuenta = new gestionBancaria(saldoActual);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
        }

    }
}
