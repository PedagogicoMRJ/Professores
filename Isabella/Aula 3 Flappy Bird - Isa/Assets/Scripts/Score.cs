using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Classe que acessa o objeto GameManager
        public GameManager manage;
    
    void Start()
    {
        //Associa o objeto GameManager a manage
        manage = FindObjectOfType<GameManager>(); 
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Aumenta o valor da variável score de GameManager
        manage.score++;
        manage.scoretext.text = manage.score.ToString();
        
    }
}
