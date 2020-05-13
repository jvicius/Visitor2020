using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class Billete200 : IBillete
    {
        public float Valor = 200;
        public void Aceptar(IBilleteVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
