using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDemo.models
{
    public class BilleteOrganizador : IBilleteVisitor
    {
        public List<Billete20> Billetes20;
        public List<Billete50> Billetes50;
        public List<Billete100> Billetes100;
        public List<Billete200> Billetes200;

        public BilleteOrganizador()
        {
            Billetes20 = new List<Billete20>();
            Billetes50 = new List<Billete50>();
            Billetes100 = new List<Billete100>();
            Billetes200 = new List<Billete200>();
        }
        public void Visitar(Billete20 billete)
        {
            Billetes20.Add(billete);
        }
        public void Visitar(Billete50 billete)
        {
            Billetes50.Add(billete);
        }

        public void Visitar(Billete100 billete)
        {
            Billetes100.Add(billete);
        }

        public void Visitar(Billete200 billete)
        {
            Billetes200.Add(billete);
        }
    }
}
