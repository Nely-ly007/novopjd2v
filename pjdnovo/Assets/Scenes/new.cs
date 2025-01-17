using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;
    public float velocidade = 1.0f
    void Start()
    {
        _transform = gameObject.transform;
    }

    void Update()
    {
        if(input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position=
            Debug.Log("LeftArrow");
        }

        if(input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow");
        }
    }
}
