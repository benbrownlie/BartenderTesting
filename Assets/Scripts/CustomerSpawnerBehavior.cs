using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawnerBehavior : MonoBehaviour
{
    public float maxTime;
    public float leastTime;
    public bool stopSpawning;
    public GameObject Customer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCustomers());
    }

    public IEnumerator SpawnCustomers()
    {
        while (!stopSpawning)
        {
            float spawnTimer = Random.Range(leastTime, maxTime);

            Vector3 Spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            GameObject customer = Instantiate(Customer.gameObject, Spawn, new Quaternion());
            CustomerMovementBehavior MoveCustomer = customer.GetComponent<CustomerMovementBehavior>();

            yield return new WaitForSeconds(spawnTimer);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
