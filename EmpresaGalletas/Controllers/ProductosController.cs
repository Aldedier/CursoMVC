using EmpresaGalletas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpresaGalletas.Controllers
{
    public class ProductosController : Controller
    {
        //El lazy sirve ara mantener una unica instancia del objeto producto
        private readonly Lazy<ICollection<Producto>>
            model = new Lazy<ICollection<Producto>>(
                () =>
                {
                    return new Producto[]{
                    new Producto{ Id=1, Nombre = "A", Categoria = "Categoria a" },
                    new Producto{ Id=2, Nombre = "B", Categoria = "Categoria b" },
                    new Producto{ Id=3, Nombre = "C", Categoria = "Categoria c" },
                    new Producto{ Id=4, Nombre = "D", Categoria = "Categoria d" },
                    new Producto{ Id=5, Nombre = "E", Categoria = "Categoria e" }
                    };
                });

        private ICollection<Producto> Productos => model.Value;
        public ActionResult Index() => View(Productos);
        public ActionResult Details(int _id) => View(Productos.FirstOrDefault(x => x.Id == _id));
        public ActionResult Delete(int _id) => View(Productos.FirstOrDefault(x => x.Id == _id));
        public ActionResult Edit(int _id) => View(Productos.FirstOrDefault(x => x.Id == _id));


        // GC.SuppressFinalize(this); sirve para eliminar las instancias de los objetos creados en el controlador
        ~ProductosController()
        {
            GC.SuppressFinalize(this);
        }

    }
}