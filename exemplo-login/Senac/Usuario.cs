
namespace Senac
{
    public class Usuario
    {
        public string Login(string pEmail, string pSenha){
            if(string.IsNullOrEmpty(pEmail) || string.IsNullOrEmpty(pSenha)){
                return "Preencha todos os dados!";
            }
            else if(pEmail == "juliana.m@edu.sc.senac.br" && pSenha == "123456"){
                return "Bem vinda!";
            }
            else{
                return "E-mail ou senha incorretos!";
            }
        }

        public bool VerificarNome(string pNome){
            if(string.IsNullOrEmpty(pNome)){
                return false;
            }
            else{
                return true;
            }
        }
        
    }
}