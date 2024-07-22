using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Vari�vel boolena para identificar o gol do jogador a esquerda
    public bool isPlayerLeftGoal;

    //A fun��o OnTriggerEnter2D � chamada ao detectar uma colis�o entre objetos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //verificar se o objeto que colidiu possui a tag Ball
         if(collision.gameObject.CompareTag("Ball"))
         //Caso a condi��o seja verdadeira
         {
            //Verifica se a vari�vel boolena inPlayerLeftGoal N�O � verdadeira
            if (!isPlayerLeftGoal)
            //Caso a condi��o seja verdadeira
            {
                //Exibe a mensagem "Player Left Scored" na �rea de debugs
                Debug.Log("Player Left Scored");
                //Chama a fun��o PlayerLeftScored do script GameManger do objeto GameManger
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLeftScored();

            }
            //Caso a condi��o seja falsa
            else
            {
                //Exibe a mensagem "Player Left Scored" na �rea de debugs
                Debug.Log("Player Right Scored");
                //Chama a fun��o PlayerLeftScored do Script GameManager do objeto GameManager
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerRightScored();
            }
         }

    }
}
