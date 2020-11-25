using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{

    public GameObject Player;
    public float TargetDistance;
    //public float AllowedRange;
    public GameObject Enemy;
    public float EnemySpeed;
    public int EnemyTrigger;
    public float LineOfSight;


    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player.transform);
        if (TargetDistance <= LineOfSight)
        {
            EnemySpeed = 0.008f;
            if (EnemyTrigger == 0)
            {
                Enemy.GetComponent<Player>();
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, EnemySpeed);
                //Enemy.GetComponent<LineOfSight>();
            }
        }
        else
        {
            EnemySpeed = 0;
        }
    }
}
