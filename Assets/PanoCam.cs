using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PanoCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
			File.WriteAllBytes("Pano.PNG", I360Render.Capture(4096, false,
				null, false));
    }
}
