using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mininal_api.Dominio.DTO;
using mininal_api.Dominio.Entidades;

namespace mininal_api.Dominio.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador? Login(LoginDTO loginDTO);
        Administrador Incluir(Administrador administrador);
        Administrador? BuscaPorId(int id);
        List<Administrador> Todos(int? pagina = 1);
        
    }
}