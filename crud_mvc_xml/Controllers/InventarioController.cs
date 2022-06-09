using crud_mvc_xml.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace crud_mvc_xml.Controllers
{
    public class InventarioController : Controller
    {

        string path = "xml/Inventario.xml";
        Inventario model = new Inventario();

        public IActionResult Index()
        {
            List<Inventario> lstInventario = new List<Inventario>();
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            DataView dvPrograms;
            if (ds.Tables.Count > 0)
            {
                dvPrograms = ds.Tables[0].DefaultView;

                dvPrograms.Sort = "ID";
                foreach (DataRowView dr in dvPrograms)
                {
                    Inventario model = new Inventario();
                    model.ID = Convert.ToInt16(dr[0]);
                    model.Nombre = Convert.ToString(dr[1]);
                    model.ProveedorArticulo = Convert.ToString(dr[2]);
                    model.CantidadDisponible = Convert.ToInt16(dr[3]);
                    model.PrecioCosto = Convert.ToInt16(dr[4]);
                    model.PrecioVenta = Convert.ToInt16(dr[5]);
                    model.PuntoReorden = Convert.ToInt16(dr[6]);
                    lstInventario.Add(model);
                }
                if (lstInventario.Count >= 0)
                {
                    return View(lstInventario);
                }
            }

            return View(lstInventario);
        }

        public ActionResult AddEditProject(int? id)
        {
            int ID = Convert.ToInt16(id);
            if (ID > 0)
            {
                GetDetailsById(ID);
                model.IsEdit = true;
                return View(model);
            }
            else
            {
                model.IsEdit = false;
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult AddEditProject(Inventario mdl)
        {
            if (mdl.ID > 0)
            {

                XDocument xmlDoc = XDocument.Load(path);
                var items = (from item in xmlDoc.Descendants("Inventario") select item).ToList();
                XElement selected = items.Where(p => p.Element("ID").Value == mdl.ID.ToString()).FirstOrDefault();
                selected.Remove();
                xmlDoc.Save(path);
                xmlDoc.Element("Inventarios").Add(new XElement("Inventario", new XElement("ID", mdl.ID), new XElement("Nombre", mdl.Nombre), new XElement("ProveedorArticulo", mdl.ProveedorArticulo), new XElement("CantidadDisponible", mdl.CantidadDisponible), new XElement("PrecioCosto", mdl.PrecioCosto), new XElement("PrecioVenta", mdl.PrecioVenta), new XElement("PuntoReorden", mdl.PuntoReorden)));
                xmlDoc.Save(path);
                return RedirectToAction("Index", "Inventario");
            }
            else
            {
                XmlDocument oXmlDocument = new XmlDocument();
                oXmlDocument.Load(path);
                XmlNodeList nodelist = oXmlDocument.GetElementsByTagName("Inventario");
                var x = oXmlDocument.GetElementsByTagName("ID");
                int Max = 0;
                foreach (XmlElement item in x)
                {
                    int EId = Convert.ToInt32(item.InnerText.ToString());
                    if (EId > Max)
                    {
                        Max = EId;
                    }
                }
                Max = Max + 1;

                XDocument xmlDoc = XDocument.Load(path);
                xmlDoc.Element("Inventarios").Add(new XElement("Inventario",
                                                new XElement("ID", Max),
                                                new XElement("Nombre", mdl.Nombre),
                                                new XElement("ProveedorArticulo", mdl.ProveedorArticulo),
                                                new XElement("CantidadDisponible", mdl.CantidadDisponible),
                                                new XElement("PrecioCosto", mdl.PrecioCosto),
                                                new XElement("PrecioVenta", mdl.PrecioVenta),
                                                new XElement("PuntoReorden", mdl.PuntoReorden)));
                xmlDoc.Save(path);
                return RedirectToAction("Index", "Inventario");
            }
        }

        public ActionResult Delete(int ID)
        {
            if (ID > 0)
            {
                XDocument xmlDoc = XDocument.Load(path);
                var items = (from item in xmlDoc.Descendants("Inventario") select item).ToList();
                XElement selected = items.Where(p => p.Element("ID").Value == ID.ToString()).FirstOrDefault();
                selected.Remove();
                xmlDoc.Save(path);

            }
            return RedirectToAction("Index", "Inventario");
        }

        public void GetDetailsById(int ID)
        {
            XDocument oXmlDocument = XDocument.Load(path);
            var items = (from item in oXmlDocument.Descendants("Inventario")
                         where Convert.ToInt32(item.Element("ID").Value) == ID
                         select new InventarioItems
                         {
                             Nombre = item.Element("Nombre").Value,
                             ProveedorArticulo = item.Element("ProveedorArticulo").Value,
                             CantidadDisponible = Convert.ToInt16(item.Element("CantidadDisponible").Value),
                             PrecioCosto = Convert.ToInt16(item.Element("PrecioCosto").Value),
                             PrecioVenta = Convert.ToInt16(item.Element("PrecioVenta").Value),
                             PuntoReorden = Convert.ToInt16(item.Element("PuntoReorden").Value),
                         }).SingleOrDefault();
            if (items != null)
            {
                model.Nombre = items.Nombre;
                model.ProveedorArticulo = items.ProveedorArticulo;
                model.CantidadDisponible = items.CantidadDisponible;
                model.PrecioCosto = items.PrecioCosto;
                model.PrecioVenta = items.PrecioVenta;
                model.PuntoReorden = items.PuntoReorden;
            }
        }

        public class InventarioItems
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public string ProveedorArticulo { get; set; }

            public Int16 CantidadDisponible { get; set; }

            public decimal PrecioCosto { get; set; }

            public decimal PrecioVenta { get; set; }

            public decimal PuntoReorden { get; set; }
            public InventarioItems() { }
        }
    }

}
