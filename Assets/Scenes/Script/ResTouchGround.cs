using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ResTouchGround : MonoBehaviour
{
    [SerializeField] GameObject Ball;

    [SerializeField] GameObject Ground;

    private Collider rbBall;

    private Collider RbGround;

    private Rigidbody ball;
    private Vector3 initialPosition;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;

        initialPosition = ball.position;


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
        ball.position = initialPosition;
        ball.velocity = Vector3.zero;
        ball.angularVelocity = Vector3.zero;
    }
}
