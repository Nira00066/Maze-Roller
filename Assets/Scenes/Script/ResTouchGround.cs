using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResTouchGround : MonoBehaviour
{
    [SerializeField] GameObject Ball;

    [SerializeField] GameObject Ground;

    private Rigidbody rbBall;

    private Rigidbody RbGround;

    private bool hasTouch = false;

    private Vector3 initialPosition;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        initialPosition = rbBall.position;


    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other ){
        if (other.gameObject.CompareTag("Background")){
            Debug.Log("Game Over");
              Respawn();
        }
    }
    void Respawn()
    {
        // Réinitialiser la position et la vitesse de la balle
        rbBall.position = initialPosition;
        rbBall.velocity = Vector3.zero;
        rbBall.angularVelocity = Vector3.zero;
    }
}
