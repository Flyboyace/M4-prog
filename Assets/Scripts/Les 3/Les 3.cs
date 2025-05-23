using UnityEngine;

public class Les3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "hits pickup");
        Debug.Log("hits collider");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hits trigger");
    }
}



