using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace ProyectoFinal.Clases{

    [Table(Name = "Order Details")]
    class Order_Details{

        #region Atributos
            [Column(Name = "OrderID", IsDbGenerated = true, IsPrimaryKey = true, CanBeNull = false)]  
            public Int32 OrderID
            { get; set; }

            [Column(Name = "ProductID", CanBeNull = true)]      
            public String ProductID
            { get; set; }
       
            [Column(Name = "UnitPrice", CanBeNull = true)]
            public Int32 UnitPrice
            { get; set; }

            [Column(Name = "Quantity", CanBeNull = true)]
            public Decimal Quantity
            { get; set; }

            [Column(Name = "Discount", CanBeNull = true)]
            public Decimal Discount
            { get; set; }

            
        #endregion

    }
}
