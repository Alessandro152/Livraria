using Livraria.Models.Entities;
using System;
using System.Linq;

namespace Livraria.Data.Service
{
    public class UserService
    {
        internal void SalvarCadastroUsuario(UsuarioCadastro dados)
        {
            using (var db = new LivrariaContext())
            {
                try
                {                    
                    db.Login.Add(dados.Login);
                    db.Usuario.Add(dados.Usuario);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    db.Dispose();
                }
            }
        }

        internal bool GetUser(string user, string password)
        {
            using (var db = new LivrariaContext())
            {
                try
                {
                    return db.Login.Where(x => x.UserMail == user && x.UserPassword == password).Any();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    db.Dispose();
                }
            }
        }
    }
}
