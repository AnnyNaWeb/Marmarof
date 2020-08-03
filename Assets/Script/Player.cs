using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    Vector3 move;
    void Start()
    {
        
    }

    void MovePlayer(){
        move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position = transform.position + move*Time.deltaTime*speed;
    }

    void Atirar(){
        if(Input.GetKeyDown("space")){
            Debug.Log("Entrei Otária");
            GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
            if (bullet != null){
                bullet.transform.position = transform.position;
                bullet.transform.rotation = transform.rotation;
                bullet.SetActive(true);
            }
        }
    }


    void Update()
    {
        MovePlayer();
        Atirar();
    }
}
