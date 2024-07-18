using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    //variável boolena (recebe apenas um valor que pode ser verdadeiro ou falsa) para identificar o jogador e esquerda  
    public bool isPlayerLeft;

    //variável que armazena o valor da velocidade das plataformas dos jogadores
    public float speed;

    //variável que acessa o componente Rigidbody 2D das plataformas
    public Rigidbody2D rb;

    //variável que armazena o valor referente aos movimentos das plataformas
    private float movement;

    // OBS: variáveis publicadas  podem ter seus valores alterados

    // A função Update é chamada a cada atualização de um frame - VER O QUE É "FRAME"

    void Update()
    {
        //Verifica se a variável booleana isPlayerLeft é verdadeira
        if (isPlayerLeft)
        //Caso a variável seja verdadeira 
        {
            //Armazena o valor da entrada Vertical1 na variável movement
            movement = Input.GetAxisRaw("Vertical1");

        }
        //Caso a variável seja falsa
        else
        {
            //Armazena o valor da entrada Vertical1 na variável movement
            movement = Input.GetAxisRaw("Vertical2");

        }
        //Atribui a velocidade do component Rigidbody um novo vetor x, y - PESQUISAR DEPOIS O QUE É O "Rigidbody"
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

}

