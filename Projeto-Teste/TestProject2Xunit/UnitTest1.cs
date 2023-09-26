using Projeto_Teste;
using System;
using System.Xml.Schema;

namespace TestProject2Xunit
{
    public class UnitTest1
    {
        //Feito o teste no xUnit
        [Fact] //Fato no lugar do metodo
        public void SomarDoisNumeros()
        {

            //Arrange
            double pNum = 1;
            double sNum = 2;
            double rNum = 3; //Resultado que o teste irá esperar

            //Act - ação
            var Resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.Equal(rNum, Resultado);

        }

        //Fazer Varios teste ao mesmo tempo
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 4, 5)]

        public void SomarDoisNumeroLista(double pNum, double sNum,double rNum)
        {
            //Act - ação
            var Resultado = Operacoes.Somar(pNum, sNum);

            //Assert - verificação
            Assert.Equal(rNum, Resultado);
        }


    }
}