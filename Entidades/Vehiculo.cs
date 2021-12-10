using System;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        
        public enum EVehiculos { Automovil, Moto };
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private string patente;
        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.horaIngreso = horaIngreso;
            this.patente = patente;
        }
        public string Patente
        {
            get 
            {
                return this.patente;
            }
            set 
            {
                if(this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }
        public abstract string Descripcion{ get; }
        public abstract double CostoEstadia { get; }
        public DateTime HoraIngreso { get { return this.horaIngreso; }}

        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value > this.horaIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        private bool ValidarPatente(string patente)
        {
            bool returnAux = false;
            if (!string.IsNullOrEmpty(patente) && patente.Length >= 6 && patente.Length < 8)
            {
                returnAux = true;
            }
            return returnAux;
        }
        
        protected virtual double CargoDeEstacionamiento()
        {
            double horasAcumuladas= 0;
            if (this.HoraEgreso > this.HoraIngreso)
            {
                horasAcumuladas = (this.HoraEgreso - this.horaIngreso).TotalHours;
            }
            return horasAcumuladas;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder returnAux = new StringBuilder();
            returnAux.AppendLine($"Patente {this.Patente}");
            returnAux.AppendLine($"Ingreso {this.HoraIngreso}");
            return returnAux.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
