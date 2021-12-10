using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private string nombre;
        private List<Vehiculo> listadoVehiculos;
        private static Estacionamiento estacionamiento;

        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return Estacionamiento.estacionamiento;
        }
        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Retiro Estacionamiento {this.nombre}");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"El cargo por estacionamiento es: {vehiculo.CostoEstadia.ToString("00.0")}");
            return sb.ToString();
        }


        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (estacionamiento.listadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                Estacionamiento.estacionamiento.listadoVehiculos.Add(vehiculo);
                returnAux = true;
            }
            return returnAux;
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                Estacionamiento.estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return returnAux;
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            bool returnAux = false;
            if (Estacionamiento.estacionamiento.listadoVehiculos.Count > 0)
            {
                foreach (Vehiculo v in estacionamiento.listadoVehiculos)
                {
                    if (v == vehiculo)
                    {
                        returnAux = true;
                        break;
                    }
                }
            }
            return returnAux;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }
    }

}
