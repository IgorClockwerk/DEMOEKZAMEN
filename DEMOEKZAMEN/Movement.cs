//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEMOEKZAMEN
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movement
    {
        public int Id { get; set; }
        public Nullable<int> WerehauseFrom { get; set; }
        public int WerehauseTo { get; set; }
        public System.DateTime DateMovement { get; set; }
        public int Count { get; set; }
        public int Product { get; set; }
        public double Price { get; set; }
    
        public virtual Product Product1 { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
    }
}
