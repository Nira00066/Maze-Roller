using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportemantball : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private Rigidbody RgbBall;
    private Gyroscope m_Gyro;

    void Start()
    {
        RgbBall = GetComponent<Rigidbody>();

        // Set up and enable the gyroscope (check your device has one)
        if (SystemInfo.supportsGyroscope)
        {
            m_Gyro = Input.gyro;
            m_Gyro.enabled = true;
        }
        else
        {
            Debug.LogError("Gyroscope non supporté sur cet appareil.");
        }
    }

    void OnGUI()
    {
        // Output the rotation rate, attitude and the enabled state of the gyroscope as a Label
        GUI.Label(new Rect(500, 300, 300, 20), "Gyro rotation rate: " + m_Gyro.rotationRate);
        GUI.Label(new Rect(500, 350, 300, 20), "Gyro attitude: " + m_Gyro.attitude);
        GUI.Label(new Rect(500, 400, 300, 20), "Gyro enabled: " + m_Gyro.enabled);
    }

    void Update()
    {
        // Debug to check if the gyroscope is accessed
        if (Input.gyro.enabled)
        {
            // Lire les données du gyroscope
            Vector3 gyroRotation = Input.gyro.rotationRateUnbiased;

            // Appliquer une force à la balle en fonction du gyroscope
            Vector3 force = new Vector3(gyroRotation.x, 0, gyroRotation.y) * 500;
            RgbBall.AddForce(force * Time.deltaTime);

            // Debug to see the force being applied
            Debug.Log("Gyro rotation rate: " + gyroRotation);
            Debug.Log("Force applied: " + force);
        }
    }
}

//voir si c'est bon 