using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace ProyectoFinal.Clases{

    [Table(Name = "Orders")]
    class Orders{

    #region Atributos
            [Column(Name = "CustomerID", CanBeNull = false)]  
            public Int32 OrderID
            { get; set; }

            [Column(Name = "CustomerID", CanBeNull = true)]      
            public String CustomerID
            { get; set; }
       
            [Column(Name = "EmployeeID", CanBeNull = true)]
            public Int32 EmployeeID
            { get; set; }

            [Column(Name = "OrderDate", CanBeNull = true)]
            public DateTime OrderDate
            { get; set; }

            [Column(Name = "RequiredDate", CanBeNull = true)]
            public DateTime RequiredDate
            { get; set; }

            [Column(Name = "ShippedDate", CanBeNull = true)]
            public DateTime ShippedDate
            { get; set; }

            [Column(Name = "ShipVia", CanBeNull = true)]
            public Int32 ShipVia
            { get; set; }

            [Column(Name = "Freight", CanBeNull = true)]
            public Decimal Freight
            { get; set; }

            [Column(Name = "ShipName", CanBeNull = true)]
            public string ShipName
            { get; set; }

            [Column(Name = "ShipAddress", CanBeNull = true)]
            public string ShipAddress
            { get; set; }
   
            [Column(Name = "ShipCity", CanBeNull = true)]
            public string ShipCity
            { get; set; }

            [Column(Name = "ShipRegion", CanBeNull = true)]
            public string ShipRegion
            {get;set;}

            [Column(Name = "ShipPostalCode", CanBeNull = true)]
            public string ShipPostalCode
            {get;set;}

            [Column(Name = "ShipCountry", CanBeNull = true)]
            public string ShipCountry {get;set; }

    #endregion

    }
}
