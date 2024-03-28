using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PayrollPal.Layers.Util
{
    public class Contrasenna
    {
        public static bool ContrasennaFuerte (string pContrasenna)
        {
            // Chequear por la longitud de contraseña
            if (pContrasenna.Length < 8 ||
                pContrasenna.Length > 16)
                return false;

            // Chequear por la presencia de letras 
            // mayúsculas
            if (!Regex.IsMatch(pContrasenna, "[A-Z]"))
                return false;

            // Chequear por la presencia de letras 
            // minúsculas
            if (!Regex.IsMatch(pContrasenna, "[a-z]"))
                return false;

            // Chequear por la presencia de dígitos 
            if (!Regex.IsMatch(pContrasenna, "[0-9]"))
                return false;

            // Chequear por la presencia de caracteres
            // especiales 
            if (!Regex.IsMatch(pContrasenna, "[^A-Za-z0-9]"))
                return false;

            // Todos los requisitos se cumplen, retorna true
            return true;
        }
    }
}
