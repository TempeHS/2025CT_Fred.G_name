using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverBar : MonoBehaviour

{
    public GameObject followerPrefab;
    public float offsetY;

    void Start()
    {
        if (followerPrefab != null)
    {
        GameObject follower = Instantiate(followerPrefab, transform);
follower.transform.localPosition = new Vector3(0, offsetY, 0); 
    }
    }

}
