using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBait : MonoBehaviour
{
    public GameObject particles;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount >= 1)
        {
            this.gameObject.tag = "baitedtrap";
            Debug.Log("baited trap");
        }

        if (this.transform.childCount >= 4)
        {
            Destroy(this.gameObject);
            Instantiate(particles, this.transform);
        }
    }
}
