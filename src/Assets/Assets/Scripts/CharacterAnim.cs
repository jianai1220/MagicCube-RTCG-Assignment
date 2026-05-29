using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    Animator m_Animator;
    MarkerManagerScript marker;
    string lastMarker = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Animator = GameObject.Find("character_model").GetComponent<Animator>();
        marker = GameObject.FindFirstObjectByType<MarkerManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (marker == null || string.IsNullOrEmpty(marker.detectedMarkerName))
            return;

        string current = marker.detectedMarkerName;

        if (current == lastMarker) return;

        lastMarker = current;

        m_Animator.ResetTrigger("Fireball");
        m_Animator.ResetTrigger("Shuffling");
        m_Animator.ResetTrigger("Looking");
        m_Animator.ResetTrigger("Torch");
        m_Animator.ResetTrigger("Header Soccerball");
        m_Animator.ResetTrigger("Waving");
        m_Animator.ResetTrigger("Standing Idle");

        if (current.Equals("Campfire"))
        {
            m_Animator.Play("Fireball");
        }
        else if (current.Equals("Speakers"))
        {
            m_Animator.Play("Shuffling");
        }
        else if (current.Equals("Birds"))
        {
            m_Animator.Play("Looking");
        }
        else if (current.Equals("Forest"))
        {
            m_Animator.Play("Torch");
        }
        else if (current.Equals("Ball"))
        {
            m_Animator.Play("Header Soccerball");
        }
        else if (current.Equals("Animals"))
        {
            m_Animator.Play("Waving");
        }
        else
        {
            m_Animator.Play("Standing Idle");
        }
    }
}
