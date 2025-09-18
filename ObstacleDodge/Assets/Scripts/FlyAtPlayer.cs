using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float flyingSpeed = 0.01f;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MovetoPlayer();
        DestroyWhenReached();
    }

    void MovetoPlayer()
    {
        transform.position =
            Vector3.MoveTowards(transform.position, playerPosition, flyingSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
