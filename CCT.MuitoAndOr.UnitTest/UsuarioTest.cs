using CCT.MuitoAndOr.App;

namespace CCT.MuitoAndOr.UnitTest
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void DeveriaLiberarAcessoParaTipoAcesso1EPerfilZero()
        {
            var usr = new Usuario { TipoPerfil = "0"};
            var res = usr.VerificarAcesso(1, "0");
            Assert.AreEqual("liberar", res);
        }

        [TestMethod]
        public void DeveriaLiberarAcessoParaMovimentacaoDeCriacao()
        {
            var usr = new Usuario { TipoPerfil = "5" };
            var res = usr.VerificarAcesso(0, "7");
            Assert.AreEqual("liberar", res);
        }

        [TestMethod]
        public void DeveriaLiberarAcessoParaPerfil3()
        {
            var usr = new Usuario { TipoPerfil = "3" };
            var res = usr.VerificarAcesso(0, "0");
            Assert.AreEqual("liberar", res);
        }

        [TestMethod]
        public void DeveriaBloquearAcessoParaPerfilZeroETipoAcessoDiferenteDe1()
        {
            var usr = new Usuario { TipoPerfil = "0" };
            var res = usr.VerificarAcesso(0, "0");
            Assert.AreEqual("bloquear", res);
        }

        [TestMethod]
        public void DeveriaBloquearAcessoParaPerfilDifDeZeroETipoAcesso1()
        {
            var usr = new Usuario { TipoPerfil = "5" };
            var res = usr.VerificarAcesso(1, "0");
            Assert.AreEqual("bloquear", res);
        }

        [TestMethod]
        public void DeveriaBloquearAcessoParaMovimentacaoDifDeCriacao()
        {
            var usr = new Usuario { TipoPerfil = "5" };
            var res = usr.VerificarAcesso(0, "0");
            Assert.AreEqual("bloquear", res);
        }

        [TestMethod]
        public void DeveriaBloquearAcessoParaPerfilDifDe3()
        {
            var usr = new Usuario { TipoPerfil = "1" };
            var res = usr.VerificarAcesso(1, "0");
            Assert.AreEqual("bloquear", res);
        }
    }
}