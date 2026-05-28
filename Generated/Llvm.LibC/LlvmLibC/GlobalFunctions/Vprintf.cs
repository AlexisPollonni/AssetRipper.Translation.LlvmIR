using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Vprintf
{
	[MangledName("vprintf")]
	[DemangledName("vprintf")]
	public unsafe static int Invoke([MangledName("format")] void* Format, [MangledName("vlist")] Va_list_tag* Vlist)
	{
		Internal_ArgList internal_ArgList = default(Internal_ArgList);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList);
		unchecked
		{
			Va_list_tag* ptr = (Va_list_tag*)(&internal_ArgList);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&internal_ArgList, Vlist);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Printf_core_vfprintf_internal.Invoke(Stdout.Value, Format, &internal_ArgList);
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			ArgList_Destructor.Invoke(&internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList);
			return result;
		}
	}
}
