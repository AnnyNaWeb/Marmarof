using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxe : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float speedText;

    void Update(){
        float offset = Time.time * speedText;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
