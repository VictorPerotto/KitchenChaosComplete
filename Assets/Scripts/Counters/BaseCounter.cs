using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent{

    public static event EventHandler OnAnyObjectPlacedHere;
    [SerializeField] protected Transform counterTopPoint;

    private KitchenObject kitchenObject;
    
    public virtual void Interact(Player player){
        Debug.LogError("BaseCounter.Interact()");
    }    

    public virtual void InteractAlternate(Player player){
        Debug.LogError("BaseCounter.InteractAlternate()");
    }   

    public Transform GetKitchenObjectFollowTransform(){
        return counterTopPoint;
    }

    public KitchenObject GetKitchenObject(){
        return kitchenObject;
    }

    public void SetKitchenObject(KitchenObject kitchenObject){
        this.kitchenObject = kitchenObject;

        if(kitchenObject != null){
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public void ClearKitchenObject(){
        kitchenObject = null;
    }

    public bool HasKitchenObject(){
        return kitchenObject != null;
    }
}
