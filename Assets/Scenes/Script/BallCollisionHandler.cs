using UnityEngine;

public class BallCollisionHandler : MonoBehaviour
{
    // Facteur de multiplication pour la force de rebond
    [SerializeField] GameObject ball;
    public float reboundMultiplier = 5.0f;

    // Référence au Rigidbody de la balle
    private Rigidbody rb;

    void Start()
    {
        // Obtenir la référence au Rigidbody attaché à la balle
        rb = GetComponent<Rigidbody>();
    }

    // Méthode appelée lorsque la balle entre en collision avec un autre objet
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifier si la collision est avec un obstacle (vous pouvez adapter le tag selon vos besoins)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Multiplier la vitesse actuelle de la balle par le facteur de rebond
            Vector3 newVelocity = rb.velocity * reboundMultiplier;
            rb.velocity = newVelocity;

            // Facultatif : Appliquer une force en direction opposée pour simuler un rebond plus réaliste
            // Vector3 reboundDirection = Vector3.Reflect(rb.velocity.normalized, collision.contacts[0].normal);
            // rb.velocity = reboundDirection * rb.velocity.magnitude * reboundMultiplier;
        }
    }
}
