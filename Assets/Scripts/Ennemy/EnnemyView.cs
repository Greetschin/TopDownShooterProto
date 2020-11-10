using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyView : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Fire();
            Debug.Log("Player en vue");
        }
        return;

    }
    void Fire()
    {
        
        Debug.Log("Feu !");
    }
}
