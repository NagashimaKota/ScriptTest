using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int hp = 100;
    int power = 25;
    int mp = 53;

    public void Attak()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
        Debug.Log("残りHP:" + hp);
    }

    public void Magic()
    {
        
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMP:" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }
}



public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = new int[5];
        Boss lastBoss = new Boss();

        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (i + 1) * 5; 
            Debug.Log(array[i]);
        }

        for(int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        for(int i = 0; i < 12; i++)
        {
            lastBoss.Magic();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
