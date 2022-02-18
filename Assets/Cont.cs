using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Analog [0,32767]

public class Cont : MonoBehaviour
{
    //int count = 0;
    GCController cont;
    // Start is called before the first frame update
    void Start()
    {
        cont = new GCController();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Horizontal") > 0)
        //{
        //ç∂Ç…åXÇ¢ÇƒÇ¢ÇÈ
        //Debug.Log(Input.GetAxis("CStick_X").ToString());
        //float ax = Input.GetAxis("Analog_X");
        //uint ajx = ConvertAxisToUint(ax);
        //Debug.Log("Raw "+ax+" ADJ : "+ajx);
        //Debug.Log(Input.GetAxis("L_Trigger").ToString());
        //}

        this.getInput();
    }

    uint ConvertAxisToUint(float ax)
    {
        const int adjust = 32767 / 2;
        return (uint)( (ax+1.0f) * adjust);
    }

    public void getInput()
    {
        if (Input.GetButton("A"))
        {
            cont.buttons |= (int)GCController.ButtonBit.A;
            Debug.Log("A");
        }
        if (Input.GetButton("B"))
        {
            cont.buttons |= (int)GCController.ButtonBit.B;
        }
        if (Input.GetButton("X"))
        {
            cont.buttons |= (int)GCController.ButtonBit.X;
        }
        if (Input.GetButton("Y"))
        {
            cont.buttons |= (int)GCController.ButtonBit.Y;
        }
        if (Input.GetButton("Start"))
        {
            cont.buttons |= (int)GCController.ButtonBit.START;
        }
        if (Input.GetButton("Z"))
        {
            cont.buttons |= (int)GCController.ButtonBit.Z;
        }
        if (Input.GetButton("L"))
        {
            cont.buttons |= (int)GCController.ButtonBit.L;
        }
        if (Input.GetButton("R"))
        {
            cont.buttons |= (int)GCController.ButtonBit.R;
        }
        cont.analogStickX = ConvertAxisToUint(Input.GetAxis("Analog_X"));
        cont.analogStickY = ConvertAxisToUint(Input.GetAxis("Analog_Y"));
        cont.CStickX = ConvertAxisToUint(Input.GetAxis("CStick_X"));
        cont.CStickY = ConvertAxisToUint(Input.GetAxis("CStick_Y"));

         Debug.Log(cont.CStickX + " : " + Input.GetAxis("CStick_X"));
        //Debug.Log(Input.GetAxis("CStick_X"));
     
    }

}
