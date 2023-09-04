using System.ComponentModel;

namespace TrilhaApiDesafio.Models
{
    public enum EnumStatusTarefa
    {
        [Description("Pendente")]        
        Pendente = 0,
        [Description("Finalizado")]
        Finalizado = 1
    }
}