using System;

public class Cuenta
{
    public int CuentaNumero { get; set; }
    public string CuentaTipo { get; set; }
    public decimal CuentaSaldo { get; set; }
    public int UsuarioId { get; set; }

    public Cuenta(int cuentaNumero, string cuentaTipo, decimal cuentaSaldo, int usuarioId)
    {
        UsuarioId = usuarioId;
        CuentaTipo = cuentaTipo;
        CuentaSaldo = cuentaSaldo;
        CuentaNumero = cuentaNumero;
    }

    private List<Cuenta> cuentas;

    public Cuenta()
    {
        cuentas = new List<Cuenta>();
    }

    public void RegistrarCuenta(Cuenta cuenta)
    {
        cuentas.Add(cuenta);

    }

    public decimal Saldo()
    {

        decimal CuentaSaldo = 0;

        switch (UsuarioId)
        {
            case 1:
                CuentaSaldo = 0;
                break;
            case 2:
                CuentaSaldo = 0;
                break;
        }
        return CuentaSaldo;
    }

    public int ValidaUsuario(int usuarioId)
    {
        int CuentaNumero = 0;

        switch (usuarioId)
        {
            case 1:
                CuentaNumero = 2345;
                break;
            case 2:
                CuentaNumero = 4567;
                break;
        }
        return CuentaNumero;
    }
}

