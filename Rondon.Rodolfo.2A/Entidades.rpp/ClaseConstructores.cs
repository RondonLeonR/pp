using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades.rpp
{
  public class ClaseConstructores
  {
    int par1;
    static ClaseConstructores cc;
    int par2;

    static ClaseConstructores() 
    {
      new ClaseConstructores(1, 2);
      MessageBox.Show("Constructor Estatico");
    }

    private ClaseConstructores(int parametro1 , int parametro2) : this()
    {
      MessageBox.Show("Constructor Privado Con 2 Parametros");
    }

    public ClaseConstructores() 
    {
      //cc = ClaseConstructores();
      MessageBox.Show("Constructor Default");
    }

    public int MyProperty
    {
      set
      {
        MessageBox.Show("Propiedad De Solo Escritura");
        
        this.par1 = this.MyProperty2;
      }
    }

    public int MyProperty2
    {
      get
      {
        MessageBox.Show("Propiedad De Solo Lectura");
        cc.MetodoInstancia();
        return this.par1;
      }
    }

    public void MetodoInstancia()
    {
      MessageBox.Show("Metodo De Instancia");
      ClaseConstructores.MetodoClase();
    }

    public static void MetodoClase()
    {
      MessageBox.Show("Propiedad De Clase");
    }

  }
}
