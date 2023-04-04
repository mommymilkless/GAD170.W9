using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 
    void OnCollisionEnter(Collision collision)
    {
        if(gameObject.GetComponent<CubeHatred>().cubeHateLevel>20)
        {
            // Destroys every object it touches on collision
            Destroy(gameObject);
            Debug.Log("The fabric of reality is being torn");
        }
        else
        {
            // Destroys itself on collision
            Destroy(collision.gameObject);
            Debug.Log("Bye-bye friend... *sobs*");
        }
        
        // Just turns the object off
        // collision.gameobject.SetActive(false);
    }
}
