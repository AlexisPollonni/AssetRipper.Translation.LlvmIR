using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Vasprintf
{
	[MangledName("vasprintf")]
	[DemangledName("vasprintf")]
	public unsafe static int Invoke([MangledName("ret")] void* Ret, [MangledName("format")] void* Format, [MangledName("vlist")] Va_list_tag* Vlist)
	{
		Llvm_libc_20_1_2_internal_ArgList llvm_libc_20_1_2_internal_ArgList = default(Llvm_libc_20_1_2_internal_ArgList);
		Llvm_libc_20_1_2_internal_ArgList llvm_libc_20_1_2_internal_ArgList2 = default(Llvm_libc_20_1_2_internal_ArgList);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_internal_ArgList);
		unchecked
		{
			Va_list_tag* ptr = (Va_list_tag*)(&llvm_libc_20_1_2_internal_ArgList);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			ArgList_Constructor_7zbjxz.Invoke(&llvm_libc_20_1_2_internal_ArgList, Vlist);
			ArgList_Constructor_z4jw9r.Invoke(&llvm_libc_20_1_2_internal_ArgList2, &llvm_libc_20_1_2_internal_ArgList);
			int result = Printf_core_vasprintf_internal.Invoke(Ret, Format, &llvm_libc_20_1_2_internal_ArgList2);
			ArgList_Destructor.Invoke(&llvm_libc_20_1_2_internal_ArgList2);
			ArgList_Destructor.Invoke(&llvm_libc_20_1_2_internal_ArgList);
			Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_internal_ArgList);
			return result;
		}
	}
}
