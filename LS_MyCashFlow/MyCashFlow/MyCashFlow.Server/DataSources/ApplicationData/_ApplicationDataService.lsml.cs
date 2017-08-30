using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        void Cuentas_Changing(Cuenta entity)
        {
            entity.Nombre = entity.Nombre.Trim().ToUpper();
        }

        partial void Cuentas_Inserting(Cuenta entity)
        {
            Cuentas_Changing(entity);
        }

        partial void Cuentas_Updating(Cuenta entity)
        {

        }

        void Monedas_Changing(Moneda entity)
        {
            entity.Nab = entity.Nab.Trim().ToUpper();
        }

        partial void Monedas_Inserting(Moneda entity)
        {
            Monedas_Changing(entity);
        }

        partial void Monedas_Updating(Moneda entity)
        {
            Monedas_Changing(entity);
        }

        void Parametros_Changing(Parametro entity)
        {
            entity.Categoria = entity.Categoria.Trim().ToUpper();
            entity.Clave = entity.Clave.Trim().ToUpper();
        }


        partial void Parametros_Inserting(Parametro entity)
        {
            Parametros_Changing(entity);
        }

        partial void Parametros_Updating(Parametro entity)
        {
            Parametros_Changing(entity);
        }

        void TipoCuentas_Changing(TipoCuenta entity)
        {
            entity.Tipo = entity.Tipo.Trim().ToUpper();
        }

        partial void TipoCuentas_Inserting(TipoCuenta entity)
        {
            TipoCuentas_Changing(entity);
        }

        partial void TipoCuentas_Updating(TipoCuenta entity)
        {
            TipoCuentas_Changing(entity);
        }
    }
}