using John;
using Mirror;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : NetworkBehaviour
{
    public GameManager gameManager;
    public Text counterText;
    [SyncVar]
    public float counter;

    public bool startCount;
    
    // Start is called before the first frame update
    public override void OnStartServer()
    {
        base.OnStartServer();
        if (isServer)
        {
            gameManager.StartTimer += RPCCountdown;
            hasAuthority = true;
            counter = 3000.0f;
            startCount = false;
        }
    }
    public override void OnStopServer()
    {
        base.OnStopServer();
        gameManager.StartTimer -= RPCCountdown;
    }
    // Update is called once per frame
    void Update()
    {
        counterText.text = ("Time Remaining: " + counter.ToString());
        if (startCount)
        {
            counter = (counter - Time.deltaTime);
        }
        
    }
    
    
    [ClientRpc]
    public void RPCCountdown()
    {
        startCount = true;
    }
}
