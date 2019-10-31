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
    public partial class AgendamentoView : ContentPage
    {
        // é preciso criar uma propiedade pública para acessar a página
        public Veiculo veiculo { get; set; }
        // modificando o construtor pra ele poder receber o veículo como parâmetro
        // assim é possível usar o veiculo em coisas, como o titulo.
        //porem só isso nao é suficiente, é necessario ir no detalheView
        public AgendamentoView(Veiculo veiculo)
        { // tem que ir no detalheview.xaml.cs e passar o parâmetro!
            //setando o titulo da pagina de agendamentoview.testdrive
            InitializeComponent();
            this.veiculo = veiculo; // sem isso não vai funcionar, sempre é necessário por o this.atributo
            this.BindingContext = this; // com isso nao precisa mais ficar colocando this.title e outras coisas, vai bindar o que for necessário
        }
    }
}