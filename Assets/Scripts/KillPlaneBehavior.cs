using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlaneBehavior : MonoBehaviour
{
    public GameObject gameOverScreen;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
            gameOverScreen.SetActive(gameOver);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
