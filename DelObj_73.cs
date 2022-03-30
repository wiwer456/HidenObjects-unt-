using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelObj_73 : MonoBehaviour
{
    public GameObject Object1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        Destroy(Object1);
        Destroy(gameObject);
    }
}
