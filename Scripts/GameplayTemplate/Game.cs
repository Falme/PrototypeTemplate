using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Observer[] observers;

    private ISubject subject;

    // Start is called before the first frame update
    void Start()
    {
        subject = new Subject();

        for(int a=0; a<observers.Length; a++)
            subject.Attach(observers[a].GetComponent<Observer>());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)) subject.Notify();
    }
}
