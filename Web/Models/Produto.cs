using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float Preco { get; set; }
        public bool Status { get; set; }
        public int IdCad { get; set; }
        public int IdUp { get; set; }
        public Produto()
        {
        }
        public Produto(string nome, float preco, bool status, int idCad)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Status = status;
            this.IdCad = idCad;
        }



    }

}