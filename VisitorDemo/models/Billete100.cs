using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class Billete100 : IBillete
    {
        public float Valor = 100;
        public void Aceptar(IBilleteVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
