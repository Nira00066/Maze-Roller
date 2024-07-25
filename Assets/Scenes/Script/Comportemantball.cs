using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportemantball : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private Rigidbody RgbBall;
       Gyroscope m_Gyro;

    void Start()
    {
        RgbBall = GetComponent<Rigidbody>();

        //Set up and enable the gyroscope (check your device has one)
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }

//This is a legacy function, check out the UI section for other ways to create your UI
    void OnGUI()
    {
        //Output the rotation rate, attitude and the enabled state of the gyroscope as a Label
        GUI.Label(new Rect(500, 300, 200, 0), "Gyro rotation rate " + m_Gyro.rotationRate);
        GUI.Label(new Rect(500, 350, 200, 0), "Gyro attitude" + m_Gyro.attitude);
        GUI.Label(new Rect(500, 400, 200, 0), "Gyro enabled : " + m_Gyro.enabled);
    }

    void Update()
    {
// debugger pour voir si on accède au gyroscope 

        if (Input.gyro.enabled)
        {
            // Lire les données du gyroscope
            Vector3 gyroRotation = Input.gyro.rotationRateUnbiased;

            // Appliquer une force à la balle en fonction du gyroscope
            RgbBall.AddForce(new Vector3(gyroRotation.x, 0, gyroRotation.y) * Time.deltaTime * 500);
        }


    }
}
//voir si c'est bon 