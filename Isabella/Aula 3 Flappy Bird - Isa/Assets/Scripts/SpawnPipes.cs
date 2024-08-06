using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    //Classe que acessa a entidade Pipes da Unity
    public GameObject pipe;

    //Vari�vel que armazena a altura do objeto Pipes
    public float height;

    //Vari�vel que armazena o tempo m�ximo para um novo objeto do tipo pipe ser criado
    public float maxtime;

    //Vari�vel que armazena o tempo que um objeto permaneceu no jogo
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Crie um novo objeto do tipo pipe
        GameObject newPipe = Instantiate(pipe);
        //Altera a posi��o do novo objeto newPipe para a posi��o do objeto Pipes somado a um novo vetor (0, +/- height, 0)
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Cria um novo objeto quando timer for maior que maxtiome, destroi o objeto depois de 10 segundos e zera o timer
        if (timer > maxtime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            Destroy(newPipe, 10f);
            timer = 0;
        
        }

        timer += Time.deltaTime;

    }
}
