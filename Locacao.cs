using System;
using System.Collections.Generic;
using System.Text;

namespace _23_Ativida_Locacao_Carro
{
    public class Locacao
    {
        //**************Locaçao****************
        public int Dia { set; get; }

        public int ClinetL { get; set; }

        public int CarroC { get; set; }



        public double ValorL { get; set; }

        public double TotalL {
            get => ValorL * Dia;


        
        }




    
    }
}
