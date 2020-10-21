using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Banco
{
    class Cuenta_bancaria
    {
        public decimal numCuenta;
        public float saldo;
        public float tipoInteres;
        public string nombre;

        public Cuenta_bancaria(decimal numCuenta, float saldo, float tipoInteres, string nombre)
        {
            this.numCuenta = numCuenta;
            this.saldo = saldo;
            this.tipoInteres = tipoInteres;
            this.nombre = nombre;
        }

        public decimal NumCuenta { get => NumCuenta; set => NumCuenta = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public float TipoInteres { get => tipoInteres; set => tipoInteres = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public decimal getNumCuenta()
        {
            return this.numCuenta;
        }
        public string status()
        {
            return "Estado de la cuenta:" + "\nNúmero de cuenta: " + this.numCuenta + "\nSaldo: " + this.saldo + " €" + "\nInterés: " + this.tipoInteres + " %" + "\nNombre: " + this.nombre;
            
        }


    }
}
