using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public float shurikens = 0;
    public Vector3 offset;
    public GameObject s1;
    public GameObject s2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && shurikens >=1)
        {
            shurikens = 0;
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(objectThrown, throwablePosition, transform.rotation);
            sleep 3
            print("e");
            

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collect")
        {
            shurikens = 1;
            
        }
/*        if (collision.gameObject.tag == "Collect2")
        {
            shurikens++;
            Destroy(s2);
        }*/
    }
    
}
