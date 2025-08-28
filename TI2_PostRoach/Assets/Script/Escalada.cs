using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Escalada : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float input, speed;
    public float sensibitlity = 3;
    bool pressing;
    [SerializeField] GameObject player;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }

    void Update()
    {
        if(pressing)
        {
            input += Time.deltaTime * sensibitlity;
        }
        else
        {
            input -= Time.deltaTime * (sensibitlity * 10000);
        }

        input = Mathf.Clamp(input, 0, 40);

        player.transform.Translate(0, speed * input * Time.deltaTime, 0);
    }
}
