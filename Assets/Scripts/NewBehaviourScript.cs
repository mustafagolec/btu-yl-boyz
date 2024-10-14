using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Timer = 0;
    private float speed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(0, 1, 0);
                transform.Translate(movement);
                Timer = 0;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(0, -1, 0);
                transform.Translate(movement);
                Timer = 0;
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(0, 0, 1);
                transform.Translate(movement);
                Timer = 0;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(-1, 0, 0);
                transform.Translate(movement);
                Timer = 0;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(0, 0, -1);
                transform.Translate(movement);
                Timer = 0;
            }
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Timer += Time.deltaTime;
            if (Timer > 0.1f)
            {
                Vector3 movement = new Vector3(1, 0, 0);
                transform.Translate(movement);
                Timer = 0;
            }
        }

        else{
            Timer = 0;
        }

    }
}
