using System;

// Debemos incluir esta libreria
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class HashTable
    {
        // Creamos nuestra tabla hash
        Hashtable tablaHash = new Hashtable();

        // el uso de este es solo para iterar
        private string contenido;
        public string Contenido { get; set; }

        // Damos un valor númerico a una letra  (pudimos haber implementado "GetNumericValue")
        public int ValorNumerico(char caracter)
        {
            switch (caracter)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                case 'i':
                    return 9;
                case 'j':
                    return 10;
                case 'k':
                    return 11;
                case 'l':
                    return 12;
                case 'm':
                    return 13;
                case 'n':
                    return 14;
                case 'ñ':
                    return 15;
                case 'o':
                    return 16;
                case 'p':
                    return 17;
                case 'q':
                    return 18;
                case 'r':
                    return 19;
                case 's':
                    return 20;
                case 't':
                    return 21;
                case 'u':
                    return 22;
                case 'v':
                    return 23;
                case 'w':
                    return 24;
                case 'y':
                    return 25;
                case 'x':
                    return 26;
                default:
                    return 27;
            }
        }

        // Damos un valor númerico a una letra a la inversa
        public int ValorNumericoInversa(char caracter)
        {
            switch (caracter)
            {
                case 'a':
                    return 27;
                case 'b':
                    return 26;
                case 'c':
                    return 25;
                case 'd':
                    return 24;
                case 'e':
                    return 23;
                case 'f':
                    return 22;
                case 'g':
                    return 21;
                case 'h':
                    return 20;
                case 'i':
                    return 19;
                case 'j':
                    return 18;
                case 'k':
                    return 17;
                case 'l':
                    return 16;
                case 'm':
                    return 15;
                case 'n':
                    return 14;
                case 'ñ':
                    return 13;
                case 'o':
                    return 12;
                case 'p':
                    return 11;
                case 'q':
                    return 10;
                case 'r':
                    return 9;
                case 's':
                    return 8;
                case 't':
                    return 7;
                case 'u':
                    return 6;
                case 'v':
                    return 5;
                case 'w':
                    return 4;
                case 'y':
                    return 3;
                case 'x':
                    return 2;
                default:
                    return 1;
            }
        }

        // Creamos nuestro funcion hash
        public int HashFunction(string valor)
        {
            // agarramos datos necesarios
            char primeraLetra = valor[0];
            char ultimaLetra = valor.Last();
            int cantidadLetras = valor.Length;

            // primera parte para el hash
            int primerValor = ValorNumerico(primeraLetra);
            int segundoValor = ValorNumerico(ultimaLetra);
            int tercerValor = primerValor * segundoValor;
            int cuartoValor = tercerValor * cantidadLetras;

            // segunda parte del hash
            primerValor = ValorNumericoInversa(primeraLetra);
            segundoValor = ValorNumericoInversa(ultimaLetra);
            tercerValor = primerValor * segundoValor;
            int quintoValor = tercerValor * cantidadLetras;

            // juntamos las dos partes (concatenarlas no se suman)
            int hash = int.Parse(cuartoValor.ToString() + quintoValor.ToString());

            // para ahorrar espacio lo limitamos a 50 opciones (modulus operator)
            hash = hash % 50;
            
            return hash;
        }

        // Creamos una funcion para evitar colisiones (lineal probing / sondeo lineal)
        public void ColissionOmitter(int indexValue, string valor)
        {
            bool colision = false;

            // revisamos si hay colision
            try
            {
                // si no existe una colision se agrega el valor en el index dado
                addValue(indexValue, valor);
            }
            catch (Exception)
            {
                // si, si existe una colision ponemos una bandera
                colision = true;
            }

            // en el caso que existiera colision
            while (colision == true)
            {
                // le sumamos uno al indexvalue hasta encontrar un espacio libre
                indexValue++;
                try
                {
                    addValue(indexValue, valor);
                    colision = false;
                }
                catch (Exception)
                {
                }
            }
        }

        // creamos la funcion para adicionar elementos nuevos
        public void addValue(int indexValue, string valor)
        {
            tablaHash.Add(indexValue, valor);
        }

        // Mostramos los elementos de la tabla hash
        public string iterarTabla()
        {
            // vaciamos el contenido de "contenido"
            Contenido = "";
            // usando un foreach recorremos la estructura de datos aprovechando el dictionaryentry
            foreach (DictionaryEntry element in tablaHash)
            {
                Contenido += "\r\nLlave: " + element.Key + "     Elemento: " + element.Value;
            }
            return Contenido;
        }
            
        // Contamos cuantos elementos existen dentro de la tabla hash
        public int countTabla()
        {
            return tablaHash.Count;
        }

        // Obtenemos un elemento (valor) de determinada llave
        public string searchByKey(int key)
        {
            try
            {
                return tablaHash[key].ToString();
            } 
            catch (Exception)
            {
                return "Null. Ejecute el boton \"Contains\"";
            }
        }

        // Verificamos si existe cierto elemento en la tabla hash
        public bool containsElement(int key)
        {
            // retorna un booleano
            return tablaHash.Contains(key);
        }

        // Eliminamos un elemento de la tabla hash
        public void removeElement(int key)
        {
            tablaHash.Remove(key);
        }
    }
}
