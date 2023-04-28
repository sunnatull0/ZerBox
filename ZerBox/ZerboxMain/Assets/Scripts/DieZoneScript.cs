using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DieZoneScript : MonoBehaviour
{
    public float diezone;
    public int  maxhealth = 3;
    private int health;
    public Image[] images;
    public AudioSource diesound;
    bool isdone = false;
    private void Start()
    {
        health = maxhealth;
    }

    public void Damage(int damagee)
    {
        health += damagee;
        if (health <= 0)
        {
            diesound.Play();
            Reload();
        }
    }

    private void Update()
    {
        if(transform.position.y <= diezone && !isdone)
        {
            StartCoroutine(Die());
            isdone = true;
        }

        if(health == 2)
        {
            images[0].gameObject.SetActive(false);
        }
        
        if (health == 1)
        {
            images[1].gameObject.SetActive(false);
        }
    }


    void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator Die()
    {
        diesound.Play();
        yield return new WaitForSeconds(1f);
        Reload();
    }

}
