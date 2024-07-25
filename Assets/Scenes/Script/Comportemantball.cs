using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comportemantball : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private Rigidbody RgbBall;
    private Gyroscope m_Gyro;
    private Vector3 gyroRotation;

    void Start()
    {
        RgbBall = ball.GetComponent<Rigidbody>();

        // Set up and enable the gyroscope (check your device has one)
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;

        if (m_Gyro.enabled)
        {
            Debug.Log("Gyroscope enabled successfully.");
        }
        else
        {
            Debug.LogError("Gyroscope could not be enabled.");
        }
    }

    void Update()
    {
        // Debug to see if we are accessing the gyroscope 
        if (m_Gyro.enabled)
        {
            // Read gyroscope data
            gyroRotation = m_Gyro.rotationRateUnbiased;
            Debug.Log($"Gyro Rotation: {gyroRotation}");
        }
    }

    void FixedUpdate()
    {
        if (m_Gyro.enabled)
        {
            // Apply force to the ball based on the gyroscope
            Vector3 force = new Vector3(gyroRotation.x, 0, gyroRotation.y) * 500;
            RgbBall.AddForce(force);
            Debug.Log($"Applied force: {force}");
        }
    }
}
