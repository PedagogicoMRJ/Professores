using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Variável boolena para identificar o gol do jogador a esquerda
    public bool isPlayerLeftGoal;

    //A função OnTriggerEnter2D é chamada ao detectar uma colisão entre objetos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //verificar se o objeto que colidiu possui a tag Ball
         if(collision.gameObject.CompareTag("Ball"))
         //Caso a condição seja verdadeira
         {
            //Verifica se a variável boolena inPlayerLeftGoal NÃO é verdadeira
            if (!isPlayerLeftGoal)
            //Caso a condição seja verdadeira
            {
                //Exibe a mensagem "Player Left Scored" na área de debugs
                Debug.Log("Player Left Scored");
                //Chama a função PlayerLeftScored do script GameManger do objeto GameManger
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerLeftScored();

            }
            //Caso a condição seja falsa
            else
            {
                //Exibe a mensagem "Player Left Scored" na área de debugs
                Debug.Log("Player Right Scored");
                //Chama a função PlayerLeftScored do Script GameManager do objeto GameManager
                GameObject.Find("GameManager").GetComponent<GameManager>().PlayerRightScored();
            }
         }

    }
}
