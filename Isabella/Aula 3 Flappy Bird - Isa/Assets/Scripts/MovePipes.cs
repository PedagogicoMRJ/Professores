using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipes : MonoBehaviour
{
<<<<<<< HEAD
    // Variável que armazena a velocidade dos canos
    public float speed;

   
=======
    //variavel que armazena a velocidade dos canos
    public float speed;

    
>>>>>>> 823974e227cb8e004b1f6757fbec38634f2304a8
    // Update is called once per frame
    void Update()
    {
        //Modifica a posição do objeto mandando-o para esquerda de acordo com a velocidade da variável speed
<<<<<<< HEAD
=======
        // se tirar o "+" diminui os pipes
>>>>>>> 823974e227cb8e004b1f6757fbec38634f2304a8
        transform.position += Vector3.left * speed * Time.deltaTime;
        
    }
}
