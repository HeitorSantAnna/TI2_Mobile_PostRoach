using UnityEngine;

public class Aceleradores : MonoBehaviour
{
    public static float aceleracaototal = 0;
    public float time = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (aceleracaototal > 0)
        {
            while (time >= 0)
            {
                Debug.Log("Estou entrando");
                time -= Time.deltaTime;
            }

            if(time <= 0)
            {
                Debug.Log("Parei de acelerar");
                aceleracaototal = 0;
                time = 10;
            }
        }
    }
}
