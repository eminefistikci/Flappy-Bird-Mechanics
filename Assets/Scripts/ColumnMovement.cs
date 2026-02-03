using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColumnMovement : MonoBehaviour
{
    public float columnSpeed;
    public GameManager gameManager;
    void Start()
    {
        gameManager= FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * columnSpeed;

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
        DestroyAllColumn();
    }

    void DestroyAllColumn()
    {
        if (gameManager.isEnded)
        {
            Destroy(gameObject);
        }
    }

}
