using System;

namespace BAG.CustomObject
{
public class U_EVNT_Cntrb_Dtl
{
	/// <summary>
	/// Default Contructor
	/// <summary>
	public U_EVNT_Cntrb_Dtl()
	{}


	public int Cntrb_Seq_Id
	{ 
		get { return _Cntrb_Seq_Id; }
		set { _Cntrb_Seq_Id = value; }
	}
	private int _Cntrb_Seq_Id;

	public int Event_Id
	{ 
		get { return _Event_Id; }
		set { _Event_Id = value; }
	}
	private int _Event_Id;

	public int WList_Id
	{ 
		get { return _WList_Id; }
		set { _WList_Id = value; }
	}
	private int _WList_Id;

	public string Item_Id
	{ 
		get { return _Item_Id; }
		set { _Item_Id = value; }
	}
	private string _Item_Id;

	public int Cntrb_Id
	{ 
		get { return _Cntrb_Id; }
		set { _Cntrb_Id = value; }
	}
	private int _Cntrb_Id;

	public decimal Cntrb_Amount
	{ 
		get { return _Cntrb_Amount; }
		set { _Cntrb_Amount = value; }
	}
	private decimal _Cntrb_Amount;

	public string Cntrb_Currency
	{ 
		get { return _Cntrb_Currency; }
		set { _Cntrb_Currency = value; }
	}
	private string _Cntrb_Currency;

	public decimal Pool_Amount
	{ 
		get { return _Pool_Amount; }
		set { _Pool_Amount = value; }
	}
	private decimal _Pool_Amount;

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

	public U_EVNT_Cntrb_Dtl(

        int Cntrb_Seq_Id,
        int Event_Id,
        int WList_Id, 
		string Item_Id,
        int Cntrb_Id, 
		decimal Cntrb_Amount, 
		string Cntrb_Currency, 
		decimal Pool_Amount, 
		System.DateTime Created_Date, 
		System.DateTime Updated_Date, 
		string Created_by, 
		string Updated_by)
	{

	
		this._Cntrb_Seq_Id = Cntrb_Seq_Id; 
		this._Event_Id = Event_Id; 
		this._WList_Id = WList_Id; 
		this._Item_Id = Item_Id; 
		this._Cntrb_Id = Cntrb_Id; 
		this._Cntrb_Amount = Cntrb_Amount; 
		this._Cntrb_Currency = Cntrb_Currency; 
		this._Pool_Amount = Pool_Amount; 
		this._Created_Date = Created_Date; 
		this._Updated_Date = Updated_Date; 
		this._Created_by = Created_by; 
		this._Updated_by = Updated_by; 
	}
}
}