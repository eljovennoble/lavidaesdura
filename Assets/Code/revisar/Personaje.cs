using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje 
{
    string Nombre_Personaje;
    int Energia_Personaje;
    int Felicidad_Personaje;
    int Conocimiento_Personaje;
    int Dinero_Personaje;
    int Comida_Personaje;
    int Experiencia_Personaje;
    int Nivel_Personaje;
    int LevelUpState;
    int Criterio_Profesor;
    int Favor_Jefe;
    float Promedio_Personaje;
    int Estado_Jugador;
    

    ///Cualidades
    int Suerte_Personaje;
    int Inteligencia_Personaje;
    int Carisma_Personaje;

    int PuntosPersonalidad;
    int PuntosHabilidad;

    public Personaje(string nombre_Personaje, int energia_Personaje, int felicidad_Personaje, int conocimiento_Personaje, int dinero_Personaje, int comida_Personaje, int experiencia_Personaje, int nivel_Personaje, int levelUpState, int suerte_Personaje, int inteligencia_Personaje, int carisma_Personaje)
    {
        Nombre_Personaje = nombre_Personaje;
        Energia_Personaje = energia_Personaje;
        Felicidad_Personaje = felicidad_Personaje;
        Conocimiento_Personaje = conocimiento_Personaje;
        Dinero_Personaje = dinero_Personaje;
        Comida_Personaje = comida_Personaje;
        ///
        Experiencia_Personaje = experiencia_Personaje;
        Nivel_Personaje = nivel_Personaje;
        LevelUpState = levelUpState;
        Suerte_Personaje = suerte_Personaje;
        Inteligencia_Personaje = inteligencia_Personaje;
        Carisma_Personaje = carisma_Personaje;
        Promedio_Personaje = 5;
        Favor_Jefe = 2;
        Criterio_Profesor = 2;
        Estado_Jugador = 1;

    }

    public string getNombre() { return Nombre_Personaje; }
    public void setNombre_Personaje(string aa) { Nombre_Personaje = aa; }
    public int getEnergia() { return Energia_Personaje; }
    public void setEnergia(int aa) { 
        Energia_Personaje = aa; 
        if (Energia_Personaje < 0) { Energia_Personaje = 0; }
        if (Energia_Personaje > 100) { Energia_Personaje = 100; }
    }

    public int getFelicidad() { return Felicidad_Personaje; }
    public void setFelicidad(int aa) { 
        Felicidad_Personaje = aa; 
        if (Felicidad_Personaje < 0) { Felicidad_Personaje = 0; }
        if (Felicidad_Personaje > 10) { Felicidad_Personaje = 10; }
    }
    public int getConocimiento() { return Conocimiento_Personaje; }
    public void setConocimiento(int aa) {
        Conocimiento_Personaje = aa;
        if (Conocimiento_Personaje < 0) { Conocimiento_Personaje = 0; }
        if (Conocimiento_Personaje > 10) { Conocimiento_Personaje = 10; }
    }
    public int getDinero() { return Dinero_Personaje; }
    public void setDinero(int aa)
    {
        Dinero_Personaje = aa;
        if (Dinero_Personaje < 0) { Dinero_Personaje = 0; }
    }
 
    public int getComida() { return Comida_Personaje; }
    public void setComida(int ha) {
        Comida_Personaje = ha;
        if (Comida_Personaje < 0) { Comida_Personaje = 0; }
        if (Comida_Personaje > 10) { Comida_Personaje = 10; }
    }
    public int getExperiencia() { return Experiencia_Personaje; }
    public void setExperiencia(int aa) { 
        Experiencia_Personaje = aa;
        ////////////////nivel del personaje//////////////
        if (Nivel_Personaje == 1 && Experiencia_Personaje > 51)  { Nivel_Personaje = 2; PuntosHabilidad++; PuntosPersonalidad++; LevelUpState = 1; }
        if (Nivel_Personaje == 2 && Experiencia_Personaje > 100) { Nivel_Personaje = 3; PuntosHabilidad++; PuntosPersonalidad++; LevelUpState = 1; }
        if (Nivel_Personaje == 3 && Experiencia_Personaje > 200) { Nivel_Personaje = 4; PuntosHabilidad++; PuntosPersonalidad++; LevelUpState = 1; }
        if (Nivel_Personaje == 4 && Experiencia_Personaje > 400) { Nivel_Personaje = 5; PuntosHabilidad++; PuntosPersonalidad++; LevelUpState = 1; }
        ///////////////////////////////////////////////
    }
    public int getNivel() { return Nivel_Personaje; }
    public void setNivel(int aa) { Nivel_Personaje = aa; }
    public int getLevelUpState() { return LevelUpState; }
    public void setLevelUpState(int lus) { LevelUpState = lus; }

    public int getSuerte() { return Suerte_Personaje; }
    public void setSuerte(int su) { Suerte_Personaje = su; }
    public int getInteligencia() { return Inteligencia_Personaje; }
    public void setInteligencia(int inteli) { Inteligencia_Personaje = inteli; }
    public int getCarisma() { return Carisma_Personaje; }
    public void setCarisma(int ca) { Carisma_Personaje = ca; }

    public float getPromedioPersonaje() { return Promedio_Personaje; }
    public void setPromedioPersonaje(float prom) { 
        Promedio_Personaje = prom;
        if (Promedio_Personaje < 0) { Promedio_Personaje = 0; }
        if (Promedio_Personaje > 5) { Promedio_Personaje = 5; }
    }

    public int getCriterioProfesor() { return Criterio_Profesor; }
    public void setCriterioProfesor(int criterio) 
    {
        Criterio_Profesor = criterio;
        if (Criterio_Profesor < -2) { Criterio_Profesor = -2; }
        if (Criterio_Profesor > 2) { Criterio_Profesor = 2; }
    }
    public int getFavorJefe() { return Favor_Jefe; }
    public void setFavorJefe(int favor)
    {
        Favor_Jefe = favor;
        if (Favor_Jefe < -2) { Favor_Jefe = -2; }
        if (Favor_Jefe > 2) { Favor_Jefe = 2; }
    }

    public int getEstadoJugador() { 
    
        return Estado_Jugador;
    }
    public void setEstadoJugador(int est)
    {
        Estado_Jugador = est;
                
    }


    public int getPuntosPersonalidad() { return PuntosPersonalidad; }
    public void setPuntosPersonalidad(int pp) { PuntosPersonalidad = pp; }

    public int getPuntosHabilidad() { return PuntosHabilidad; }
    public void setPuntosHabilidad(int ph) { PuntosHabilidad = ph; }
    
    public void CambiarDatosPersonaje(string nombre_Personaje, int energia_Personaje, int felicidad_Personaje, int conocimiento_Personaje, int dinero_Personaje, int comida_Personaje, int experiencia_Personaje)
    {
        Nombre_Personaje = nombre_Personaje;
        Energia_Personaje = Energia_Personaje + energia_Personaje;
        Felicidad_Personaje = Felicidad_Personaje +felicidad_Personaje;
        Conocimiento_Personaje = Conocimiento_Personaje + conocimiento_Personaje;
        Dinero_Personaje = Dinero_Personaje + dinero_Personaje;
        Comida_Personaje = Comida_Personaje + comida_Personaje;
        ////////////////nivel del personaje//////////////
        Experiencia_Personaje = Experiencia_Personaje + experiencia_Personaje;
        //if (Nivel_Personaje == 1 && Experiencia_Personaje > 51 ) { Nivel_Personaje = 2; LevelUpState = 1; }
       // if (Nivel_Personaje == 2 && Experiencia_Personaje > 100) { Nivel_Personaje = 3; LevelUpState = 1; }
       // if (Nivel_Personaje == 3 && Experiencia_Personaje > 200) { Nivel_Personaje = 4; LevelUpState = 1; }
        //if (Nivel_Personaje == 4 && Experiencia_Personaje > 400) { Nivel_Personaje = 5; LevelUpState = 1; }
        ///////////////////////////////////////////////

        if (Energia_Personaje < 0) Energia_Personaje  = 0;
        if (Energia_Personaje > 100) Energia_Personaje  = 100;
        if (Felicidad_Personaje < 0) Felicidad_Personaje = 0;
        if (Felicidad_Personaje > 10) Felicidad_Personaje = 10;
        if (Conocimiento_Personaje < 0) Conocimiento_Personaje = 0;
        if (Conocimiento_Personaje > 10) Conocimiento_Personaje = 10;
        if (Dinero_Personaje < 0) Dinero_Personaje = 0;
        
    }







}
