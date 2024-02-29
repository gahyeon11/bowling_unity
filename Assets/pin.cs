using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z > 30 || transform.eulerAngles.z < -30 || transform.eulerAngles.x > 30 || transform.eulerAngles.x < -30)
        {
            Debug.Log("drop");
            ///tt.counter += 1;
        }
        if(tt.counter >= 6)
        {
            Debug.Log("STRIKE!");
            tt.counter = 0;

        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("floor"))
        {

           tt.counter += 1;

        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
