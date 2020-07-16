using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    public int pontos = 0;
    public GameObject texto;
    public AudioSource novoPonto;

    private void Start() 
    {
        texto       = GameObject.Find("Pontos"); 
        novoPonto   = GameObject.Find("Point").GetComponent<AudioSource>();
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        novoPonto.Play();

        pontos = Int32.Parse(texto.GetComponent<Text>().text);
        pontos++;
        texto.GetComponent<Text>().text = pontos.ToString();
    }
}
