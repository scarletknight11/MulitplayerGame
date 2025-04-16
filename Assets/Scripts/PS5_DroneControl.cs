using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PS5_DroneControl : MonoBehaviour
{

    public GameObject Drone;
    Rigidbody ourDrone;
    public float UpForce;

    void Awake()
    {
        ourDrone = GetComponent<Rigidbody>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }
        Drone = GameObject.Find("drone blue");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].leftStick.left.isPressed)
            {
                Drone.transform.position += Vector3.left * Time.deltaTime * 5f;
            }

            if (Gamepad.all[0].leftStick.right.isPressed)
            {
                Drone.transform.position += Vector3.right * Time.deltaTime * 5f;
            }

            if (Gamepad.all[0].leftStick.up.isPressed)
            {
                Drone.transform.position += Vector3.forward * Time.deltaTime * 5f;
            }

            if (Gamepad.all[0].leftStick.down.isPressed)
            {
                Drone.transform.position += Vector3.back * Time.deltaTime * 5f;
            }
        }
        MovementUpDown();
        MovementForward();
        ourDrone.AddRelativeForce(Vector3.up * UpForce);
    }

    void MovementUpDown()
    {
        if(Gamepad.all[0].rightStick.up.isPressed)
        {
            UpForce = 450f;
        }
        else if (Gamepad.all[0].rightStick.down.isPressed)
        {
            UpForce = -200f;
        }
        else if (!Gamepad.all[0].rightStick.up.isPressed && !Gamepad.all[0].rightStick.down.isPressed)
        {
            UpForce = 56;
        }
    }

    void MovementForward()
    {

    }
}
