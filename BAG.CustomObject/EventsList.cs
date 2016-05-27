using System;

namespace BAG.CustomObject
{
public class EventsList
{

	public EventsList()
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

	public string Total_attendies
	{
        get { return _Total_attendies; }
        set { _Total_attendies = value; }
	}
    private string _Total_attendies;

	public string Image
	{
        get { return _Image; }
        set { _Image = value; }
	}
    private string _Image;


    public EventsList(

        string Event_Id,
        string Event_Name,
        string Total_attendies,
        string Image)
	{


        this._Event_Id = Event_Id;
        this._Event_Name = Event_Name;
        this._Total_attendies = Total_attendies;
        this._Image = Image;
	}
}
}