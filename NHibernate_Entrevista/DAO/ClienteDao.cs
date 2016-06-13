using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Linq;

namespace NHibernate.DAO
{
    public class ClienteDao : Base
    {
        private ISession session;
        public ClienteDao(ISession session)
        {
            this.session = session;
        }
        public override void Salvar<T>(T obj)
        {
            ITransaction transaco = session.BeginTransaction();
            session.Save(obj);
            transaco.Commit();
            session.Close();
        }

        public override void Excluir<T>(T obj)
        {
            ITransaction transaco = session.BeginTransaction();
            session.Delete(obj);
            transaco.Commit();
            session.Close();
        }

        public override T Editar<T>(int id)
        {
            return session.Get<T>(id);
        }

        public override void Atualizar<T>(T obj)
        {
            ITransaction transaco = session.BeginTransaction();
            session.Update(obj);
            transaco.Commit();
            session.Close();
        }

        public override List<T> Listar<T>()
        {
            return session.Query<T>().ToList();
        }
    }
}