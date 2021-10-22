using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Domino : MonoBehaviour
{
    [ExecuteInEditMode]
    void Start()
    {
        GameObject go = transform.GetChild(0).gameObject;

        for(int i=0;i<10;i++)
        {
            GameObject goob = Instantiate(go, transform.position, transform.rotation);
            goob.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z + ((i + 1) * 0.04f));
        }
    }
}
