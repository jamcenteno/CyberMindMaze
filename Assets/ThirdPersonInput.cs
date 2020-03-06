using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{
    public FixedJoystick LeftJoystick;
    public FixedButton Button;
    protected ThirdPersonUserControl Control;
    public FixedTouchField TouchField;

    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;
    //Start is called before the first frame update
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();

    }

    // Update is called once per frame 
    void Update()
    {
        Control.m_Jump = Button.Pressed;
        Control.Hinput = LeftJoystick.Direction.x;
        Control.Vinput = LeftJoystick.Direction.y;

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;
       

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(-0.8f, 2.7f, -2f);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

        
    }
}
