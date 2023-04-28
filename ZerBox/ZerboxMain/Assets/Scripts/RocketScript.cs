using UnityEngine;

public class RocketScript : MonoBehaviour
{
    public float explodeRadius = 5f;
    public ParticleSystem boom;
    bool used = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!used)
        {
            Instantiate(boom, transform.position, Quaternion.identity);
            Collider[] collidersss = Physics.OverlapSphere(transform.position, explodeRadius);
            for (int i = 0; i < collidersss.Length; i++)
            {
                if (collidersss[i].GetComponent<DieZoneScript>() != null)
                {
                    DieZoneScript diezone = collidersss[i].GetComponent<DieZoneScript>();
                    diezone.Damage(-1);
                    Destroy(gameObject);
                }
            }
            Destroy(gameObject);
            used = true;
        }
    }
}
