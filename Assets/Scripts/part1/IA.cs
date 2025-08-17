using UnityEngine;

public class IA : MonoBehaviour
{
    [SerializeField] public float _speed = 5F;
    [SerializeField] public float Radio = 5F;
    public float Ataque;
    public Transform Player;

    void Update()
    {
        if (Player == null) return;

        float distance = Vector3.Distance(transform.position, Player.position);


        if (distance <= Radio)
        {

            transform.position = Vector3.MoveTowards(transform.position , Player.position , _speed * Time.deltaTime);


            if (distance <= Ataque)
            {
                Debug.Log("Has sido atacado");
            }
        }
    }
}