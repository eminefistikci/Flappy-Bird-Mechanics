using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ColumnCreator : MonoBehaviour
{
    public GameObject columnPrefab;

    public float period;

    private float counter;
    void Update()
    {
        counter+=Time.deltaTime;

        if(counter >= period)
        {

            GameObject newColumn = CreateNewColumn();
            counter = 0;
        }
    }

    GameObject CreateNewColumn()
    {
        GameObject column = Instantiate(columnPrefab);
        column.transform.position = new Vector3 (3f,Random.Range(1.4f, -0.4f),0f);
        return column;
    }

}
