using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float speed;
    private Material mat;
    void Start()
    {
        mat=GetComponent<Renderer>().material;
    }

    void Update()
    {
        float offsetX = Time.time * speed;
        Vector2 textureOffset = new Vector2(offsetX, 0);
        mat.mainTextureOffset = textureOffset;
    }
}
