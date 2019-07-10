using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.rpp
{
  public class BancoNacional : Banco
  {
    public string pais;

    public BancoNacional(string nombre, string pais) : base(nombre)
    {
      this.pais = pais;
    }

    public override string Mostrar()
    {
      return "Nombre: " + base.nombre;
    }

    public override string Mostrar(Banco b)
    {
      string retorno = "";
      if(b is BancoNacional)
      {
        retorno += "\n" + ((BancoNacional)b).pais;
      }

      if(b is BancoProvincial)
      {
        retorno += "\n" + ((BancoProvincial)b).provincia.ToString();
      }

      if(b is BancoMunicipal)
      {
        retorno += "\n" + ((BancoMunicipal)b).municipio;
      }
      return retorno;
    }
  }
}
