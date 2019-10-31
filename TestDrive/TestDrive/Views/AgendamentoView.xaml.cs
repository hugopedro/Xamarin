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
        // modificando o construtor pra ele poder receber o veículo como parâmetro
        // assim é possível usar o veiculo em coisas, como o titulo.
        //porem só isso nao é suficiente, é necessario ir no detalheView
        public AgendamentoView(Veiculo veiculo)
        { // tem que ir no detalheview.xaml.cs e passar o parâmetro!
            //setando o titulo da pagina de agendamentoview.testdrive
            InitializeComponent();
            this.Title = veiculo.nome;
        }
    }
}