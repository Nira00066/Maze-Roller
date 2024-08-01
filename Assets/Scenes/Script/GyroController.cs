using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GyroController : MonoBehaviour
{
    // [SerializeField] GameObject Ball;

    // [SerializeField] GameObject Ground;

    private Collider rbBall;

[SerializeField] GameObject obstacle;

[SerializeField] GameObject game;
    private Collider Rbcube;

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
        if (collision.gameObject.CompareTag("Block"))
        {
            Debug.Log("Game Over");
         
        }
    }

}
