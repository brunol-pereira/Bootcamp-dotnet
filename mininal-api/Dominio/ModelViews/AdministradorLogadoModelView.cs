using mininal_api.Dominio.Enums;

namespace mininal_api.Dominio.ModelViews
{
    public record AdministradorLogadoModelView
    {
        public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
        public string Token { get; set; } = default!;
        
    }
}