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
    
    public partial class UsersAndCards
    {
        public int id { get; set; }
        public int User { get; set; }
        public string Card { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Users_Cards Users_Cards { get; set; }
    }
}
