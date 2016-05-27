using System;

namespace BAG.CustomObject
{
public class U_USR_Tickets
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_USR_Tickets()
	{}


	public int Ticket_Id
	{ 
		get { return _Ticket_Id; }
		set { _Ticket_Id = value; }
	}
	private int _Ticket_Id;

	public int Usr_Id
	{ 
		get { return _Usr_Id; }
		set { _Usr_Id = value; }
	}
	private int _Usr_Id;

	public int Event_Id
	{ 
		get { return _Event_Id; }
		set { _Event_Id = value; }
	}
	private int _Event_Id;

	public int Ord_Id
	{ 
		get { return _Ord_Id; }
		set { _Ord_Id = value; }
	}
	private int _Ord_Id;

	public string Ticket_Number
	{ 
		get { return _Ticket_Number; }
		set { _Ticket_Number = value; }
	}
	private string _Ticket_Number;

	public System.DateTime Creation_Date
	{ 
		get { return _Creation_Date; }
		set { _Creation_Date = value; }
	}
	private System.DateTime _Creation_Date;

	public string Ticket_Regarding
	{ 
		get { return _Ticket_Regarding; }
		set { _Ticket_Regarding = value; }
	}
	private string _Ticket_Regarding;

	public string Ticket_Dtl
	{ 
		get { return _Ticket_Dtl; }
		set { _Ticket_Dtl = value; }
	}
	private string _Ticket_Dtl;

	public string Ticket_Status
	{ 
		get { return _Ticket_Status; }
		set { _Ticket_Status = value; }
	}
	private string _Ticket_Status;

	public System.DateTime ResolutionDate
	{ 
		get { return _ResolutionDate; }
		set { _ResolutionDate = value; }
	}
	private System.DateTime _ResolutionDate;

	public string Resolution_Comments
	{ 
		get { return _Resolution_Comments; }
		set { _Resolution_Comments = value; }
	}
	private string _Resolution_Comments;

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

	public U_USR_Tickets(

		int Ticket_Id, 
		int Usr_Id, 
		int Event_Id, 
		int Ord_Id, 
		string Ticket_Number, 
		System.DateTime Creation_Date, 
		string Ticket_Regarding, 
		string Ticket_Dtl, 
		string Ticket_Status, 
		System.DateTime ResolutionDate, 
		string Resolution_Comments, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Ticket_Id = Ticket_Id; 
		this._Usr_Id = Usr_Id; 
		this._Event_Id = Event_Id; 
		this._Ord_Id = Ord_Id; 
		this._Ticket_Number = Ticket_Number; 
		this._Creation_Date = Creation_Date; 
		this._Ticket_Regarding = Ticket_Regarding; 
		this._Ticket_Dtl = Ticket_Dtl; 
		this._Ticket_Status = Ticket_Status; 
		this._ResolutionDate = ResolutionDate; 
		this._Resolution_Comments = Resolution_Comments; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}