using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Cliente
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _pais;
        private string _genero;
        private bool _vip;
        private DateTime _fecha;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public bool Vip
        {
            get { return _vip; }
            set { _vip = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Cliente(int id, string nombre, string apellido, int edad, string pais, string genero, bool vip, DateTime fecha)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Pais = pais;
            Genero = genero;
            Vip = vip;
            Fecha = fecha;
        }
    }
}
