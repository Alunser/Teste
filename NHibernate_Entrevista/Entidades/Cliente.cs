using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernate_Entrevista.Entidades
{
    public class Cliente
    {
        public virtual int Id { get; set; }

        public virtual string Nome { get; set; }

        public virtual int Idade { get; set; }

        public virtual string Cpf { get; set; }

        public virtual string Rg { get; set; }
    }
}