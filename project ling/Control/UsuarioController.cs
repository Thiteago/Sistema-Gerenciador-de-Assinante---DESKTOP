using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_ling.Model;

namespace project_ling.Control
{
    public class UsuarioController
    {
        public bool tem;
        public String mensagem = "";
        
        //Método de verificação do Login
        
        public bool acessar(String usuario, String senha)
        {
            UsuarioDAO loginDao = new UsuarioDAO();

            tem = loginDao.verificarLogin(usuario, senha);

            if (!loginDao.mensagem.Equals("")){
                this.mensagem = loginDao.mensagem;
            }

            return tem;
        }

    }
}
