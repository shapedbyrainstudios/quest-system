using System;

public class MiscEvents
{
    public event Action onCoinCollected;
    public void CoinCollected() 
    {
        if (onCoinCollected != null) 
        {
            onCoinCollected();
        }
    }

    public event Action onGemCollected;
    public void GemCollected() 
    {
        if (onGemCollected != null) 
        {
            onGemCollected();
        }
    }
}
