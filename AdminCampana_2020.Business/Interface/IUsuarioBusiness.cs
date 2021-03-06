﻿using AdminCampana_2020.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminCampana_2020.Business.Interface
{
    public interface IUsuarioBusiness
    {
        UsuarioDomainModel ValidarLogin(string email, string password);
        bool AddUpdateUsuarios(UsuarioRolDomainModel usuarioDM);
        List<UsuarioDomainModel> GetUsuarios();
        UsuarioDomainModel GetUsuario(int id);
        List<string> GetUsuariosByApellidos(string apellidos);

        bool BajaUsuario(UsuarioDomainModel usuarioDM);
        bool UpdateUsuario(UsuarioDomainModel usuarioDomainModel);

        bool AddUser(UsuarioDomainModel usuarioDomainModel);

        List<UsuarioDomainModel> GetUsuariosByCoordinador(int id);
    }
}
