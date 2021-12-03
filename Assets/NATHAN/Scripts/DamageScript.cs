using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField]
    public float Damage = 1;
    public PlayerHealth PH;
    public EnemyHealthScript EH;
    public bool IsProjectile = true;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PlayerHealth>();
        GetComponent<EnemyHealthScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            PH.Health -= Damage;
            Debug.Log("Damage");
        }

        if (collision.tag == "CanTakeDamage")
        {
            EH.Health -= Damage;
            Debug.Log("Enemy Damaged");
        }

        if (IsProjectile == true)
        {
            Destroy(this.gameObject);
        }
        
    }
}
