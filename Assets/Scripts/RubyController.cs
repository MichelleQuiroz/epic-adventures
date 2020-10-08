using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
   

    // Update is called once per frame
    /// <summary>
	/// Update allows player to move Ruby along the x and y axis
	/// Input.GetAxis, transform.position, and Time.deltaTime are recognized by Unity
	/// </summary>
    #region Update Movement
    void Update()
    {
        
        float moveleft_and_right = Input.GetAxis("Horizontal");
        float moveup_and_down = Input.GetAxis("Vertical");

        Vector2 movingRuby = transform.position;

        movingRuby.x = movingRuby.x + 1f * moveleft_and_right * Time.deltaTime;
        movingRuby.y = movingRuby.y + 1f * moveup_and_down * Time.deltaTime;

        transform.position = movingRuby;
    }
    #endregion
}
