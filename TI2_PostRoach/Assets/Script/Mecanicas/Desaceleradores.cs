using UnityEngine;

public class Desaceleradores : MonoBehaviour
{
    public static float desaceleracaototal = 0;
    public float time = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (desaceleracaototal > 0)
        {
            while (time >= 0)
            {
                Debug.Log("Desacelerando");
                time -= Time.deltaTime;
            }

            if (time <= 0)
            {
                Debug.Log("Acelerando novamente");
                desaceleracaototal = 0;
                time = 10;
            }
        }
    }
}
