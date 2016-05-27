using System;

namespace BAG.CustomObject
{
public class HeaderEvents
{
	public HeaderEvents()
	{}
        
	public string Event_Id
	{ 
		get { return _Event_Id; }
		set { _Event_Id = value; }
	}
	private string _Event_Id;

	public string Event_Name
	{ 
		get { return _Event_Name; }
		set { _Event_Name = value; }
	}
	private string _Event_Name;

    public string Event_Image
    {
        get { return _Event_Image; }
        set { _Event_Image = value; }
    }
    private string _Event_Image;
    

	public HeaderEvents(

        string Event_Id, 
		string Event_Name,
        string Event_Image)
	{
		this._Event_Id = Event_Id; 
		this._Event_Name = Event_Name;
        this._Event_Image = Event_Image;
	}
}
}