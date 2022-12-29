using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 3f;


    // Update is called once per frame
    void Update()
    {
        //假设我们定义 float speed =10;即此处每帧最大的位移为1*10*0.0167=0.167米。
        float horizontal = Input.GetAxis("Horizontal");
        float vetical = Input.GetAxis("Vertical");
        transform.Translate(horizontal * Time.deltaTime * speed, 0,vetical * Time.deltaTime * speed);
    }
}