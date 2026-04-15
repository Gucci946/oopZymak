using System;
using System.Collections.Generic;
using System.Text;

namespace oopZymak
{
    public enum Töötüüp
    {
        Palk,
        Toetlus
    }

    public interface ITööline
        {
        Töötüüp ValjamakseTüüp { get; set; }
            double ArvutaPalk();
        }
}
