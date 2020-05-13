using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class Billete50 : IBillete
    {
        public float Valor = 50;
        public void Aceptar(IBilleteVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
