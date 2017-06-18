using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CommandListModel
    {
        /// <summary>
        /// ОТчество
        /// </summary>
        public string surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string patronymic { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string position { get; set; }
        

    }
}