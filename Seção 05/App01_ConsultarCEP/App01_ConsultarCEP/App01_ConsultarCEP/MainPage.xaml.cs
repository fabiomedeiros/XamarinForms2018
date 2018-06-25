using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;
namespace App01_ConsultarCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //É necessário atribuir ao evento Clicked um método ( Dirente no C# )
            B_Botao.Clicked += BuscarCEP;

            void BuscarCEP(object sender,EventArgs args)
            {
                //TODO - Lógica do programa.
                                                
                //TODO - Validações.
                if (isValidCEP(E_Cep.Text.Trim()))
                    try {
                                                
                        Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(E_Cep.Text.Trim());
                        if (end !=null) //tratamento em conjunto ViaCEPServico.cs
                        {
                            //Usando o string.Format para atribuir e formatar a strign em questão
                            L_Resultado.Text = string.Format("Endereço: {2} de {3}, {0}, {1}", end.localidade, end.uf, end.logradouro, end.bairro);
                        }
                        else
                        {
                            DisplayAlert("ERRO", "O endereço não existe ou não foi encontrado para o CEP informado", "OK");
                        }

                       

                    }
                    catch(Exception e)
                    {
                        DisplayAlert("Erro crítico", e.Message, "Ok");
                    }
                    
                
            }

            bool isValidCEP( string cep)
            {
                bool aux = true;


                //validação de tamanho
                if (cep.Length != 8)
                {
                    DisplayAlert("ERRO", "Cep inválido! O CEP deve conter 8 caracteres.", "OK");
                    aux = false;
                }
                int NovoCEP = 0;
                if (!int.TryParse(cep,out NovoCEP))
                {
                    DisplayAlert("ERRO", "Cep inválido! O CEP deve ser composto apenas por números.", "OK");
                    aux = false;
                }

                return aux;
            }
           
		}
	}
}
