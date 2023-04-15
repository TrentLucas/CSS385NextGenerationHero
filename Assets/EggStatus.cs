using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggStatus : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.x > 200 || pos.x < -200 || pos.y > 100 || pos.y < -100)
        {
            Destroy(this.gameObject);
            HeroShoot.eggCount--;
        }
    }
}
