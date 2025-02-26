using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class SoundsRefSO : ScriptableObject{

    public AudioClip[] chop;
    public AudioClip[] deliveryFail;
    public AudioClip[] deliverySuccess;
    public AudioClip[] footsteps;
    public AudioClip[] objectDrop;
    public AudioClip[] objectPickUp;
    public AudioClip[] trash;
    public AudioClip[] warning;
    public AudioClip[] stoveSizzle;
}
