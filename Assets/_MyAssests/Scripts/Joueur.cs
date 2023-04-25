using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{

    [SerializeField] private float _vitesse = 100.0f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float horizInput = Input.GetAxis("Horizontal");
        float vertiInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizInput, vertiInput, 0f);
        transform.Translate(direction * Time.deltaTime * _vitesse);
        // ajuster la position en y (vertical) en utilisant le math.clamp
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 3.5f), 0f);
        //  ajuster la position en x
        if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0f);
        }
        else if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0f);
        }
    }
}
