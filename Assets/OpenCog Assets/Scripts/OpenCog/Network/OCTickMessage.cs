
/// Unity3D OpenCog World Embodiment Program
/// Copyright (C) 2013  Novamente			
///
/// This program is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Affero General Public License as
/// published by the Free Software Foundation, either version 3 of the
/// License, or (at your option) any later version.
///
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU Affero General Public License for more details.
///
/// You should have received a copy of the GNU Affero General Public License
/// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#region Usings, Namespaces, and Pragmas

using System.Collections;
using OpenCog.Attributes;
using OpenCog.Extensions;
using ImplicitFields = ProtoBuf.ImplicitFields;
using ProtoContract = ProtoBuf.ProtoContractAttribute;
using Serializable = System.SerializableAttribute;

//The private field is assigned but its value is never used
#pragma warning disable 0414

#endregion

namespace OpenCog.Network
{

/// <summary>
/// The OpenCog OCTickMessage.
/// </summary>
#region Class Attributes

[ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
[OCExposePropertyFields]
[Serializable]
	
#endregion
public class OCTickMessage : OCMessage
{

	//---------------------------------------------------------------------------

	#region Private Member Data

	//---------------------------------------------------------------------------
	
	private string _rawText = "tick";
			
	//---------------------------------------------------------------------------

	#endregion

	//---------------------------------------------------------------------------

	#region Accessors and Mutators

	//---------------------------------------------------------------------------
		
	public string TickText
	{
		get{ return _rawText; }
		set{ _rawText = value; }
	}
			
	//---------------------------------------------------------------------------

	#endregion

	//---------------------------------------------------------------------------

	#region Public Member Functions

	//---------------------------------------------------------------------------

	public override string ToString()
	{
		return _rawText;
	}
	
	public override void FromString(string message)
	{
		_rawText = message;
	}

	//---------------------------------------------------------------------------

	#endregion

	//---------------------------------------------------------------------------

	#region Private Member Functions

	//---------------------------------------------------------------------------
	
	
			
	//---------------------------------------------------------------------------

	#endregion

	//---------------------------------------------------------------------------

	#region Other Members

	//---------------------------------------------------------------------------		

	public OCTickMessage(string sourceID, string targetID) 
	: base(sourceID, targetID, OCMessage.MessageType.RAW)
	{

	}
	
	public OCTickMessage(string sourceID, string targetID, string message) 
	: base(sourceID, targetID, OCMessage.MessageType.RAW)
	{
		_rawText = message;
	}

	//---------------------------------------------------------------------------

	#endregion

	//---------------------------------------------------------------------------

}// class OCTickMessage

}// namespace OpenCog.Network




