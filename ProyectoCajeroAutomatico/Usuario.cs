using System;
using System.Collections.Generic;

public class Usuario
{
    Cuenta cuenta = new Cuenta();

    public int UsuarioId { get; set; }
    public string UsuarioNombre { get; set; }
    public int UsuarioPin { get; set; }
    public bool UsuarioEstado { get; set; }

    public Usuario(int usuarioId, string usuarioNombre, int usuarioPin, bool usuarioEstado)
    {
        UsuarioId = usuarioId;
        UsuarioNombre = usuarioNombre;
        UsuarioPin = usuarioPin;
        UsuarioEstado = usuarioEstado;
    }

    private List<Usuario> usuarios;

    public Usuario()
    {
        usuarios = new List<Usuario>();
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        cuenta.RegistrarCuenta(new Cuenta(usuario.UsuarioId, "BASICA", 0, usuario.UsuarioId));
   
        Console.WriteLine($"Usuario {usuario.UsuarioNombre} agregado exitosamente");

    }

    public void EliminarUsuario()
    {
        UsuarioEstado = false;
    }
}


