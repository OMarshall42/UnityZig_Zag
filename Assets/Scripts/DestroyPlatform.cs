using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<ScoreManager>().UpdateScore();
            transform.parent.GetComponent<Rigidbody>().useGravity = true;
            Invoke("AfterFallFinish", 3f);
        }
    }

    void AfterFallFinish()
    {
        FindObjectOfType<PlatformSpawner>().DecreaseNumberPlatforms();
        Destroy(transform.parent.gameObject);
    }
}
