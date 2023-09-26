using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste

{
    //criando um projeto para ser testado
    //uma classe que tem um metodo que retorna a soma de dois numeros
    //usando static não é obrigado instanciar
    public static class Operacoes
    {
        //metodo para soma dois numeros
        public static double Somar(double pNum, double sNum)

        {
            //Retorna a soma de dois numeros
            return (pNum + sNum);

        }


        //metodo para a multiplicação dois numeros
        public static double Multiplicar(double pNum, double sNum)

        {
            //Retorna a multiplicação de dois numeros
            return (pNum * sNum);

        }

    }
}
