using System;

namespace BAG.CustomObject
{
public class U_USR_Contacts
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Contacts()
	{}


	public int Contact_Id
	{ 
		get { return _Contact_Id; }
		set { _Contact_Id = value; }
	}
	private int _Contact_Id;

	public string Email_Id
	{ 
		get { return _Email_Id; }
		set { _Email_Id = value; }
	}
	private string _Email_Id;

	public string Mobile_Number
	{ 
		get { return _Mobile_Number; }
		set { _Mobile_Number = value; }
	}
	private string _Mobile_Number;

	public string Person_Name
	{ 
		get { return _Person_Name; }
		set { _Person_Name = value; }
	}
	private string _Person_Name;

	public string Contact_Status
	{ 
		get { return _Contact_Status; }
		set { _Contact_Status = value; }
	}
	private string _Contact_Status;

	public string Contact_Source
	{ 
		get { return _Contact_Source; }
		set { _Contact_Source = value; }
	}
	private string _Contact_Source;

	public System.DateTime Created_Date
	{ 
		get { return _Created_Date; }
		set { _Created_Date = value; }
	}
	private System.DateTime _Created_Date;

	public System.DateTime Updated_Date
	{ 
		get { return _Updated_Date; }
		set { _Updated_Date = value; }
	}
	private System.DateTime _Updated_Date;

	public string Created_by
	{ 
		get { return _Created_by; }
		set { _Created_by = value; }
	}
	private string _Created_by;

	public string Updated_by
	{ 
		get { return _Updated_by; }
		set { _Updated_by = value; }
	}
	private string _Updated_by;

	public U_USR_Contacts(

		int Contact_Id, 
		string Email_Id, 
		string Mobile_Number, 
		string Person_Name, 
		string Contact_Status, 
		string Contact_Source, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Contact_Id = Contact_Id; 
		this._Email_Id = Email_Id; 
		this._Mobile_Number = Mobile_Number; 
		this._Person_Name = Person_Name; 
		this._Contact_Status = Contact_Status; 
		this._Contact_Source = Contact_Source; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}