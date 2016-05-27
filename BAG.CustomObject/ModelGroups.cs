using BAG.CustomObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.CustomObject
{
    public class Group_HeaderEvent
    {
        public HeaderEvents[] EventInvites { get; set; }
        public HeaderEvents[] MyEvent { get; set; }
    }

    public class Create_Event
    {
        public EventTypes[] EventTypes { get; set; }
        public CreateEvent CreateEvent { get; set; }
    }

    public class MyContacts
    {
        public GoogleContacts[] UserContacts { get; set; }

        public GroupDetails CreateGroup { get; set; }

        public GroupDetails UpdateGroup { get; set; }
    }

    public class ContactsSummary
    {
        public GoogleContacts[] UserContacts { get; set; }

        public string groupId { get; set; }

        public string createrId { get; set; }

    }

    public class EventDetails
    {
        public ItemsList[]  ItemList { get; set; }

        public U_EVNT_MASTER EventMaster { get; set; }

        public WishList CreateWishlist { get; set; }

        public WishList UpdateWishlist { get; set; }

        public Invites[] InvitedMembers { get; set; }
    }

    public class InviteContacts
    {
        public InviteMembers[] InvitedMembers { get; set; }

        public string wishlist_Id { get; set; }
        public string Event_Id { get; set; }
    }

    public class EventSummary
    {
        public ItemsList[] ItemList { get; set; }

        public int total { get; set; }

        public Invites[] InvitedMembers { get; set; }
    }

    public class YesNo
    {
        public int Id { get; set; }
        public string title { get; set; }
    }

    public class MemberProfile
    {
        public Profile EditProfile { get; set; }
        public List<YesNo> IsMarriedList { get; set; }
        public List<YesNo> Gender { get; set; }
    }
}
