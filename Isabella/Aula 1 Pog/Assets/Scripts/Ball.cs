using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Vari�vel que armazena a velocidade da bola 
    public float speed;

    //Vari�vel que acessa o component Rigidbody 2D da bola
    public Rigidbody2D rb;

    //Vetor que armazena a posi��o inicial x,y,z das plataformas dos jogadores
    public Vector3 startPosition;

    //A fun��o Start � chamada antes do primeiro frame do jogo
    void Start()
    {
        Launch();

        startPosition = transform.position;
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

    public void Reset()
    {
        //Atribui � velocidade do componente Rigidbody o vetor x=0, y=0
        rb.velocity = Vector3.zero;
        //Atribui os valores armazenados na v�riavel starPosition a posi��o atual das plataformas
        transform.position = startPosition;
        Launch();

    }
}
