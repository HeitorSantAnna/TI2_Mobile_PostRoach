using UnityEngine;
using UnityEngine.UI;

public class ControllerPlayer : MonoBehaviour
{
    [SerializeField] Button escalada, voar;
    [SerializeField] GameObject player;

    void Start()
    {
        escalada.interactable = false;
        voar.interactable = false;
    }

    void Update()
    {
        if(player.transform.position.y > 2)
        {
            voar.interactable = true;
        }
        else
        {
            voar.interactable = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 6)
        {
            escalada.interactable = true;
        }
        else
        {
            escalada.interactable = false;
        }
    }
}
