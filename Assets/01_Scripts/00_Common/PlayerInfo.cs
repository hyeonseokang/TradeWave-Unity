using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : Singleton<MonoBehaviour>
{
    private Data<int> gold;
    private Data<int> diamond;
    private Data<int> progress;   

    public void AddGold(int value)
    {
        int data = gold.data + value;
        gold.Set(data);
    }

    public void AddDiamond(int value)
    {
        int data = diamond.data + value;
        diamond.Set(data);
    }

    public void AddProgress()
    {
        progress.Set(progress.data + 1);    
    }
}
