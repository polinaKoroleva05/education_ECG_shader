using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateScript : MonoBehaviour
{
    public float speeds;
    public Quaternion startQuaternion;
    // Start is called before the first frame update
    void Start()
    {
        speeds = 0.4f;
        startQuaternion = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.isPressed){
            Vector3 mousePos = Mouse.current.position.ReadValue();
            float screenWidth =  Screen.width;
            Debug.Log(screenWidth);
            screenWidth = screenWidth > 0 ? screenWidth : 3000;
            float normalX = (mousePos.x /screenWidth) * 2 - 1;

            if(normalX > -0.26f){
                float X = Mouse.current.delta.ReadValue().x * speeds;// * Time.deltaTime;
                float Y = Mouse.current.delta.ReadValue().y * speeds;// * Time.deltaTime;
            
                transform.Rotate(Vector3.down, X, Space.World); //проверено
                transform.Rotate(Vector3.left, Y,  Space.World);
            }
        }
        if(Mouse.current.rightButton.isPressed){
            transform.rotation = startQuaternion;
        }
    }
}
