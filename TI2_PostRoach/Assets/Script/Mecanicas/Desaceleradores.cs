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
                time -= Time.deltaTime;
            }

            if (time <= 0)
            {
                desaceleracaototal = 0;
                time = 10;
            }
        }
    }
}
