using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    #region Variables
    public GameObject target; //Reference to the game object for the camera follow 

    //A Serialized Field keeps a field/variable private while still allowing it to be modified in the Unity Engine 
    [SerializeField] Vector3 positionOffset; // Position offset between the target & camera 
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Calculates the initial offset between the target & camera position
        positionOffset = transform.position - target.transform.position;
    }

    // LateUpdate is called once per frame
    void LateUpdate()
    {
        //Move the camera to follow the player, using the offset maintain the correct distance 
        transform.position = target.transform.position + positionOffset; 
    }
}
