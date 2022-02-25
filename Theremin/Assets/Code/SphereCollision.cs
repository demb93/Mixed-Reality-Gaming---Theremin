using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollision : MonoBehaviour
{

    public GameObject particles;

    private void OnCollisionEnter(Collision collision)
    {
        float Position_x = this.transform.position.x;
        float Position_y = this.transform.position.y;
        float Position_z = this.transform.position.z;

        GameObject firework = Instantiate(particles, new Vector3(Position_x, Position_y, Position_z), Quaternion.identity);
        firework.GetComponent<ParticleSystem>().Play();
    }
}
