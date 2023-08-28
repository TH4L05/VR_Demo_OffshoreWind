using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public UnityEvent OnTriggerEnterEvent;
    public UnityEvent OnTriggerExitEvent;
    public bool active;
    public Button bt;

    private void Update()
    {
        /*if (active)
        {
            OnTriggerEnterEvent?.Invoke();
        }*/
    }

    private void OnTriggerEnter(Collider collider)
    {
       if(active)
        {
            OnTriggerEnterEvent?.Invoke();
        }
        
    }

    private void OnTriggerStay(Collider ocollider)
    {
        
    }

    private void OnTriggerExit(Collider ocollider)
    {
        
    }
}
