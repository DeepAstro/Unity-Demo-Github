using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerModel model;
    private Vector3 movement;

    void Start()
    {
        model = new PlayerModel();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movement = new Vector3(horizontal, 0, vertical) * model.speed * Time.deltaTime;
        transform.position += movement;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            model.score += other.GetComponent<CollectibleController>().model.points;
            Destroy(other.gameObject);
        }
    }
}
