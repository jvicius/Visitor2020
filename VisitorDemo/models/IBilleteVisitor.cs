using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public interface IBilleteVisitor
    {
        void Visitar(Billete20 billete);
        void Visitar(Billete50 billete);
        void Visitar(Billete100 billete);
        void Visitar(Billete200 billete);
    }
}
