using UnityEngine;

public class Escalada : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == 6)
        {
            Debug.Log("Voc  colidiu");
        }
    }
}
