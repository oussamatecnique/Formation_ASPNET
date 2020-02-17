using System;

namespace pam_metier_simule.metier.entites
{
    public class PamException : Exception
    {
        // classe d'exception

        // le code de l'erreur
        public int Code { get; set; }
        // constructeurs
        public PamException()
        {
        }
        public PamException(int Code)
        : base()
        {
            this.Code = Code;
        }
        public PamException(string message, int Code)
            : base(message)
        {
            this.Code = Code;
        }
        public PamException(string message, Exception ex, int Code)
        : base(message, ex)
        {
            this.Code = Code;
        }
    }
}

