using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using NHibernate.Cfg;

namespace NHibernate.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabrica = RecuperaConfiguracao().BuildSessionFactory();

        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());

            return cfg;
        }

        public static ISession AbreSession()
        {
            return fabrica.OpenSession();
        }


    }
}