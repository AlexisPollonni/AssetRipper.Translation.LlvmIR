using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nanf16
{
	[MangledName("nanf16")]
	[DemangledName("nanf16")]
	public unsafe static Half Invoke([MangledName("arg")] void* Arg)
	{
		Llvm_libc_20_1_2_StrToNumResult_stcih6 llvm_libc_20_1_2_StrToNumResult_stcih = default(Llvm_libc_20_1_2_StrToNumResult_stcih6);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_stcih);
		unchecked
		{
			*(Half*)(&llvm_libc_20_1_2_StrToNumResult_stcih) = default(Half);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_stcih) + 2;
			*ptr = -86;
			ptr[1] = -86;
			((int*)(&llvm_libc_20_1_2_StrToNumResult_stcih))[1] = -1431655766;
			((long*)(&llvm_libc_20_1_2_StrToNumResult_stcih))[1] = -6148914691236517206L;
			Struct_fiz2nb struct_fiz2nb = Internal_strtonan_Float16.Invoke(Arg);
			Llvm_libc_20_1_2_StrToNumResult_stcih6* num = &llvm_libc_20_1_2_StrToNumResult_stcih;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_stcih) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			if (StrToNumResult_Float16_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_stcih))
			{
				Errno_Assignment.Invoke(A: llvm_libc_20_1_2_StrToNumResult_stcih.Error, This: Llvm_libc_20_1_2_libc_errno.Pointer);
			}
			Half value = llvm_libc_20_1_2_StrToNumResult_stcih.Value;
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_stcih);
			return value;
		}
	}
}
