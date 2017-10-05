using Condominio.Model.Enum;

namespace Condominio.Model
{
    public class ReservaAreaDeLazer : Entidade
    {
        public ReservaAreaDeLazer()
        {
            Morador = new Morador();
            AreaDeLazer = new AreaDeLazer();
        }
        public Morador Morador { get; set; }
        public AreaDeLazer AreaDeLazer { get; set; }
        public string Descricao { get; set; }
        public DisponibilidadeDaAreaDeLazer DisponibilidadeDaAreaDeLazer { get; set; }
    }
}
