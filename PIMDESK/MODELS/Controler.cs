using PIM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.MODELS
{
   public class Controler
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDalComands LoginDal = new LoginDalComands();
            tem = LoginDal.verificarLogin(login, senha);

            if (!LoginDal.mensagem.Equals("")){
                this.mensagem = LoginDal.mensagem; 
                }
            return tem;
        }

        public bool acessar2(String login, String senha)
        {
            LoginDalComands LoginDal = new LoginDalComands();
            tem = LoginDal.verificarLogin2(login, senha);

            if (!LoginDal.mensagem.Equals(""))
            {
                this.mensagem = LoginDal.mensagem;
            }
            return tem;
        }


    }
}
