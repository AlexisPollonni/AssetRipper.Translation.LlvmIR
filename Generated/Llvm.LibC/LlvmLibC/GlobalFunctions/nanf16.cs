using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class nanf16
{
	public unsafe static Half Invoke(void* arg)
	{
		StrToNumResult_stcih6 strToNumResult_stcih = default(StrToNumResult_stcih6);
		llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_stcih);
		unchecked
		{
			*(Half*)(&strToNumResult_stcih) = default(Half);
			sbyte* ptr = (sbyte*)(&strToNumResult_stcih) + 2;
			*ptr = -86;
			ptr[1] = -86;
			((int*)(&strToNumResult_stcih))[1] = -1431655766;
			((long*)(&strToNumResult_stcih))[1] = -6148914691236517206L;
			Struct_fiz2nb struct_fiz2nb = internal_strtonan_Float16.Invoke(arg);
			StrToNumResult_stcih6* num = &strToNumResult_stcih;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&strToNumResult_stcih) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			if (StrToNumResult_Float16_has_error.Invoke(&strToNumResult_stcih))
			{
				Errno_Assignment.Invoke(a: strToNumResult_stcih.error, @this: libc_errno.Pointer);
			}
			Half value = strToNumResult_stcih.value;
			llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_stcih);
			return value;
		}
	}
}
