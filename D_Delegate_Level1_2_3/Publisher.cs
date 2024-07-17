namespace D_Delegate_Level1_2_3;

public delegate void MyDelegate(string message);
class Publisher
{
	private MyDelegate subscribers;
	public bool AddSubscriber(MyDelegate del)
	{
		if(!CheckDelegate(del)) 
		{
			subscribers += del;
			return true;
		}
		return false;
	}
	public bool RemoveSubscriber(MyDelegate del)
	{
		if(CheckDelegate(del)) 
		{
			subscribers -= del;
			return true;
		}
		return false;
	}
	private bool CheckDelegate(MyDelegate del)
	{
		if (subscribers is not null)
		{
			Delegate[] delegates = subscribers.GetInvocationList();
			if (delegates.Contains(del))
			{
				return true;
			}
		}
		return false;
	}
	public void SentNotification()
	{
		subscribers?.Invoke("Hello all");
	}
}

