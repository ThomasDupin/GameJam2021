using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Touched : MonoBehaviour
{
    public string LevelName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        if (collider.name == "Enemy")
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
