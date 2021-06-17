using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
//********************************************************* Marilia Thomaz Fernandes da Silva ************************************
namespace _23_Ativida_Locacao_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            string S;
            int posocao_remocao;
            NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;



            Console.WriteLine("**********Locaçao de Veiculos**********");

            //Criasão do arryei 
            List<Clinte> lista_clites = new List<Clinte>();

            //*******Cadastro Estatico Clinte***********

            lista_clites.Add(new Clinte()
            {
                //1
                Nome = "Pedro",
                Cpf = "123.456.789-12",
                Endereco = "Coqueiro de Aucatras- 171-Cristovam",


            });

            lista_clites.Add(new Clinte()
            {
                //2
                Nome = "Gabrila",
                Cpf = "147.258.963-36",
                Endereco = "Jasminha Bejaflor  - 159 -Campos",


            });
            lista_clites.Add(new Clinte()
            {
                //3
                Nome = "Helena",
                Cpf = "369.456.753-74",
                Endereco = "Bela Vista -784 - Sentral",


            });
            //*********Fim******************

            //Criasão do arryei 
            List<Carro> lista_carro = new List<Carro>();

            //*******Cadastro Estatico Carro***********

            lista_carro.Add(new Carro()
            {
                //1
                Marca = "Honda",
                Quilometragem = 500,
                Modelo = "Civic",
                LocacaoV = 6000.0,
            });

            lista_carro.Add(new Carro()
            {
                //2
                Marca = "Ford",
                Quilometragem = 400,
                Modelo = "Ka",
                LocacaoV = 2000.0,
            });

            lista_carro.Add(new Carro()
            {
                //3
                Marca = "Fiat",
                Quilometragem = 700,
                Modelo = "Argo",
                LocacaoV = 4000.00,
            });
            //****************fim***********

            //Criasão do arryei 
            List<Locacao> lista_locacao = new List<Locacao>();

            //*******Cadastro Estatico Locacao***********

            lista_locacao.Add(new Locacao()
            {
                //1
                Dia = 20,
                CarroC = 5,
                ClinetL = 6,
                ValorL = 6000.0,


            });

            lista_locacao.Add(new Locacao()
            {
                //2
                Dia = 40,
                ClinetL = 8,
                CarroC = 8,
                ValorL = 2000.0,





            });

            lista_locacao.Add(new Locacao()
            {
                //3
                Dia = 11,
                CarroC = 2,
                ClinetL = 5,
                ValorL = 5000.0,



            });





            bool fazer_outra_operacao = false;
            bool Verricacao_numero_certo = false;

            bool operrao_coferida_carro = false;
            bool operacao_coferida_locacao = false;
            bool operacao_conferida_clite = false;
            int posocao_infomada_altera;
            do
            {


                double operçao = 0;
                Console.WriteLine("******Ben Vindo******");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("******Menu de  Navegação******");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.WriteLine("Digite - 1 - Castrar um Locação");
                Console.WriteLine("Digite - 2 - Castrar  um Carro");
                Console.WriteLine("Digite - 3 - Castrar  um Cliete");
                Console.WriteLine("");
                Console.WriteLine("Digite -4- Altera  Clites ");
                Console.WriteLine("Digite -5- Altera Carros ");
                Console.WriteLine("Digite -6- Alterar Locação ");
                Console.WriteLine("");
                Console.WriteLine("Digite -7- Consulta exluir ");

                Console.WriteLine("");
                Console.WriteLine("Digite -8- Consulta  ");
                // Console.WriteLine("Digite sua escolha: ");






                do
                {
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Digite sua escolha: ");
                        Console.BackgroundColor = ConsoleColor.Black;



                        Verricacao_numero_certo = Double.TryParse(Console.ReadLine(), out operçao);
                        Console.WriteLine("Operação invalida");



                    } while (!Verricacao_numero_certo);



                    if (operçao >= 9 || operçao <= 0)

                    {
                        Verricacao_numero_certo = false;
                        Console.WriteLine("Operação invalida {0}", operçao);
                    }


                } while (!Verricacao_numero_certo);
                Console.Clear();


                switch (operçao)
                {

                    case 1:




                        //****************************************Cadastro da  Locação ****************************************





                        do
                        {
                            Locacao novo_locao = new Locacao();

                            lista_locacao.Add(novo_locao);
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("******* Cadastro do Locação ******");
                                Console.WriteLine("");
                                Console.BackgroundColor = ConsoleColor.Black;

                                //******************************************************Escolhe Clinte
                                for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                                {
                                    Console.WriteLine("A na posiçao  {0} é {1} ", posicao, lista_clites[posicao].Nome

                                        );
                                }
                                Console.WriteLine("");
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Infome a  posisção do  Nome: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_locao.ClinetL = Convert.ToInt32(Console.ReadLine());



                                // Moatra  e  posição que  pessoa via mudar
                                Console.WriteLine("Nome escolido " + novo_locao.ClinetL);

                                //******************************************************Escolhe Clinte*****Fima

                                //******************************************************Escolhe Carro
                                for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                                {
                                    Console.WriteLine("A na posiçao  {0} é {1} ", posicao, lista_carro[posicao].Marca);
                                }
                                Console.WriteLine("");
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Infome a  posisção do Carro: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_locao.CarroC = Convert.ToInt32(Console.ReadLine());



                                // Moatra  e  posição que  pessoa via mudar
                                Console.WriteLine("Carro escolido " + novo_locao.CarroC);





                                //******************************************************Escolhe Carro*****Fima

                                //******************************************************Escolhe Valor da Loasao
                                for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                                {
                                    Console.WriteLine("A na posiçao  {0} é {1} ", posicao,
                                        lista_carro[posicao].LocacaoV.ToString("C", nfi)
                                        );
                                }
                                Console.WriteLine("");
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Infome a   Valor da loção: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_locao.ValorL = Convert.ToDouble(Console.ReadLine());



                                // Moatra  e  posição que  pessoa via mudar
                                Console.WriteLine("Carro escolido " + novo_locao.ValorL
                                    );





                                //******************************************************Escolhe Carro*****Fima
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite quantidade de dias: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_locao.Dia = Convert.ToInt32(Console.ReadLine());


                            }
                            for (int posicao = 0; posicao < lista_locacao.Count; posicao++)

                            {

                                Console.WriteLine("A na posiçao  {0}  dia: {1}|  Clite: {2}| Carro: {3} |Vajir da Locação:  {4}| Dinhero a reber: {5} ", posicao,
                                    lista_locacao[posicao].Dia,
                                    lista_locacao[posicao].ClinetL,

                                    lista_locacao[posicao].CarroC,
                                    lista_locacao[posicao].ValorL.ToString("C", nfi),
                                    lista_locacao[posicao].TotalL.ToString("C", nfi));
                            }

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;

                        } while (fazer_outra_operacao);


                        Console.Clear();


                        break;






                    //****************************************Cadastro da  Carro ****************************************
                    case 2:

                        do
                        {
                            Carro novo_carro = new Carro();


                            lista_carro.Add(novo_carro);
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("******* Cadastro do Carro*******");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite a Marca do carro: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_carro.Marca = Console.ReadLine();

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite qunato Quilometargen: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_carro.Quilometragem = Convert.ToDouble(Console.ReadLine());

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite Modelo deo Carro: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_carro.Modelo = Console.ReadLine();

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite  o valor da  locação: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_carro.LocacaoV = Convert.ToDouble(Console.ReadLine());

                                //lista_carro.Add(novo_carro);//aqui estou castarndo novo carro
                            }
                            for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                            {

                                Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} |{4}", posicao, lista_carro[posicao].Marca, lista_carro[posicao].Quilometragem,
                                    lista_carro[posicao].Modelo,
                                    lista_carro[posicao].LocacaoV.ToString("C", nfi)
                                    );


                            }
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);
                        Console.Clear();
                        break;

                    //****************************************Cadastro da  Clinte ****************************************
                    case 3:

                        do
                        {

                            Clinte novo_clinte = new Clinte();


                            lista_clites.Add(novo_clinte);
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("******* Cadastro do Clite*******");
                                Console.WriteLine("");
                                Console.BackgroundColor = ConsoleColor.Black;

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite  Nome do clite: ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_clinte.Nome = Console.ReadLine();

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite CPF ");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_clinte.Cpf = Console.ReadLine();

                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Digite Endereço:");
                                Console.BackgroundColor = ConsoleColor.Black;
                                novo_clinte.Endereco = Console.ReadLine();


                            }
                            for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                            {

                                Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} ", posicao, lista_clites[posicao].Nome, lista_clites[posicao].Cpf,
                                    lista_clites[posicao].Endereco
                                    );

                            }

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;

                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);

                        Console.Clear();

                        break;

                    //****************************************************** Altera********Clinte
                    case 4:

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("***********Alterar a Cadatro  de  um Cliente:*********** ");
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.Black;

                            for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                            {

                                Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} ", posicao, lista_clites[posicao].Nome, lista_clites[posicao].Cpf,
                                    lista_clites[posicao].Endereco
                                    );

                            }
                            Console.WriteLine("");

                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Infome a  posisção do  Cliente: ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine(" ");
                            int varivale_auciliadora_clinte;
                            varivale_auciliadora_clinte = lista_clites.Count;

                            do
                            {

                                do
                                {



                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Digite sua escolha: ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    operacao_conferida_clite = int.TryParse(Console.ReadLine(), out posocao_infomada_altera);
                                    // Console.WriteLine("Operação invalida");


                                } while (!operacao_conferida_clite);

                                if (posocao_infomada_altera >= varivale_auciliadora_clinte)

                                {
                                    operacao_conferida_clite = false;
                                    Console.WriteLine("Operação invalida {0}", posocao_infomada_altera);

                                }
                                else if (posocao_infomada_altera <= -1)
                                {
                                    operacao_conferida_clite = false;
                                    Console.WriteLine("Operação invalida {0}", posocao_infomada_altera);
                                }



                            } while (!operacao_conferida_clite);






                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Nome de {0} ", lista_clites[posocao_infomada_altera].Nome);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do nome, Atuala: {0} ", lista_clites[posocao_infomada_altera].Nome);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_clites[posocao_infomada_altera].Nome = Console.ReadLine();



                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  CPF de {0} ", lista_clites[posocao_infomada_altera].Cpf);
                            Console.BackgroundColor = ConsoleColor.Black;


                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do CPF, Atuala: {0} ", lista_clites[posocao_infomada_altera].Cpf);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_clites[posocao_infomada_altera].Cpf = Console.ReadLine();


                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Endereço de {0} ", lista_clites[posocao_infomada_altera].Endereco);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Endereço, Atuala: {0} ", lista_clites[posocao_infomada_altera].Endereco);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_clites[posocao_infomada_altera].Endereco = Console.ReadLine();


                            for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                            {

                                Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} ", posicao, lista_clites[posicao].Nome, lista_clites[posicao].Cpf,
                                    lista_clites[posicao].Endereco
                                    );

                            }
                         
                           

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);
                        Console.Clear();
                        break;

                    //************************************************Fim

                    //****************************************************** Altera********Carro
                    case 5:
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("**********Alterar a Cadatro  de  um Carro:********** ");
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.Black;

                            for (int posicao = 0; posicao < lista_carro.Count; posicao++)

                            {

                                Console.WriteLine("A na posiçao  {0} | Marca:{1}| Quilometragem:  {2}|  ModelO:   {3}| Valor da  locação : {4} ", posicao,
                                    lista_carro[posicao].Marca,
                                    lista_carro[posicao].Quilometragem,
                                    lista_carro[posicao].Modelo,

                                   lista_carro[posicao].LocacaoV.ToString("C", nfi));

                            }
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  posisção do  Marca do carro: ");
                            Console.BackgroundColor = ConsoleColor.Black;

                            int vaivel_acliadoura;
                            vaivel_acliadoura = lista_carro.Count;

                            do
                            {

                                do
                                {



                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Digite sua escolha: ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    operrao_coferida_carro = int.TryParse(Console.ReadLine(), out posocao_infomada_altera);
                                    // Console.WriteLine("Operação invalida");



                                } while (!operrao_coferida_carro);

                                if (posocao_infomada_altera >= vaivel_acliadoura)

                                {
                                    operrao_coferida_carro = false;
                                    Console.WriteLine("Operação invalida {0}", posocao_infomada_altera);

                                }
                                else if (posocao_infomada_altera <= -1)
                                {
                                    operrao_coferida_carro = false;
                                    Console.WriteLine("Operação invalida {0}", posocao_infomada_altera);
                                }



                            } while (!operrao_coferida_carro);



                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Marca do carro {0} ", lista_carro[posocao_infomada_altera].Marca);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Marca, para Atuala: {0} ", lista_carro[posocao_infomada_altera].Marca);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_carro[posocao_infomada_altera].Marca = Console.ReadLine();

                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Quilometagem   {0} ", lista_carro[posocao_infomada_altera].Quilometragem);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Quilometragem, Atuala: {0} ", lista_carro[posocao_infomada_altera].Quilometragem);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_carro[posocao_infomada_altera].Quilometragem = Convert.ToDouble(Console.ReadLine());

                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Modelo di carro {0} ", lista_carro[posocao_infomada_altera].Modelo);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Modelo, para Atuala: {0} ", lista_carro[posocao_infomada_altera].Modelo);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_carro[posocao_infomada_altera].Modelo = Console.ReadLine();


                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a  Valor da  locação   {0} ", lista_carro[posocao_infomada_altera].LocacaoV);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Valor da  locação, Atuala: {0} ", lista_carro[posocao_infomada_altera].LocacaoV);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_carro[posocao_infomada_altera].LocacaoV = Convert.ToDouble(Console.ReadLine());


                            for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                            {

                                Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} |{4}", posicao, lista_carro[posicao].Marca, lista_carro[posicao].Quilometragem,
                                    lista_carro[posicao].Modelo,
                                    lista_carro[posicao].LocacaoV.ToString("C", nfi)
                                    );


                            }

                            Console.WriteLine("");



                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);
                        Console.Clear();
                        break;

                    //************************************************Fim

                    //****************************************************** Altera********Locação
                    case 6:

                        do
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("**********Alterar a Cadatro  de  um Locação:********** ");
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.Black;
                            for (int posicao = 0; posicao < lista_locacao.Count; posicao++)

                            {

                                Console.WriteLine("A na posiçao  {0}  dia: {1}|  Clite: {2}| Carro: {3} |Vajir da Locação:  {4}| Dinhero a reber: {5} ", posicao,
                                    lista_locacao[posicao].Dia,
                                    lista_locacao[posicao].ClinetL,

                                    lista_locacao[posicao].CarroC,
                                    lista_locacao[posicao].ValorL.ToString("C", nfi),
                                    lista_locacao[posicao].TotalL.ToString("C", nfi));
                            }
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  posisção do  dia da locaçao: ");
                            Console.BackgroundColor = ConsoleColor.Black;

                            int vaivivel_apio_locacao;
                            vaivivel_apio_locacao = lista_locacao.Count;

                            do
                            {
                                do
                                {
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Digite sua escolha: ");
                                    Console.BackgroundColor = ConsoleColor.Black;



                                    operacao_coferida_locacao = int.TryParse(Console.ReadLine(), out posocao_infomada_altera);
                                    Console.WriteLine("Operação invalida");



                                } while (!operacao_coferida_locacao);

                                if (posocao_infomada_altera >= vaivivel_apio_locacao)
                                {
                                    operacao_coferida_locacao = false;
                                }
                                else if (posocao_infomada_altera <= -1)
                                {
                                    operacao_coferida_locacao = false;

                                }


                            } while (!operacao_coferida_locacao);
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera a Dia do carro {0} ", lista_locacao[posocao_infomada_altera].Dia);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Dia, para Atuala: {0} ", lista_locacao[posocao_infomada_altera].Dia);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_locacao[posocao_infomada_altera].Dia = Convert.ToInt32(Console.ReadLine());

                            //************************************
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera Nome do cliente {0} ", lista_locacao[posocao_infomada_altera].Dia);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Nome, para Atuala: {0} ", lista_locacao[posocao_infomada_altera].ClinetL);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_locacao[posocao_infomada_altera].ClinetL = Convert.ToInt32(Console.ReadLine());
                            //*************************************
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera Marca do carro {0} ", lista_locacao[posocao_infomada_altera].CarroC);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção do Marca do carro, para Atuala: {0} ", lista_locacao[posocao_infomada_altera].CarroC);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_locacao[posocao_infomada_altera].CarroC = Convert.ToInt32(Console.ReadLine());
                            //******************************************

                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Vamos altera Valor da locação  {0} ", lista_locacao[posocao_infomada_altera].ValorL);
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Infome a  correção Valor da locação, para Atuala: {0} ", lista_locacao[posocao_infomada_altera].ValorL);
                            Console.BackgroundColor = ConsoleColor.Black;
                            lista_locacao[posocao_infomada_altera].ValorL = Convert.ToDouble(Console.ReadLine());





                            for (int posicao = 0; posicao < lista_locacao.Count; posicao++)

                            {

                                Console.WriteLine("A na posiçao  {0}  dia: {1}|  Clite: {2}| Carro: {3} |Vajir da Locação:  {4}| Dinhero a reber: {5} ", posicao,
                                    lista_locacao[posicao].Dia,
                                    lista_locacao[posicao].ClinetL,

                                    lista_locacao[posicao].CarroC,
                                    lista_locacao[posicao].ValorL.ToString("C", nfi),
                                    lista_locacao[posicao].TotalL.ToString("C", nfi));
                            }
                            Console.WriteLine("");



                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);
                        Console.Clear();
                        break;

                    //************************************************Fim

                    //******************************************************Tela exlur*******
                    case 7:



                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("******Menu de  Navegação De Excluir******");
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("Digite - 1 - Locação");
                        Console.WriteLine("Digite - 2 - Carro");
                        Console.WriteLine("Digite - 3 - Cliete");
                        Console.WriteLine("");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Digite numeo esolido: ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        double operçao_Exsclusao = Convert.ToDouble(Console.ReadLine());

                        switch (operçao_Exsclusao)
                        {
                            //******************************Exclui*****locação

                            case 1:

                                do
                                {
                                    for (int posicao = 0; posicao < lista_locacao.Count; posicao++)

                                    {

                                        Console.WriteLine("A na posiçao  {0}  dia: {1}|  Clite: {2}| Carro: {3} |Vajir da Locação:  {4}| Dinhero a reber: {5} ", posicao,
                                            lista_locacao[posicao].Dia,
                                            lista_locacao[posicao].ClinetL,

                                            lista_locacao[posicao].CarroC,
                                            lista_locacao[posicao].ValorL.ToString("C", nfi),
                                            lista_locacao[posicao].TotalL.ToString("C", nfi));
                                    }

                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Vamos remover um Locação ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Informe a  posição  do locaoção ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    posocao_remocao = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Vamos Remover o {0} do sistema", lista_locacao[posocao_remocao].CarroC

                                        );
                                    lista_locacao.RemoveAt(posocao_remocao);



                                    for (int posicao = 0; posicao < lista_locacao.Count; posicao++)

                                    {

                                        Console.WriteLine("A na posiçao  {0}  dia: {1}|  Clite: {2}| Carro: {3} |Vajir da Locação:  {4}| Dinhero a reber: {5} ", posicao,
                                            lista_locacao[posicao].Dia,
                                            lista_locacao[posicao].ClinetL,

                                            lista_locacao[posicao].CarroC,
                                            lista_locacao[posicao].ValorL.ToString("C", nfi),
                                            lista_locacao[posicao].TotalL.ToString("C", nfi));
                                    }

                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;


                                } while (fazer_outra_operacao);

                                //**************************************************fim
                                Console.Clear();
                                break;


                            case 2:
                                //****************************************************Excluir*************Carro
                                do
                                {

                                    for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                                    {

                                        Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} |{4}", posicao, lista_carro[posicao].Marca, lista_carro[posicao].Quilometragem,
                                            lista_carro[posicao].Modelo,
                                            lista_carro[posicao].LocacaoV.ToString("C", nfi)
                                            );


                                    }

                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Vamos remover um Carro ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Informe a  posição  do Carro ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    posocao_remocao = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Vamos Remover o {0} do sistema", lista_carro[posocao_remocao].Marca
                                        );
                                    lista_carro.RemoveAt(posocao_remocao);


                                    for (int posicao = 0; posicao < lista_carro.Count; posicao++)
                                    {

                                        Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} |{4}", posicao, lista_carro[posicao].Marca, lista_carro[posicao].Quilometragem,
                                            lista_carro[posicao].Modelo,
                                            lista_carro[posicao].LocacaoV.ToString("C", nfi)
                                            );


                                    }
                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;


                                } while (fazer_outra_operacao);

                                //**************************************************fim


                                Console.Clear();

                                break;



                            case 3:
                                //******************************************************Clinte***Exclusaão
                                do

                                {
                                    for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                                    {

                                        Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} ", posicao, lista_clites[posicao].Nome, lista_clites[posicao].Cpf,
                                            lista_clites[posicao].Endereco
                                            );

                                    }
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Vamos remover um Clinte ");
                                    Console.BackgroundColor = ConsoleColor.Black;

                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("Informe a  posição  do Clinte: ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    posocao_remocao = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Vamos Remover o {0} do sistema", lista_clites[posocao_remocao].Nome

                                        );
                                    lista_clites.RemoveAt(posocao_remocao);




                                    for (int posicao = 0; posicao < lista_clites.Count; posicao++)
                                    {

                                        Console.WriteLine("A na posiçao  {0} é {1}|{2}| {3} ", posicao, lista_clites[posicao].Nome, lista_clites[posicao].Cpf,
                                            lista_clites[posicao].Endereco
                                            );

                                    }

                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Deseja faz nova outra  operação  Exclusao Sim ou  Não? ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;


                                } while (fazer_outra_operacao);

                                Console.Clear();
                                break;
                                //******************************************Fim
                        }



                        break;

                    case 8:


                        do
                        {

                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("******Menu de  Navegação De Excluir******");
                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("Digite - 1 - Clinte");
                            Console.WriteLine("Digite - 2 - Carro");

                            Console.WriteLine("");
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("Digite numeo esolido: ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            double operçao_Pesquisa = Convert.ToDouble(Console.ReadLine());

                            switch (operçao_Pesquisa)
                            {

                                case 1:

                            do
                                    {

                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("Busca de nome do  clite");
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        string nome_aluno_Busca = Console.ReadLine();

                                        Clinte resultado_clinte = lista_clites.FirstOrDefault(posicao => posicao.Nome == nome_aluno_Busca);
                                        Console.WriteLine("Nome do aluno: {0} ", resultado_clinte.Nome);
                                        Console.WriteLine("Endereso do aluno: {0} ", resultado_clinte.Endereco);
                                        Console.WriteLine("CPF do aluno: {0} ", resultado_clinte.Cpf);

                                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                            } while (fazer_outra_operacao) ;
                            Console.Clear();
                            break;

                                case 2:
                                  do  { 
                                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("Busca de Modelo do carro ");
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        string carro_aluno_Busca = Console.ReadLine();

                                        Carro resltado_carro = lista_carro.FirstOrDefault(posicao => posicao.Marca == carro_aluno_Busca);

                                        Console.WriteLine("Marca do Carro {0} ", resltado_carro.Marca);
                                        Console.WriteLine("Modelo do  carro: {0} ", resltado_carro.Modelo);
                                        Console.WriteLine("Quilomtagem do carro ", resltado_carro.Quilometragem);
                                        Console.WriteLine("Valor da locação do carro {0}:", resltado_carro.LocacaoV);




                                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                                            Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não? ");
                                            Console.BackgroundColor = ConsoleColor.Black;       

                                    fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                                   } while (fazer_outra_operacao) ;
                            Console.Clear();
                            break;


                            }
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Deseja faz nova outra  operação  de Busca Sim ou  Não? ");
                            Console.BackgroundColor = ConsoleColor.Black;
                            fazer_outra_operacao = (Console.ReadLine().ToUpper() == "S") ? true : false;
                        } while (fazer_outra_operacao);
                        Console.Clear();
                        break;




















                     

                        


                }

                


                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Deseja faz nova outra  operação Sim ou  Não Fim ? ");
                Console.BackgroundColor = ConsoleColor.Black;
                S = Console.ReadLine().ToUpper();

                        if (S == "S")
                            fazer_outra_operacao = true;
                        else
                            fazer_outra_operacao = false;

                } while (fazer_outra_operacao) ;

                Console.WriteLine("Fim do progama ");
                Console.ReadKey();

            
                    
        }
        
    }
}


