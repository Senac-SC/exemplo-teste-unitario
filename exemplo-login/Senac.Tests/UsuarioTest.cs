using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Senac.Tests
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void Login_EmailSenhaCorretos(){
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("juliana.m@edu.sc.senac.br","123456");

            Assert.AreEqual("Bem vinda!",resultado);
        }

        [TestMethod]
        public void Login_EmailIncorreto(){
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("juliana.m@senac.br","123456");

            Assert.AreEqual("E-mail ou senha incorretos!",resultado);
        }

        [TestMethod]
        public void Login_SenhaIncorreta(){
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("juliana.m@edu.sc.senac.br","123");

            Assert.AreEqual("E-mail ou senha incorretos!",resultado);
        }

        [TestMethod]
        public void Login_SenhaVazia(){
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("juliana.m@edu.sc.senac.br","");

            Assert.AreEqual("Preencha todos os dados!",resultado);
        }

        [TestMethod]
        public void Login_EmailVazio(){
            Usuario usuario = new Usuario();
            var resultado = usuario.Login("","123456");
            Assert.AreEqual("Preencha todos os dados!",resultado);
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void VerificarNome_RetornoFalso(string value){
            Usuario usuario = new Usuario();
            var resultado = usuario.VerificarNome(value);

            Assert.IsFalse(resultado);
        }


    }
}