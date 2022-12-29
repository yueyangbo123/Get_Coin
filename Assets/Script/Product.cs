using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    public GameObject prefab;


    public float midTime;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        if (midTime > 1f)
        {
            GameObject instantiate = GameObject.Instantiate(prefab);
            instantiate.transform.position = new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-3f, 3f));
            midTime = 0;
        }
        else
        {
            midTime += Time.deltaTime;
        }
    }
}