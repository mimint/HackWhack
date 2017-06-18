using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class CommandController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Загрузить список команды
        /// </summary>
        /// <returns></returns>

        public ActionResult CommandList(long id)
        {
            var list = new List<CommandListModel>();
            var command = new CommandListModel();
            command.patronymic= "Иванов";
            command.name = "Иван";
            command.surname = "Иванович";
            command.position = "Защитник";
            list.Add(command);
             command = new CommandListModel();
            command.patronymic = "Степанов";
            command.name = "Степан";
            command.surname = "Степанович";
            command.position = "Нападающий";
            list.Add(command);

            return (new JsonResult { Data = list, JsonRequestBehavior = JsonRequestBehavior.AllowGet });
        }
    }
}