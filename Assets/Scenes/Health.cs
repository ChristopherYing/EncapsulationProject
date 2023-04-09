using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{
    private int _health = 3;
    public int _Health
    {
        get { return _health; }
        set { _health = value; }
    }

    private bool _isDead = false;

    public void Heal(int amount)
    {
        _Health += amount;
    }

    public void TakeDamage(int amount)
    {
        _Health -= amount;

        if (_Health == 0)
        {
            SceneManager.LoadScene("EndScreen");
            _isDead = true;
        }
    }
}

