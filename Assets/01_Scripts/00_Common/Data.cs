using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data<T>
{
    private T originalData;
    public T data
    {
        get {return originalData;}
    }
    public void Set(T data)
    {
        originalData = data;
    }
}