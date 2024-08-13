using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
    //variavel que armazena a velocidade dos canos
    public float speed;

    
    // Update is called once per frame
    void Update()
    {
        //Modifica a posição do objeto mandando-o para esquerda de acordo com a velocidade da variável speed
        // se tirar o "+" diminui os pipes
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
