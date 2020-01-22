using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ProyectoMvcEneroAjax.Helpers
{
    public class HelperCifrado
    {
        public static String CifrarHashSimple(String texto)
        {
            //Cualquier cifrado va a nivel de Bytes
            byte[] entrada, salida;

            //Convierte a bytes
            UnicodeEncoding conversor = new UnicodeEncoding();

            //Permite poder cifrar, otra vez a bytes
            SHA1Managed sha = new SHA1Managed();

            entrada = conversor.GetBytes(texto);
            salida = sha.ComputeHash(entrada); //Cifra los bytes de entrada

            return conversor.GetString(salida);
        }

        public static String CifrarHashEficiente(String texto, String salt, int iteraciones)
        {
            String contenido = texto + salt;

            SHA256Managed sha = new SHA256Managed();

            //Byte de salida y guardamos en salida el contenido
            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenido);

            //Hacemos el cifrado n veces, tantas iteraciones como hayan dicho
            for (int i = 1; i <= iteraciones; i++)
            {
                salida = sha.ComputeHash(salida);
            }

            String resultado = Encoding.UTF8.GetString(salida);
            return resultado;
        }

        public static byte[] CifrarPass(String texto, String salt) //Texto es el password
        {
            String contenido = texto + salt;

            SHA256Managed sha = new SHA256Managed();

            //Byte de salida y guardamos en salida el contenido
            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenido);

            //Hacemos el cifrado n veces, tantas iteraciones como queramos
            for (int i = 1; i <= 20; i++)
            {
                salida = sha.ComputeHash(salida);
            }

            return salida;
        }

        public static String GenerarSalt()
        {
            Random alea = new Random();
            String salt = "";

            for (int i = 1; i <= 50; i++)
            {
                int rand = alea.Next(1, 255);
                char letra = Convert.ToChar(rand);
                salt += letra;
            }
            return salt;
        }

        public static Boolean CompararBytes(byte[] array1, byte[] array2)
        {
            //Comparamos la longitud
            if (array1.Length != array2.Length)
            {
                return false;
            }

            //Comparamos los bytes
            bool iguales = true;

            for (int i = 0; i < array1.Length; i++) {
                if (array1[i].Equals(array2[i]) == false)
                {
                    iguales = false;
                    break;
                }
            }
            return iguales;
        }

        public static String EncriptarText(String mensaje, byte[] pass)
        {
            //Creamos el objeto Rijdael para realizar el cifrado asimétrico
            Rijndael cifradoRij = Rijndael.Create();

            //Creamos los objetos para realizar el cifrado
            byte[] byteEncriptado = null;
            byte[] salida = null;
            try { 
                //Guardamos la clave a nivel de bytes
                cifradoRij.Key = pass;

                //Le enviamos el vector de inicialización
                cifradoRij.GenerateIV();

                //Convertimos el texto enviado a bytes
                byte[] entrada = System.Text.Encoding.UTF8.GetBytes(mensaje);

                //Ciframos el texto a nivel de bytes con createencryptor
                //Quien nos devuelve un array de bytes con el resultado 
                //del cifrado
                byteEncriptado = (cifradoRij.CreateEncryptor()).
                    TransformFinalBlock(entrada, 0, entrada.Length);

                //Dimensionamos nuestro array de bytes de salida
                //al tamaño del cofrado
                salida = new byte[cifradoRij.IV.Length + byteEncriptado.Length];

                //Copiamos los datos cifrados al byte de salida
                //Debemos copiar tanto el vector de inicialización
                //Como los datos encriptados
                //Son una secuencia consecutiva
                cifradoRij.IV.CopyTo(salida, 0);
                byteEncriptado.CopyTo(salida, cifradoRij.IV.Length);
            } catch{
                throw new Exception("Error al cifrar los datos");
             }finally{
                //Limpiamos el objeto de cifrado
                cifradoRij.Clear();
            }

            String textoSalida = Encoding.Default.GetString(salida);


            return textoSalida;
        }

        public static String DesencriptarTexto(byte[] byteDatosCifrados, byte[] pass)
        {
            //Creamos el objeto para descifrar los datos
            Rijndael cifradoRij = Rijndael.Create();

            //Indicamos el tamaño de los objetos de Bytes que 
            //usaremos para el cifrado
            byte[] arrayTemporal = new byte[cifradoRij.IV.Length];
            byte[] byteEncriptado = new byte[byteDatosCifrados.Length
                - cifradoRij.IV.Length]; ///DESBORDAMIENTO
            String textoDescifrado = string.Empty;

            try
            {
                //Enviamos el pass al rijdael
                cifradoRij.Key = pass;

                //Copiamos los datos cifrados en el mismo orden
                //que antes los habiamos cifrado
                Array.Copy(byteDatosCifrados, arrayTemporal, arrayTemporal.Length);
                Array.Copy(byteDatosCifrados, arrayTemporal.Length, byteEncriptado,
                    0, byteEncriptado.Length);

                //Enviamos el vector de inicialización
                cifradoRij.IV = arrayTemporal;

                //Desencriptamos el texto
                textoDescifrado = System.Text.Encoding.UTF8.GetString(cifradoRij.CreateDecryptor().
                    TransformFinalBlock(byteEncriptado, 0, byteEncriptado.Length));
            }
            catch { }
            finally { cifradoRij.Clear(); }

            return textoDescifrado;
        }

    }
}