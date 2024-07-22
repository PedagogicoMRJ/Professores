using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    // Texto escrito "Ball"
    [Header("Ball")]

    // Classe que acessa a entidade objeto Ball da Unity
    public GameObject Ball;

    // texto escrito "Player Left"
    [Header("Player Left")]

    // Classe que acessa a entidade objeto LeftPlayer da Unity
    public GameObject LeftPlayer;
    // Classe que acessa a entidade objeto LeftGoal da Unity
    public GameObject PlayerLeftGoal;

    //Texto escrito "Player Right"
    [Header("Player Right")]
    // Classe que acessa a entidade objeto RightPlayer da Unity
    public GameObject RightPlayer;
    // Classe que acessa a entidade objeto RightGoal da Unity
    public GameObject PlayerRightGoal;

    //Texto escrito "Score UI"
    [Header("Score UI")]
    // Classe que acessa a entidade objeto PlayerLeftScore da Unity
    public GameObject PlayerLeftText;
    // Classe que acessa a entidade objeto PlayerRightScore da Unity
    public GameObject PlayerRightText;

    //Variável que armazena a pontuação do jogador a esquerda
    private int PlayerLeftScore;

    //Variável que armazena a pontuação do jogador a direita
    private int PlayerRightScore;

    //A função PlyerLeftScore registra que o jogador a esquerda pontuou
    public void PlayerLeftScored()
    {   
        //aumenta o valor contido na variável PlayerLeftScore
        PlayerLeftScore++;
        //Atribui ao texto do objeto TMP PlayerLeftScore o valor da variável PlayerLeftScore
        PlayerLeftText.GetComponent<TextMeshProUGUI>().text = PlayerLeftScore.ToString();
        //Chama a função ResetPosition
        ResetPosition();

    }
    public void PlayerRightScored()
    {
        //aumenta o valor contido na variável PlayerRightScore
        PlayerRightScore++;
        //Atribui ao texto do objeto TMP PlayerRightScore o valor da variável PlayerRightScore
        PlayerRightText.GetComponent<TextMeshProUGUI>().text = PlayerRightScore.ToString();
        ResetPosition();

    }

    public void ResetPosition()
    {
        //chama a função Reset do script Ball do component Ball
        Ball.GetComponent<Ball>().Reset();
        //Chama a função Reset do script Racket do componente LeftPlayer
        LeftPlayer.GetComponent<Racket>().Reset();
        //Chama a função Reset do script Racket do componente RightPlayer
        RightPlayer.GetComponent<Racket>().Reset();
    }
}
