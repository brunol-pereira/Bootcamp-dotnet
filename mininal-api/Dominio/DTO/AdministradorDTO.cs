using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mininal_api.Dominio.Enums;

namespace mininal_api.Dominio.DTO
{
    public class AdministradorDTO
    {
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;
        public Perfil? Perfil { get; set; } = default!;
        
    };
}