using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class Billete20 : IBillete
    {
        public float Valor = 20;
        public void Aceptar(IBilleteVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
