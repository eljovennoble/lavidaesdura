using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto 
{
    string Nombre_Objeto;
    string Texto_Objeto;
    int ID_Objeto;
    int PrecioObjeto;

    public Objeto(string nombre_Objeto, string texto_Objeto, int iD_Objeto, int precioObjeto)
    {
        Nombre_Objeto = nombre_Objeto;
        Texto_Objeto = texto_Objeto;
        ID_Objeto = iD_Objeto;
        PrecioObjeto = precioObjeto;
    }

    public void setNombreObjeto(string aa) { Nombre_Objeto = aa; }
    public string getNombreObjeto() { return Nombre_Objeto; }
    public void setTextoObjeto(string bb) { Texto_Objeto = bb; }
    public string getTextoObjeto() { return Texto_Objeto; }
    public void setIdObjeto(int bb) { ID_Objeto = bb; }
    public int getIdObjeto() { return ID_Objeto; }
    public void setPrecioObjeto(int cc) { PrecioObjeto = cc; }
    public int getPrecioObjeto() { return PrecioObjeto; }

}
