using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //Variável que armazena a velocidade do passaro
    public float speed = 1f;
    //Variável que acessa o componente Rigidbody 2D do objeto FlappyBird
    private Rigidbody2D rig;
    //Classe associada ao objeto Canvas da Unity
    public GameObject gameover;
    void Start()
    {
        //Atribui o componente Rigidbody 2D a variável rig
        rig = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        //Verifica se o botão do mouse foi pressionado
        if (Input.GetMouseButtonDown(0))
        {
            //Atribui o valor do eixo y de um vetor a velocidade do Rigidbody
            rig.velocity = Vector2.up * speed;
        }

    }

    private void OnCollisionEnter2d(Collision2D collision)
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
}
