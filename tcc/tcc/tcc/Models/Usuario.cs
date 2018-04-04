using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tcc.Models;

namespace tcc.Models
{
    public class Usuario
    {
        public bool cadastraUsuario(tb_usuarios objUsuario)
        {
            using (var db = new ModeloEntities())
            {
                db.tb_usuarios.Add(objUsuario);

                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public tb_usuarios UsuarioPorLoginEsenha(tb_usuarios objUsuario)
        {

            var db = new ModeloEntities();
            return db.tb_usuarios.Where(x => x.tx_login == objUsuario.tx_login && x.tx_senha == objUsuario.tx_senha).FirstOrDefault();
            
        }
    }
}