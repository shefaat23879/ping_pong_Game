using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed=3;
    public GameObject ball;
    private Vector2 ballPose;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        ballPose=ball.transform.position;
        
        if(transform.position.y>ballPose.y){
            transform.position +=new Vector3(0,-speed*Time.deltaTime);
        }

        if(transform.position.y<ballPose.y){
            transform.position +=new Vector3(0,speed*Time.deltaTime);
        }
    }
}
