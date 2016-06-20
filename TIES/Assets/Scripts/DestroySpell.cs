using UnityEngine;
using System.Collections;

public class DestroySpell : MonoBehaviour {

   
   float lifetime;

	// Use this for initialization
	void Start () {
        lifetime = 2.0f;
	}

    void OnCollisionEnter(Collision col)
    {
        EnemeyTesting enemy = col.collider.GetComponent<EnemeyTesting>();

        if (enemy != null)
        { 
            Destroy(gameObject);
        }

        Barrels barrel = col.collider.GetComponent<Barrels>();

        if(barrel != null)
        {
            Destroy(gameObject);
        }

        Chest chest = col.collider.GetComponent<Chest>();

        if(chest != null)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
        lifetime -= 1.0f * Time.deltaTime;

        if(lifetime <= 0)
        {
            Destroy(gameObject, lifetime);
        }
	}
}
