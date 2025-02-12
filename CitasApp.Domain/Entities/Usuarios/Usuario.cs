﻿
namespace CitasApp.Domain.Entities.Usuarios
{
    public class Usuario : AuditEntity
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }