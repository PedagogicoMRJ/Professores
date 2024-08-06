using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //Vari�vel que armazena a velocidade do passaro
    public float speed = 1f;
    //Vari�vel que acessa o componente Rigidbody 2D do objeto FlappyBird
    private Rigidbody2D rig;
    //Classe associada ao objeto Canvas da Unity
    public GameObject gameover;
    void Start()
    {
        //Atribui o componente Rigidbody 2D a vari�vel rig
        rig = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        //Verifica se o bot�o do mouse foi pressionado
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
