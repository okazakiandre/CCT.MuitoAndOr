namespace CCT.MuitoAndOr.App
{
    public class Usuario
    {
        public string TipoPerfil { get; set; }
        public bool EhPerfilInterno() => TipoPerfil == "0";
        public bool EhTestadorInterno(int tipoAcesso) =>
            tipoAcesso == 1 && EhPerfilInterno();
        public bool EhPerfilExterno() => TipoPerfil == "3";

        public string VerificarAcesso(int tipoAcesso, string tipoMovimentacao)
        {
            var ehMovimentoCriacao = tipoMovimentacao == "7";

            if (EhTestadorInterno(tipoAcesso) || 
                ehMovimentoCriacao || 
                EhPerfilExterno())
            {
                return "liberar";
            }

            return "bloquear";
        }
    }
}
