using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float maxHunger, maxThirst;
    public float hungerIncreaseRate, thirstIncreaseRate;
    private float hunger, thirst;

    public float lifespan;
    private float age;

    private bool dead;

    // Start is called before the first frame update
    void Start()
    {
        this.age = 0.0f;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead) {
            hunger += hungerIncreaseRate * Time.deltaTime;
            thirst += thirstIncreaseRate * Time.deltaTime;
        }

        if (thirst >= maxThirst || hunger >= maxHunger)
            Die();
    }

    public void Die() {
        dead = true;
        print("Rabbit has died from hunger or thirst");
        Destroy(this.gameObject);
    }
}
