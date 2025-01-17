using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform _transform;
    public float velocidade = 10f;
    void Start()
    {
        _transform = gameObject.transform;
        _rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("chao")) //if (other.tag == chao)
        {
            noChao = false
        }
    }



    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position -= new Vector3(x:velocidade*Time.deltaTime,y:0,z:0);
            Debug.Log(message:"LeftArrow");
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            _transform.position += new Vector3(x:velocidade*Time.deltaTime,y:0,z:0);
            Debug.Log(message:"RightArrow");
        }
    }
}

