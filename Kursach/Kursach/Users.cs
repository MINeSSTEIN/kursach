//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kursach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Orders = new HashSet<Orders>();
            this.UsersAndCards = new HashSet<UsersAndCards>();
        }
    
        public int id { get; set; }
        public int Type { get; set; }
        public string Telephone { get; set; }
        public System.DateTime BirthDate { get; set; }
        public System.DateTime RegDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Sorename { get; set; }
        public string Thirdname { get; set; }
        public bool Mailing { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual Users_Types Users_Types { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersAndCards> UsersAndCards { get; set; }
    }
}
