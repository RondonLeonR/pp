using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.rpp
{
  public class Deposito
  {

    public List<Producto> productos;
    public Deposito() : this(3)
    {
    }

    public Deposito(int cant)
    {
      this.productos = new List<Producto>(cant);
    }

    public static List<Producto> operator +(Deposito d1, Deposito d2)
    {
      int flag;
      foreach(Producto item in d2.productos)
      {
        flag = 0;
        foreach(Producto item2 in d1.productos)
        {
          if(string.Equals(item.nombre,item2.nombre))
          {
            item2.stock = item2.stock + item.stock;
            flag = 1;
          }
        }
        if (flag == 0)
        {
          d1.productos.Add(item);
        }
      }
      return d1.productos;
    }
        
        
  }
}
