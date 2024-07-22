using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Variável que armazena a velocidade da bola 
    public float speed;

    //Variável que acessa o component Rigidbody 2D da bola
    public Rigidbody2D rb;

    //Vetor que armazena a posição inicial x,y,z das plataformas dos jogadores
    public Vector3 startPosition;

    //A função Start é chamada antes do primeiro frame do jogo
    void Start()
    {
        Launch();

        startPosition = transform.position;
    }
    //Função "Launch gera o movimento da bola"
    private void Launch()
    {
        //Atribui um valor aleatório de -1 ou 1 a variável x
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        //Atribui um valor aleatório de -1 ou 1 a variável y
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        //Atribui a velocidade do component Rigidbody um novo vetor x, y
        rb.velocity = new Vector2(speed * x, speed * y);

    }

    public void Reset()
    {
        //Atribui á velocidade do componente Rigidbody o vetor x=0, y=0
        rb.velocity = Vector3.zero;
        //Atribui os valores armazenados na váriavel starPosition a posição atual das plataformas
        transform.position = startPosition;
        Launch();

    }
}
