﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestDrive.Views
{
    public class Veiculo
    {
        public string nome { get; set; }
        public decimal preco { get; set; }

        public string PrecoFormatado
        {
            get { return string.Format("R$ {0}", preco); }
        }
    }

    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>()
            {
                new Veiculo { nome = "Azera V6", preco = 85000 },
                new Veiculo { nome = "Onix 1.6", preco = 35000 },
                new Veiculo { nome = "Fiesta 2.0", preco = 52000 },
                new Veiculo { nome = "C3 1.0", preco = 22000 },
                new Veiculo { nome = "Uno Fire", preco = 11000 },
                new Veiculo { nome = "Sentra 2.0", preco = 53000 },
                new Veiculo { nome = "Astra Sedan", preco = 39000 },
                new Veiculo { nome = "Vectra 2.0 Turbo", preco = 37000 },
                new Veiculo { nome = "Hilux 4x4", preco = 90000 },
                new Veiculo { nome = "Montana Cabine dupla", preco = 57000 },
                new Veiculo { nome = "Outlander 2.4", preco = 99000 },
                new Veiculo { nome = "Brasilia Amarela", preco = 9500 },
                new Veiculo { nome = "Omega Hatch", preco = 8000 }
            };

            this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;
            Navigation.PushAsync(new DetalheView(veiculo)); //pois veiculo pra poder puxar a pagina linkada ao veiculo
            //New DetalheView pois chamará uma nova janela ao navegar
            /*PushAsync , método assíncrono que funcionará assim que a aplicação estiver
disponível para tal, retornando o controle para ela imediatamente a partir da execução deste comando, sem que ela seja
bloqueada.*/
        }
    }
}
 