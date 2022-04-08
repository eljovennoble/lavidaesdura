using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo 
{

    List <string> Hora;
    List <string> Dia; 
    int Num_Hora;
    int Num_Dia;
    int Num_Semana;
    

    public Tiempo(int num_Hora, int num_Dia, int num_Semana)
    {
        
        Num_Hora = num_Hora;
        Num_Dia = num_Dia;
        Num_Semana = num_Semana;
        Hora = new List<string>();
        Dia = new List<string>();
        Dia.Add("Lunes");
        Dia.Add("Martes");
        Dia.Add("Miércoles");
        Dia.Add("Jueves");
        Dia.Add("Viernes");
        Dia.Add("Sábado");
        Dia.Add("Domingo");
        Hora.Add("Mañana");
        Hora.Add("Mediodía");
        Hora.Add("Tarde");
        Hora.Add("Noche");
        Hora.Add("Madrugada");
        
    }

    public void setNumHora(int aa) { Num_Hora = aa;  if (Num_Hora == 5) { Num_Hora = 0; } }
    public int getNumHora() { return Num_Hora; }
    public void setNumDia(int bb) { Num_Dia = bb; }
    public int getNumDia() { return Num_Dia; }
    public void setNumSemana(int cc) { Num_Semana = cc; }
    public int getNumSemana() { return Num_Semana; }

    public string getHora() { return Hora[Num_Hora]; }
    public string getDia() { return Dia[Num_Dia];}

    
}
