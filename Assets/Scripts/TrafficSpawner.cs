using UnityEngine;
using UnityEngine.AI;
using System.Collections;
 
public class TrafficSpawner : MonoBehaviour {

    Vector3 position;
    public GameObject car;
    public GameObject endGoal;
    public GameObject player;
    
    // Use this for initialization
    void Start () 
    {
        Invoke("Spawn", 1);
    }
 
    // Update is called once per frame
    void Update () {
 
    }
 
    void Spawn()
    {
        float radius = Vector3.Distance(endGoal.transform.position, player.transform.position);
        int spawnNum = (int) radius/8;
        if (spawnNum > 75){
            spawnNum = 75;
        }
        for (int i=0; i<spawnNum; i++) {
            position = RandomNavmeshLocation(radius);
            car = (GameObject) Instantiate(car, position, player.transform.rotation);
        } 
    }

    public Vector3 RandomNavmeshLocation(float radius) {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1)) {
            finalPosition = hit.position;            
        }
        return finalPosition;
    }
}