using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    PlayerBehaviour playerRef;

    private float heightBy2, widhtBy2;
    public BoxCollider2D boxSurrounding;
    void Start()
    {
        playerRef = FindObjectOfType<PlayerBehaviour>();
        heightBy2 = Camera.main.orthographicSize;
        widhtBy2 = heightBy2 * Camera.main.aspect;
        Debug.Log($"boxSurrounding.bounds.max.x{boxSurrounding.bounds.max.x}");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRef!=null)
        {
            this.transform.position = new Vector3(Mathf.Clamp(playerRef.transform.position.x, boxSurrounding.bounds.min.x + widhtBy2,
                                        boxSurrounding.bounds.max.x-10), Mathf.Clamp(playerRef.transform.position.y ,
                                        boxSurrounding.bounds.min.y + heightBy2,
                                        boxSurrounding.bounds.max.y - heightBy2), transform.position.z);
        }
    }
}
