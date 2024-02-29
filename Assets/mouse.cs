using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //GetComponent<Rigidbody>().AddForce(Vector3.zero, ForceMode.Impulse);

            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
            transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
            if(count > 0)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.back * 8.0f, ForceMode.Impulse);

            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            count++;
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 20.0f, ForceMode.Impulse);
        }
        if(tt.counter == 6)
        {
            transform.position = new Vector3(0, 2, -24);
        }
    }
}
