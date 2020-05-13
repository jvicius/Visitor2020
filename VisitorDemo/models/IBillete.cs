using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public interface IBillete
    {
        void Aceptar(IBilleteVisitor visitor);
    }
}
