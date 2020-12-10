
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlatosComida
{
    class Plato : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen;
        private string tipo;
        private bool gluten;
        private bool soja;
        private bool leche;
        private bool sulfitos;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    NotifyPropetyChanged("Nombre");
                }
            }
        }
        public string Imagen
        {
            get => imagen;
            set
            {
                if (imagen != value)
                {
                    imagen = value;
                    NotifyPropetyChanged("Imagen");
                }
            }
        }
        public string Tipo
        {
            get => tipo;
            set
            {
                if (tipo != value)
                {
                    tipo = value;
                    NotifyPropetyChanged("Tipo");
                }
            }
        }
        public bool Gluten
        {
            get => gluten;
            set
            {
                if (gluten != value)
                {
                    gluten = value;
                    NotifyPropetyChanged("Gluten");
                }
            }
        }
        public bool Soja
        {
            get => soja;
            set
            {
                if (soja != value)
                {
                    soja = value;
                    NotifyPropetyChanged("Soja");
                }
            }
        }
        public bool Leche
        {
            get => leche;
            set
            {
                if (leche != value)
                {
                    leche = value;
                    NotifyPropetyChanged("Leche");
                }
            }
        }
        public bool Sulfitos
        {
            get => sulfitos;
            set
            {
                if (sulfitos != value)
                {
                    sulfitos = value;
                    NotifyPropetyChanged("Sulfitos");
                }
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropetyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static List<Plato> GetSamples(string rutaImagenes)
        {
            List<Plato> lista = new List<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}
