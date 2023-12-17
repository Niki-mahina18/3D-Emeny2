using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    public AudioClip damageSound;
    public AudioSource audioSource;
    public void TakeDamage(int damage)
 {
        health -= damage;

        if(health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("здоровье игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
