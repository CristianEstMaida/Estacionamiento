﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto : Vehiculo
    {
        private static double valorHora;
        public enum ETipo { Ciclomotor, Scooter, Sport };
        private ETipo tipo;
        static Moto()
        {
            valorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
            : base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public override string Descripcion { get { return this.tipo.ToString(); } }
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("****MOTO*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Tipo: {this.Descripcion}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
