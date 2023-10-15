using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int speed = 1;
    public int time = 0;
    float move;
    Vector3 direct=Vector3.zero;
    
    private void Update()
    {
        if(Time.time-move >=time)
        {
            if(Input.GetKey(KeyCode.Q)&& direct!= new Vector3(1,-1,0))
            {
                MoveDiagonalLeftUp();
            }
            else if (Input.GetKey(KeyCode.E) && direct != new Vector3(-1, -1, 0))
            {
                MoveDiagonalRightUp();
            }
            else if (Input.GetKey(KeyCode.A) && direct != new Vector3(1, 1, 0))
            {
                MoveDiagonalLeftDown();
            }
            else if(Input.GetKey(KeyCode.D) && direct != new Vector3(-1, 1, 0))
            {
                MoveDiagonalRightDown();
            }
        }

    }

    void MoveDiagonalLeftUp()
    {
        Vector3 newPos = transform.position + new Vector3(-1, 1, 0);

        direct = new Vector3(-1, 1, 0);

        transform.position = newPos;

        move = Time.time;

    }

    void MoveDiagonalLeftDown()
    {
        Vector3 newPos = transform.position + new Vector3(-1, -1, 0);

        direct =new Vector3(-1, -1, 0);

        transform.position = newPos;

        move = Time.time;

    }

    void MoveDiagonalRightUp()
    {
        Vector3 newPos = transform.position + new Vector3(1, 1, 0);
        direct = new Vector3(1, 1, 0);

        transform.position = newPos;

        move = Time.time;
    }

    void MoveDiagonalRightDown()
    {
        Vector3 newPos = transform.position + new Vector3(1, -1, 0);
        direct = new Vector3(1, -1, 0);

        transform.position = newPos;

        move = Time.time;
    }
}
