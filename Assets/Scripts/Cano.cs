using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour
{
    public float velocidade;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;
    }
}
