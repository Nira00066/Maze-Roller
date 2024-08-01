using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float Rotationspeed;
    public GameObject OncollectEffect;
    public GameObject WinText;

    // Start is called before the first frame update
    void Start()
    {
        // Assurez-vous que le WinText est désactivé au démarrage
        if (WinText != null)
        {
            WinText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Rotationspeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(OncollectEffect, transform.position, transform.rotation);

            // Affichez le WinText lorsque le joueur collecte l'objet
            if (WinText != null)
            {
                WinText.SetActive(true);
            }
        }
    }
}
