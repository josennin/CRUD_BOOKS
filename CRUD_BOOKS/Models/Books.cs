//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_BOOKS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Books
    {
        [Display(Name = "#")]
        public int id { get; set; }
        [Display(Name = "Nombre del Libro")]
        public string nameBook { get; set; }
        [Display(Name = "Autor")]
        public string author { get; set; }
        public System.DateTime date { get; set; }
    }
}
