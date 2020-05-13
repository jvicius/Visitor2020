using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class BilleteContador : IBilleteVisitor
    {
        public float total;

        public BilleteContador()
        {
            total = 0;
        }

        public void Visitar(Billete20 billete)
        {
            total += billete.Valor;
        }
        public void Visitar(Billete50 billete)
        {
            total += billete.Valor;
        }

        public void Visitar(Billete100 billete)
        {
            total += billete.Valor;
        }

        public void Visitar(Billete200 billete)
        {
            total += billete.Valor;
        }
    }
}
