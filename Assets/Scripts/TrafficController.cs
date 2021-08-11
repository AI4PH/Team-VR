// MoveTo.cs
using UnityEngine;
using UnityEngine.AI;
    
public class TrafficController : MonoBehaviour 
{
       
    NavMeshAgent agent;
    bool firstDestSet = false;

    void Start () {
        agent = GetComponent<NavMeshAgent>();
        moveCar();
    }

    void Update() {
        if ((firstDestSet == true) && (agent.remainingDistance < 1)) {
            moveCar();
        }
    }

    void moveCar() {
        Vector3 position = RandomNavmeshLocation(5000);
        firstDestSet = true;
        agent.SetDestination(position); 
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