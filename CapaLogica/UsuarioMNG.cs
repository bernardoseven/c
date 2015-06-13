using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEntidades;
using CapaAcceso;

namespace CapaLogica
{
    public class UsuarioMNG
    {
        public bool IsUsuario(Veterinario v)
        {
            return new CapaAcceso.UsuarioDAO().IsUsuario(v);
        }

        public void IsVeterianrio(Usuario u) {

             new CapaAcceso.UsuarioDAO().InsertarVeterinario(u);
        }
    }
}
