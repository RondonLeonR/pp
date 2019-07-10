using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.rpp
{
  public class BancoMunicipal : BancoProvincial
  {
    public string municipio;
    public BancoMunicipal(BancoProvincial bp, string municipio) : base(((BancoNacional)bp),bp.provincia)
    {
      this.municipio = municipio;
    }

    public override string Mostrar()
    {
      return this.nombre;
    }

   
  }
}
