using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using NHibernate.Type;

namespace NHibernate.DAO
{
    public abstract class Base
    {

        public abstract void Salvar<T>(T obj);

        public abstract void Excluir<T>(T obj);

        public abstract T Editar<T>(int id);

        public abstract void Atualizar<T>(T obj);

        public abstract List<T> Listar<T>();
        //asas
    }
}