using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    //vari�vel boolena (recebe apenas um valor que pode ser verdadeiro ou falsa) para identificar o jogador e esquerda  
    public bool isPlayerLeft;

    //vari�vel que armazena o valor da velocidade das plataformas dos jogadores
    public float speed;

    //vari�vel que acessa o componente Rigidbody 2D das plataformas
    public Rigidbody2D rb;

    //vari�vel que armazena o valor referente aos movimentos das plataformas
    private float movement;

    //Vetor que armazena a posi��o inicial x,y,z das plataformas dos jogadores
    public Vector3 startPosition;

    // OBS: vari�veis publicadas  podem ter seus valores alterados

    //A fun��o Start � chamada antes do primeiro frame do jogo

    void Start()
    {
        startPosition = transform.position;
    }

    //A fun��o Reset reposiciona as plataformas em sua posi��o inicial 
    public void Reset()
    {
      //Atribui � velocidade do componente Rigidbody o vetor x=0, y=0
      rb.velocity = Vector3.zero;
        //Atribui os valores armazenados na v�riavel starPosition a posi��o atual das plataformas
        transform.position = startPosition;
    }


    // A fun��o Update � chamada a cada atualiza��o de um frame - VER O QUE � "FRAME"

    void Update()
    {
        //Verifica se a vari�vel booleana isPlayerLeft � verdadeira
        if (isPlayerLeft)
        //Caso a vari�vel seja verdadeira 
        {
            //Armazena o valor da entrada Vertical1 na vari�vel movement
            movement = Input.GetAxisRaw("Vertical1");

        }
        //Caso a vari�vel seja falsa
        else
        {
            //Armazena o valor da entrada Vertical1 na vari�vel movement
            movement = Input.GetAxisRaw("Vertical2");

        }
        //Atribui a velocidade do component Rigidbody um novo vetor x, y - PESQUISAR DEPOIS O QUE � O "Rigidbody"
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

}

