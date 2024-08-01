using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ResTouch : MonoBehaviour
{
    // [SerializeField] GameObject Ball;

    // [SerializeField] GameObject Ground;

    private Collider rbBall;

    private Collider RbBlock;

    private Rigidbody ball;
    private Vector3 initialPosition;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        // Je vais chercher le Rigidbody de l'objet qui instancie la classe 
        ball = GetComponent<Rigidbody>();
        initialPosition = ball.position;

    // ajouter une condition s'il n'y a pas de Rigidbody pour afficher un message d'erreur  + ne pas appeler initialPosition


    }

    // Update is called once per frame
    void Update()
    {
        //When my ball it collistion with gameobject 
    }

   void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Background"))
        {
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
