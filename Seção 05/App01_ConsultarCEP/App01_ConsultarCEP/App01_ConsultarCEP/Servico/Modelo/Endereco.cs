using System;
using System.Collections.Generic;
using System.Text;

//Funcionalidade: Arqmazenar as informações do https://viacep.com.br/ws/01001000/json/

namespace App01_ConsultarCEP.Servico.Modelo
{
    class Endereco
    {

        #region [Construtores]

        #endregion

        #region [Propriedades]

        //Base - informações do https://viacep.com.br/ws/01001000/json/
        //Podemos notar que as informações estão com aspas duplas significa que são strings 
        //"cep": "01001-000",
        //"logradouro": "Praça da Sé",
        //"complemento": "lado ímpar",
        //"bairro": "Sé",
        //"localidade": "São Paulo",
        //"uf": "SP",
        //"unidade": "",
        //"ibge": "3550308",
        //"gia": "1004"


        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        
        #endregion

        #region [Métodos]
        #endregion

    }
}
