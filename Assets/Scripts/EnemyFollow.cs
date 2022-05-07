using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float health;
    public float recurringDistance;
    public Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) > recurringDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, player.position) < recurringDistance)
        {
            Debug.Log("Attack");
        }
    }
}
