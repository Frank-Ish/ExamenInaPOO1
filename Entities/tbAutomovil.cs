//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAutomovil
    {
        public int placa { get; set; }
        public string vin { get; set; }
        public int marca { get; set; }
        public int tipo { get; set; }
        public int color { get; set; }
        public bool estado { get; set; }
    
        public virtual tbColor tbColor { get; set; }
        public virtual tbMarca tbMarca { get; set; }
        public virtual tbTipoVehiculo tbTipoVehiculo { get; set; }
    }
}