using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acciones : MonoBehaviour
{
    public TextMeshProUGUI posibles, opreacion, resultado;
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

        //Inicializar la Pregunta 3
        posibles.text = "0, 0, 0, 0";
        opreacion.text = "+";
        resultado.text = "0";
        entrada1.text = "";
        entrada2.text = "";
    }
    //5 6 7 8 9 10

    //Esconder entras y etiquetas
    //mostrar RRETO
    public void MostrarRetro()
    {
        if (puntos <= 6)
        {
            //RETRO propiedad TEXT pornerle el valor "------"
        }
        else if(puntos <= 9)
        {

        }
        else if(puntos == 10)
        {

        }
    }
}
