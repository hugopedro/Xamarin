using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
        public Veiculo veiculo { get; set; } // é pro veiculo receber o parametro dessa pagina através do construtor
        //Mudando o construtor pra pegar o veiculo
        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            this.Title = veiculo.nome; // é pra puxar o nome do veiculo pra por no title da pagina
            // porem deve-se ir no ListagemView.xaml.cs pois o construtor ta sendo modificado então deve-se ir lá porque está chamando ele e modificar
            this.veiculo = veiculo;
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            // o PushAsync é pra poder ir na proxima pagina e por na pilha de navegacao
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
            // esse this.veiculo só foi possivel porque criou-se o construtor aqui e pois o this.veiculo
        }
    }
}