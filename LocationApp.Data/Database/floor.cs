
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LocationApp.Data.Database
{

using System;
    using System.Collections.Generic;
    
public partial class floor
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public floor()
    {

        this.rooms = new HashSet<room>();

    }


    public int FloorID { get; set; }

    public Nullable<int> BlockID { get; set; }

    public Nullable<int> BuildID { get; set; }

    public string Name { get; set; }

    public string Other { get; set; }

    public string Map { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<room> rooms { get; set; }

}

}
