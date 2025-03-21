using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    public int seed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {

        float direction = Input. GetAxis("Horizontal");

        if (direction > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (direction < 0) ;
        {

        }
    }
}
