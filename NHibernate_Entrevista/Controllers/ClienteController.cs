using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate.DAO;
using NHibernate_Entrevista.Entidades;

namespace NHibernate.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteDao clienteDao;

        public ClienteController(ClienteDao clienteDao)
        {
            this.clienteDao = clienteDao;
        }
        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Salvar(Cliente cliente)
        {
            clienteDao.Salvar(cliente);
            return RedirectToAction("Listar", "Cliente");
        }

        public ActionResult Editar(int id)
        {
            var cliente = clienteDao.Editar<Cliente>(id);
            return View(cliente);
        }

        public ActionResult Atualizar(Cliente cliente)
        {
            clienteDao.Atualizar(cliente);
            return RedirectToAction("Listar", "Cliente");
        }

        public ActionResult Listar()
        {
            var clientes = clienteDao.Listar<Cliente>();
            return View(clientes);
        }

        public ActionResult Deletar(Cliente cliente)
        {
            clienteDao.Excluir(cliente);

            return RedirectToAction("Listar", "Cliente");
        }

    }
}
