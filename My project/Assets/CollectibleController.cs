using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public CollectibleModel model;

    void Start()
    {
        model = new CollectibleModel();
    }
}
