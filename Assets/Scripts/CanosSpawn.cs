using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanosSpawn : MonoBehaviour
{
    public GameObject cano;
    public float altura;
    public float timer;
    public float intervalo;    

    // Start is called before the first frame update
    void Start()
    {
        SpawnarCano();
    }

    // Update is called once per frame
    void Update()
    {        
        if(timer > intervalo)
        {
            SpawnarCano();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    void SpawnarCano()
    {
        GameObject novoCano = Instantiate(cano);
        novoCano.transform.position = new Vector2(transform.position.x, Random.Range(-altura, altura));
        Destroy(novoCano, 20f);
    }
}
