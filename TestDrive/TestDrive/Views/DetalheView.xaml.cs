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
            this.veiculo = veiculo;
            this.BindingContext = this; // é pra poder definir o titulo no detalheview.xaml
        }

        private void buttonProximo_Clicked(object sender, EventArgs e)
        {
            // o PushAsync é pra poder ir na proxima pagina e por na pilha de navegacao
            Navigation.PushAsync(new AgendamentoView(this.veiculo));
            // esse this.veiculo só foi possivel porque criou-se o construtor aqui e pois o this.veiculo
        }
    }
}