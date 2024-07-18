using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Vari�vel que armazena a velocidade da bola 
    public float speed;

    //Vari�vel que acessa o component Rigidbody 2D da bola
    public Rigidbody2D rb;

    //A fun��o Start � chamada antes do primeiro frame do jogo
    void Start()
    {
        Launch();
    }
    //Fun��o "Launch gera o movimento da bola"
    private void Launch()
    {
        //Atribui um valor aleat�rio de -1 ou 1 a vari�vel x
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        //Atribui um valor aleat�rio de -1 ou 1 a vari�vel y
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        //Atribui a velocidade do component Rigidbody um novo vetor x, y
        rb.velocity = new Vector2(speed * x, speed * y);

    }
}
