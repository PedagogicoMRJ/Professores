using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Var�vel que recebe a pontua��o do jogador
        public int score;
    //Var�vel que recebe a pontua��o do jogador
        public Text scoretext;

    // Fun��o que recome�a o jogo 
    public void Restart()
    {
        //Carrega a cena 0 do jogo
        SceneManager.LoadScene(0);
        //Ativa o jogo
        Time.timeScale = 1;
        
    }

}
