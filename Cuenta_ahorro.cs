using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Cuenta_ahorro : Cuenta_bancaria
    {
        float cuotaMantenimiento;

        public Cuenta_ahorro(float cuotaMantenimiento):base()
        {
            this.cuotaMantenimiento = cuotaMantenimiento;
        }

        public void setCuotaMantenimiento(float cuota)
        {
            this.cuotaMantenimiento = cuota;
        }

        public float getCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }
    }
}
