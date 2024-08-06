using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Varável que recebe a pontuação do jogador
        public int score;
    //Varável que recebe a pontuação do jogador
        public Text scoretext;

    // Função que recomeça o jogo 
    public void Restart()
    {
        //Carrega a cena 0 do jogo
        SceneManager.LoadScene(0);
        //Ativa o jogo
        Time.timeScale = 1;
        
    }

}
