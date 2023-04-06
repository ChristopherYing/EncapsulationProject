using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

/* Chris
Platform UML
* Platforms will not allow the player to jump through them, but will allow dropping through by pressing down.
-------------------------------
-int _dropTimer // Seconds the platform collision will be disabled for. Will vary depending on platform height
-------------------------------
Platform(int)
+int GetDropTimer()
+void SetDropTimer(int)
+void Drop() // Temporarily disables collisions to drop player
-------------------------------

MovingPlatform UML
* Inherits from Platform
* Movement loop will be made outside of the class in Update()
-------------------------------
-int _speed // Platform movement speed (units/s)
-------------------------------
MovingPlatform(int dropTimer, int speed) : base(dropTimer)
+void MoveHorizontal(int) // Encapsulates horizontal translations
+void MoveVertical(int) // Encapsulates vertical translations
// Lock Player on moving platform
-------------------------------
*/

