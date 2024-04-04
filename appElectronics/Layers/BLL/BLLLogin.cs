using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronics.Interfaces;
using UTN.Winform.Electronics.Layers.DAL;

namespace UTN.Winform.Electronics.Layers.BLL
{
    class BLLLogin : IBLLLogin
    {
        public bool Login(string pUsuario, string pContrasena)
        {
            IDALLogin _DALLogin = new DALLogin();
            return _DALLogin.Login(pUsuario,   pContrasena);
        }
    }
}
