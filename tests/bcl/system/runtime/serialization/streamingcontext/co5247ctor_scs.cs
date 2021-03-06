// ==++==
//
//   
//    Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//   
//    The use and distribution terms for this software are contained in the file
//    named license.txt, which can be found in the root of this distribution.
//    By using this software in any fashion, you are agreeing to be bound by the
//    terms of this license.
//   
//    You must not remove this notice, or any other, from this software.
//   
//
// ==--==
using System;
using System.Resources;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
public class Co5247ctor_SCS
{
	public static readonly String s_strActiveBugNums = "";
	public static readonly String s_strDtTmVer       = "";
	public static readonly String s_strClassMethod   = "StreamingContext(StreamingContextStates)";
	public static readonly String s_strTFName        = "Co5247ctor_SCS.cs";
	public static readonly String s_strTFAbbrev      = "Co5247";
	public static readonly String s_strTFPath        = Environment.CurrentDirectory;
	public virtual bool runTest()
	{
		Console.WriteLine(s_strTFPath + " " + s_strTFName + " , for " + s_strClassMethod + " , Source ver " + s_strDtTmVer);
		int iCountErrors = 0;
		int iCountTestcases = 0;
		String strLoc = "Loc_000oo";
		String strBaseLoc = "";
		try {
			LABEL_860_GENERAL:
			do
			{
				StreamingContext sCon2;
				int iState;
				strLoc = "Loc_300aa";
				sCon2 = new StreamingContext(StreamingContextStates.CrossProcess);
				iCountTestcases++;
				if(sCon2.State != StreamingContextStates.CrossProcess)
				{
					iCountErrors++;
					printerr("Error_300bb! Incorrect state set in StreamingContext");
				}
				sCon2 = new StreamingContext(StreamingContextStates.CrossMachine);
				iCountTestcases++;
				if(sCon2.State != StreamingContextStates.CrossMachine)
				{
					iCountErrors++;
					printerr("Error_300dd! Incorrect state set in StreamingContext");
				}
				sCon2 = new StreamingContext(StreamingContextStates.File);
				iCountTestcases++;
				if(sCon2.State != StreamingContextStates.File)
				{
					iCountErrors++;
					printerr("Error_300ee! Incorrect state set in StreamingContext");
				}
				sCon2 = new StreamingContext(StreamingContextStates.Persistence);
				iCountTestcases++;
				if(sCon2.State != StreamingContextStates.Persistence)
				{
					iCountErrors++;
					printerr("Error_300ff! Incorrect state set in StreamingContext");
				}
				sCon2 = new StreamingContext(StreamingContextStates.Other);
				iCountTestcases++;
				if(sCon2.State != StreamingContextStates.Other)
				{
					iCountErrors++;
					printerr("Error_300gg! Incorrect state set in StreamingContext");
				}
			} while (false);
			} catch (Exception exc_general ) {
			++iCountErrors;
			Console.WriteLine (s_strTFAbbrev + " : Error Err_8888yyy!  strLoc=="+ strLoc +", exc_general==\n"+exc_general.StackTrace);
		}
		if ( iCountErrors == 0 )
		{
			Console.WriteLine( "paSs.   "+s_strTFPath +" "+s_strTFName+" ,iCountTestcases=="+iCountTestcases);
			return true;
		}
		else
		{
			Console.WriteLine("FAiL!   "+s_strTFPath+" "+s_strTFName+" ,iCountErrors=="+iCountErrors+" , BugNums?: "+s_strActiveBugNums );
			return false;
		}
	}
	public virtual void printerr ( String err )
	{
		Console.WriteLine ("POINTTOBREAK: ("+ s_strTFAbbrev + ") "+ err);
	}
	public virtual void printinfo ( String info )
	{
		Console.WriteLine ("EXTENDEDINFO: ("+ s_strTFAbbrev + ") "+ info);
	}
	public static void Main(String[] args)
	{
		bool bResult = false;
		Co5247ctor_SCS cbA = new Co5247ctor_SCS();
		try {
			bResult = cbA.runTest();
			} catch (Exception exc_main){
			bResult = false;
			Console.WriteLine(s_strTFAbbrev + " : FAiL! Error Err_9999zzz! Uncaught Exception in main(), exc_main=="+exc_main);
		}
		if (!bResult)
		{
			Console.WriteLine ("Path: "+s_strTFName + s_strTFPath);
			Console.WriteLine( " " );
			Console.WriteLine( "FAiL!  "+ s_strTFAbbrev);
			Console.WriteLine( " " );
		}
		if (bResult) Environment.ExitCode = 0; else Environment.ExitCode = 1;
	}
}
