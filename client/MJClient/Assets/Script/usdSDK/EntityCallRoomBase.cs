/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Room.def
	public class EntityBaseEntityCall_RoomBase : EntityCall
	{

		public EntityBaseEntityCall_RoomBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

	}

	public class EntityCellEntityCall_RoomBase : EntityCall
	{

		public EntityCellEntityCall_RoomBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void chuPai(SByte arg1)
		{
			Bundle pBundle = newCall("chuPai", 0);
			if(pBundle == null)
				return;

			bundle.writeInt8(arg1);
			sendCall(null);
		}

		public void reqChangeReadyState(Byte arg1)
		{
			Bundle pBundle = newCall("reqChangeReadyState", 0);
			if(pBundle == null)
				return;

			bundle.writeUint8(arg1);
			sendCall(null);
		}

		public void reqGang(SByte arg1)
		{
			Bundle pBundle = newCall("reqGang", 0);
			if(pBundle == null)
				return;

			bundle.writeInt8(arg1);
			sendCall(null);
		}

		public void reqGetRoomInfo()
		{
			Bundle pBundle = newCall("reqGetRoomInfo", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqGuo()
		{
			Bundle pBundle = newCall("reqGuo", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqHu()
		{
			Bundle pBundle = newCall("reqHu", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void reqPeng()
		{
			Bundle pBundle = newCall("reqPeng", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}
	}
