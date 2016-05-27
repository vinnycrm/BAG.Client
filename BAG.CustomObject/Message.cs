using System;

namespace BAG.CustomObject
{
public class Message
{

	public Message()
	{}

	public string Msg
	{ 
		get { return _Msg; }
		set { _Msg = value; }
	}
	private string _Msg;

    public Message(string Msg)
	{
		this._Msg = Msg;  
	}
}
}