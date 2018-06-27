﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSource : MonoBehaviour {
    public int max = 100;
    private int amount;
    private SpriteRenderer spriteR;

	void Start () {
        this.spriteR = this.GetComponent<SpriteRenderer>();
        this.amount = this.max;
    }

    void Update()
    {
        if (this.amount < this.max)
        {
            Destroy(this.gameObject);
            return;
        }
    }

    public int GetWater(int capacity)
    {
        int amount = Mathf.Min(capacity, this.amount);
        this.amount -= amount;
    
        return amount;
    }
}
