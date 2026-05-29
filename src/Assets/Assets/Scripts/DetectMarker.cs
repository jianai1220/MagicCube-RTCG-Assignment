using UnityEngine;

public class DetectMarker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void info()
    {
        MarkerManagerScript marker = 
            GameObject.FindFirstObjectByType<MarkerManagerScript>();

        marker.object3D = transform.GetChild(0).gameObject;
        marker.detectedMarkerName = transform.name;
    }

    public void flushInfo()
    {
        MarkerManagerScript marker =
            GameObject.FindFirstObjectByType<MarkerManagerScript>();
        marker.object3D = null;
    }
}
