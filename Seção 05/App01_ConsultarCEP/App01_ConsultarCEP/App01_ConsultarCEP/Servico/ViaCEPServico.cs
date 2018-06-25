using System;
using System.Collections.Generic;
using System.Text;
using System.Net; //Para buscar na internet (Segundo passo)
using App01_ConsultarCEP.Servico.Modelo; //Para Descerializar(desmembrar) para jogar nos campos criados na classe endereço (Terceiro passo)
using Newtonsoft.Json; // //Clicar como botão direito do mouse sobre o projeto (Gerenciar pacote do Nuget), procurar a biblioteca

//Funcionalidade fazer o download e também obter o endereço preenchido com os dados do viacep
namespace App01_ConsultarCEP.Servico
{
    class ViaCEPServico
    {

        #region [Construtores]
        #endregion

        #region [Propriedades]
        //Endreço normal(https://viacep.com.br/ws/01001000/json/), mas temos que colocar um parametro no cep {0}
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";
        
        #endregion

        #region [Métodos]
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {

            //Primeiro passo - objetivo voltar com o a url reconstruída com o cep digitado pelo usuário.
            string NovoEnderecoUrl = string.Format(EnderecoURL, cep);

            //Segundo passo - Fazendo a busca na internet
            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoUrl);

            //Terceiro passo -  descerializar, pois está tudo em uma string 
            //Para descerializar é necessário fazer o download da biblioteca é necessário baixar a newtonsoft
            //Clicar como botão direito do mouse sobre o projeto (Gerenciar pacote do Nuget) e baixar e instalar
           
            //Para descerializar utilizando Json
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo) ;

            //Tratamento para cep em branco
            if (end.cep==null)
            {
                return null;
            }


            return end;

        }
        #endregion

    }
}
