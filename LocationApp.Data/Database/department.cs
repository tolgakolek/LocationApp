
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
    
public partial class department
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public department()
    {

        this.departmentrooms = new HashSet<departmentroom>();

        this.userdepartments = new HashSet<userdepartment>();

    }


    public int DepartmentID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Other { get; set; }

    public Nullable<int> SubUnitID { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<departmentroom> departmentrooms { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<userdepartment> userdepartments { get; set; }

    public virtual subunit subunit { get; set; }

}

}