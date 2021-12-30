using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;

    public HealthBarContol hpBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        hpBar.SetMaxHp(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DamageControl(10);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RecoverControl(10);
        }
    }

    void DamageControl(int damage)
    {
        currentHp -= damage;
        hpBar.SetHp(currentHp);
    }
    void RecoverControl(int gainHp)
    {
        currentHp += gainHp;
        hpBar.SetHp(currentHp);
    }
}
