using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{


    //Créer un projectile (le sprite et l'instaance)
    //Input mouse click
    //Avoir le projectile qui part danbs une direction et se détruie au bout d'un moment

    // Start is called before the first frame update
    [SerializeField]
    private GameObject projectile;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        };
    }

    void Fire() {

        //Recupt coordonée x y mouse postion
        Instantiate(projectile, transform.position, transform.rotation);
        CameraShake.Instance.ShakingCamera(3f, .1f);
        //une fois tirée il se déplace vers les ccord x y mouse psotion
        //après X temps il est détruie
    }
    
}
