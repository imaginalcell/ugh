using UnityEngine;
using System.Collections;

public class FireSpell : MonoBehaviour {

    Rigidbody rb;

    GameObject prefab;

    float spawnDistance = 0.8f;
  
    float speed = 20.0f;

    
    // Use this for initialization
    void Start () {
        prefab = Resources.Load("Spell") as GameObject;
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(1))
        {
            firespell();
        }
    }

    void firespell()
    {
        GameObject fireball = GameObject.Instantiate(prefab, transform.position + spawnDistance
                                  * transform.forward, transform.rotation) as GameObject;

        Rigidbody fireRigidbody = fireball.GetComponent<Rigidbody>();

        fireRigidbody.AddForce((transform.forward * speed), ForceMode.Impulse);
    }

}