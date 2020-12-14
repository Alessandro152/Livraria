using Livraria.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                    var login = new UsuarioCadastro
                    {
                        Login = new Login()
                        {
                            Email = dados.Login.Email,
                            Password = dados.Login.Password
                        },

                        Usuario = new Usuario()
                        {
                            UsuarioNome = dados.Usuario.UsuarioNome,
                            UsuarioEndereco = dados.Usuario.UsuarioEndereco,
                            UsuarioTelefone = dados.Usuario.UsuarioTelefone
                        }
                    };

                    db.UsuarioCadastro.Add(login);
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
                    return db.Login.Where(x => x.Email == user && x.Password == password).Any();
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
