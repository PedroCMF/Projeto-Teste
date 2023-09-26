using Projeto_Teste;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Feito o teste no mtest

        [TestMethod]
        public void SomaDoisNumeros()
        {

            //Arrange - Preparação
            double pNum = 7;
            double sNum = 2;
            double rNum = 9; //Resultado que o teste irá esperar

            //Act - acao
            var Resultado = Operacoes.Somar(pNum, sNum); //Passa na classe operaçoes e pelo metodo de soma para somar os resultados

            //Assept - Verificaçao
            Assert.AreEqual(rNum, Resultado); //verifica se os valores sao iguais. Se o valor esperado(rNum) é igual o valor do resultado

            //Para executar o teste clique como botao direito do mause no TestProject1/ executar teste

        }

        //Testeando varias somas de numéros

        //Arrange - Preparação
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 5, 7)]
        [DataRow(3, 4, 7)]
        [DataRow(6, 6, 12)]
        [DataRow(1, 1, 2)]

        public void SomaDoisNumerosLista(double pNum, double sNum, double rNUm)
        {
            //Act

            var Resultado = Operacoes.Somar(pNum, sNum);

            //Assept - Verificaçao
            Assert.AreEqual(rNUm, Resultado); //verifica se os valores sao iguais. Se o valor esperado(rNum) é igual o valor do resultado

        }


        //Multiplicação de dois numeros
        //===========================================================================================
        [TestMethod]
        
        public void MultiplicarDoisNumeros()
        {

            //Arrange - Preparação
            double pNum = 5;
            double sNum = 2;
            double rNum = 10; //Resultado que o teste irá esperar

            //Act - acao
            var Resultado = Operacoes.Multiplicar(pNum, sNum); //Passa na classe operaçoes e pelo metodo de soma para multiplicar os resultados

            //Assept - Verificaçao
            Assert.AreEqual(rNum, Resultado); //verifica se os valores sao iguais. Se o valor esperado(rNum) é igual o valor do resultado

           
        }

    }
}