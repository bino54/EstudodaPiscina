using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario","Usuario")]
    public partial class PaginaFichaViewModel: ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;

        [ObservableProperty]
        string descricao2;

        [ObservableProperty]
        string categoria2;

        [ObservableProperty]
        string objetivo2;

        [ObservableProperty]
        ObservableCollection<Categoria> listaFicha = new();


        [RelayCommand]
        void Guardar()
        {
            if ((string.IsNullOrWhiteSpace(Categoria2)) || (string.IsNullOrWhiteSpace(Objetivo2)))
            {
                // Não faz nada
                return;

            }
            Objetivo obj = new Objetivo(Objetivo2);
            List<Objetivo> obra = new List<Objetivo>();
            obra.Add(obj);
            Categoria ct = null;
            int r = 0;
            foreach(var item in ListaFicha)
            {
                if(item.Descricao.Equals(Categoria2))
                {
                    foreach(var item2 in item.Objetivos) { 
                        obra.Add(item2);
                    }
                    ct = item;
                    r++;
                }
            }

            Categoria cat = new Categoria(Categoria2, obra);
            if (r == 0)
            {
                ListaFicha.Add(cat);
            }
            else if (r >0 && ct != null)
            {
                ListaFicha.Remove(ct);
                ListaFicha.Add(cat);
            }
            Objetivo2 = "";
            Categoria2 = "";
        }

        [RelayCommand]
        void EnviarFicha()
        {
            if ((string.IsNullOrWhiteSpace(Descricao2)))
            {
                // Não faz nada
                return;

            }
            List<Categoria> ct = new List<Categoria>();
            foreach(var item in ListaFicha)
            {
                ct.Add(item);
            }
            FichaAvaliacao ft = new FichaAvaliacao("Ficha1",ct);
            Usuario.Fichas.Add(ft);
            ListaFicha.Clear();
        }


    }
}
