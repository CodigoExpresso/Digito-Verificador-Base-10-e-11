/*
 * 
 * Calculo de digito verificador Base 10 e 11, muito utilizada em calculo de digito verificador em boletos bancarios.
 *
 * by Antonio Azevedo
 * Visite nossa página http://www.codigoexpresso.com.br
 * 
 * public static int DigitoM10(long intNumero)
 *        Calcula o digito verificador base 10
 * 
 * public static int DigitoM11(long intNumero)
 *        Calcula o digito verificador base 11
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class DigitoVerificadorBase10e11
{

    /// <summary>
    ///  Calculo de digito Modulo 10
    /// </summary>
    /// <param name="intNumero">Informar o numero para calculo digito</param>
    /// <returns>Retorna o digito</returns>

    public static int DigitoM10(long intNumero)
    {
        int[] intPesos = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
        string strText = intNumero.ToString();

        if (strText.Length > 16)
            throw new Exception("Número não suportado pela função!");

        int intSoma = 0;
        int intIdx = 0;
        for (int intPos = strText.Length - 1; intPos >= 0; intPos--)
        {
            intSoma += Convert.ToInt32(strText[intPos].ToString()) * intPesos[intIdx];
            intIdx++;
        }

        intSoma = intSoma % 10;
        intSoma = 10 - intSoma;
        if (intSoma == 10)
        {
            intSoma = 0;
        }

        return intSoma;
    }


    /// <summary>
    ///  Calculo de digito Modulo 11
    /// </summary>
    /// <param name="intNumero">Informar o numero para calculo digito</param>
    /// <returns>Retorna o digito</returns>
    public static int DigitoM11(long intNumero)
    {
        int[] intPesos = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5, 6, 7, 8, 9 };
        string strText = intNumero.ToString();

        if (strText.Length > 16)
            throw new Exception("Número não suportado pela função!");

        int intSoma = 0;
        int intIdx = 0;
        for (int intPos = strText.Length - 1; intPos >= 0; intPos--)
        {
            intSoma += Convert.ToInt32(strText[intPos].ToString()) * intPesos[intIdx];
            intIdx++;
        }
        int intResto = (intSoma * 10) % 11;
        int intDigito = intResto;
        if (intDigito >= 10)
            intDigito = 0;

        return intDigito;
    }
}

