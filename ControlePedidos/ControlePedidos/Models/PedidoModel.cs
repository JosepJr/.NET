using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlePedidos.Models
{
    public class PedidoModel
    {
        [Display(Name = "Número:")]
        public string numero { get; set; }
        [Display(Name = "Nome Cliente:")]
        public string nomeCliente { get; set; }
        [Display(Name = "Endereço:")]
        public string endereco { get; set; }
        [Display(Name = "CEP:")]
        public string cep { get; set; }
        [Display(Name = "Sabor 1:")]
        public int sabor1 { get; set; }
        [Display(Name = "Sabor 2:")]
        public int sabor2 { get; set; }


        public static IEnumerable<SelectListItem> ObterSabores() {
            new SelectListItem { Text = "Calabresa", Value = "1" };
            new SelectListItem { Text = "Portuguesa", Value = "2" };          
        }


      

    }
}