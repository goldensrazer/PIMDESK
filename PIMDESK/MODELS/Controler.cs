using PIMDESK.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMDESK.MODELS
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


    }
}
