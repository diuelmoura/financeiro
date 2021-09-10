using System;
using System.Collections.Generic;
using System.Text;

namespace financeiro.DLL.Models
{
    public class Ganho
    {
        public int GanhoId { get; set; }

        public int Descricao { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public double Valor { set; get; }

        public int Dia { get; set; }

        public int MesId { get; set; }

        public Mes Mes { get; set; }

        public int Ano { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }


    }
}
