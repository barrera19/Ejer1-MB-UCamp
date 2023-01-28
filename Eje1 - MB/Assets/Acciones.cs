using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acciones : MonoBehaviour
{
    public TextMeshProUGUI posibles, opreacion, resultado, rrto;
    public TMP_InputField entrada1, entrada2;
    public int puntos = 0;
    public GameObject[] botones;

    private void Start()
    {
        posibles.text = "1, 8, 5, 3";
        opreacion.text = "+";
        resultado.text = "11";
    }

    public void Pregunta1() {

        if(entrada1.text == "8" && entrada2.text == "3")
        {
            puntos++;
        }
        else if (entrada1.text == "3" && entrada2.text == "8")
        {
            puntos++;
        }
        botones[0].SetActive(false);
        botones[1].SetActive(true);

        //Inicializar la Pregunta 2
        posibles.text = "9, 6, 3, 5";
        opreacion.text = "-";
        resultado.text = "6";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta2()
    {

        if (entrada1.text == "9" && entrada2.text == "3")
        {
            puntos++;
        }

        botones[1].SetActive(false);
        botones[2].SetActive(true);

        //Inicializar la Pregunta 3
        posibles.text = "1, 5, 9, 2";
        opreacion.text = "+";
        resultado.text = "3";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta3()
    {

        if (entrada1.text == "1" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "1")
        {
            puntos++;
        }
        botones[2].SetActive(false);
        botones[3].SetActive(true);

        //Inicializar la Pregunta 4
        posibles.text = "8, 5, 2, 4";
        opreacion.text = "-";
        resultado.text = "6";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta4()
    {

        if (entrada1.text == "8" && entrada2.text == "2")
        {
            puntos++;
        }

        botones[3].SetActive(false);
        botones[4].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "2, 8, 4, 3";
        opreacion.text = "+";
        resultado.text = "10";
        entrada1.text = "";
        entrada2.text = "";
    }
  public void Pregunta5()
    {

        if (entrada1.text == "2" && entrada2.text == "8")
        {
            puntos++;
        }
        else if (entrada1.text == "8" && entrada2.text == "2")
        {
            puntos++;
        }

        botones[4].SetActive(false);
        botones[5].SetActive(true);

        //Inicializar la Pregunta 6
        posibles.text = "1, 7, 5, 9";
        opreacion.text = "+";
        resultado.text = "14";
        entrada1.text = "";
        entrada2.text = "";
    }

      public void Pregunta6()
    {

        if (entrada1.text == "5" && entrada2.text == "9")
        {
            puntos++;
        }
        else if (entrada1.text == "9" && entrada2.text == "5")
        {
            puntos++;
        }

        botones[5].SetActive(false);
        botones[6].SetActive(true);

        //Inicializar la Pregunta 7
        posibles.text = "8, 3, 4, 1";
        opreacion.text = "+";
        resultado.text = "5";
        entrada1.text = "";
        entrada2.text = "";
    }

      public void Pregunta7()
    {

        if (entrada1.text == "4" && entrada2.text == "1")
        {
            puntos++;
        }
        else if (entrada1.text == "1" && entrada2.text == "4")
        {
            puntos++;
        }

        botones[6].SetActive(false);
        botones[7].SetActive(true);

        //Inicializar la Pregunta 8
        posibles.text = "10, 21, 9, 15";
        opreacion.text = "+";
        resultado.text = "30";
        entrada1.text = "";
        entrada2.text = "";
    }

      public void Pregunta8()
    {

        if (entrada1.text == "21" && entrada2.text == "9")
        {
            puntos++;
        }
        else if (entrada1.text == "9" && entrada2.text == "21")
        {
            puntos++;
        }

        botones[7].SetActive(false);
        botones[8].SetActive(true);

        //Inicializar la Pregunta 9
        posibles.text = "4, 5, 7, 3";
        opreacion.text = "+";
        resultado.text = "9";
        entrada1.text = "";
        entrada2.text = "";
    }
      public void Pregunta9()
    {

        if (entrada1.text == "4" && entrada2.text == "5")
        {
            puntos++;
        }
        else if (entrada1.text == "5" && entrada2.text == "4")
        {
            puntos++;
        }

        botones[8].SetActive(false);
        botones[9].SetActive(true);

        //Inicializar la Pregunta 10
        posibles.text = "12, 9, 3, 20";
        opreacion.text = "+";
        resultado.text = "29";
        entrada1.text = "";
        entrada2.text = "";
    }
      public void Pregunta10()
    {

        if (entrada1.text == "20" && entrada2.text == "9")
        {
            puntos++;
        }
        else if (entrada1.text == "9" && entrada2.text == "20")
        {
            puntos++;
        }

        botones[9].SetActive(false);
        botones[10].SetActive(true);

      //Esconder entras y etiquetas

    }
   
    //mostrar RRETO
    public void MostrarRetro()
    {
        if (puntos <= 6)
        {
            //RETRO propiedad TEXT pornerle el valor "------"
            rrto.text = "Ups,Esfuérzate un poco más, intenta nuevamente para que obtengas más puntos";
        }
        else if(puntos <= 9)
        {
            rrto.text = "¡Lo has hecho muy bien, pero puedes volverlo a intentar si deseas obtener un puntaje mayor";
        }
        else if(puntos == 10)
        {
            rrto.text = "Wow, no te equivocaste, felicidades, lograste el puntaje máximo posible!";
        }
    }
}
