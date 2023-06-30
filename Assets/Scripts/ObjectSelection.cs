using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    public event Action OnObjectSelection;
    public float selectionTime;

    private float timeCounter;
    private bool isLookingAt;

    private void Update()
    {
        if (isLookingAt)
        {
            timeCounter += Time.deltaTime;
            if (timeCounter >= selectionTime)
            {
                timeCounter = 0;
                isLookingAt = false;
                OnObjectSelection?.Invoke();
            }
        }
    }

    public void StartObjectSelection()
    {
        isLookingAt = true;
        timeCounter = 0;
    }
    
    
}
