using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI
{
    //Interface: Implementación
    //Clases : Hereda
   
    #region Interfaces
    public interface ILogin
    {
        void IniciarSesion();
        void CerrarSesion();

    }

    public interface ISeguridad
    {
        void ValidarContraseña();
        void CambiarContraseña();
        void ResetContraseña();

    }

    public interface IAccionesUsuario
    {
        void EliminarCuenta();
        void ModificarCuenta();
        void CrearCuenta();
        void BuscarCuenta();
    }

    public interface IMantenimiento {
        void Eliminar();
        void Modificar();
        void Crear();
        void Listar();        
    }
    public interface IBusquedas
    {
        void BuscarPorFiltros();
    }




    #endregion


    public class Cliente : IMantenimiento, IBusquedas
    {
        public void BuscarPorFiltros()
        {
            throw new NotImplementedException();
        }

        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }

    public class Persona : IMantenimiento, IBusquedas
    {
        public void BuscarPorFiltros()
        {
            throw new NotImplementedException();
        }
        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }

    public class Categoria : IMantenimiento
    {


        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }

    public class Producto : IMantenimiento
    {
        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public void Modificar()
        {
            throw new NotImplementedException();
        }
    }
    public class Login : ILogin
    {
        public void CerrarSesion()
        {
            throw new NotImplementedException();
        }

        public void IniciarSesion()
        {
            throw new NotImplementedException();
        }
    }

    public class Seguridad : ISeguridad
    {
        public void CambiarContraseña()
        {
            throw new NotImplementedException();
        }

        public void ResetContraseña()
        {
            throw new NotImplementedException();
        }

        public void ValidarContraseña()
        {
            throw new NotImplementedException();
        }
    }

    public class Usuario : IAccionesUsuario
    {
        public void BuscarCuenta()
        {
            throw new NotImplementedException();
        }

        public void CrearCuenta()
        {
            throw new NotImplementedException();
        }

        public void EliminarCuenta()
        {
            throw new NotImplementedException();
        }

        public void ModificarCuenta()
        {
            throw new NotImplementedException();
        }
    }



}
