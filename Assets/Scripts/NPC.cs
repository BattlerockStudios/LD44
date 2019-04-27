public class NPC : Character, IInteractable
{
    public bool IsBeingInteractedWith => throw new System.NotImplementedException();

    public void BeginInteraction(IInteractionSource interactionSource)
    {
        throw new System.NotImplementedException();
    }

    public void EndInteraction(IInteractionSource interactionSource)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
