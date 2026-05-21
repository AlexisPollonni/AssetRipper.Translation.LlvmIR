using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strdup
{
	[MangledName("strdup")]
	[DemangledName("strdup")]
	public unsafe static void* Invoke([MangledName("src")] void* Src)
	{
		Llvm_libc_20_1_2_cpp_optional_77yu8f llvm_libc_20_1_2_cpp_optional_77yu8f = default(Llvm_libc_20_1_2_cpp_optional_77yu8f);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_77yu8f);
			*(IntPtr*)ptr = unchecked((nint)(-6148914691236517206L));
			ptr[8] = -86;
			sbyte* ptr2 = ptr + 9;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			ptr2[4] = -86;
			ptr2[5] = -86;
			ptr2[6] = -86;
			Struct_yx4nca struct_yx4nca = Internal_strdup.Invoke(Src);
			Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage* ptr3 = &llvm_libc_20_1_2_cpp_optional_77yu8f.Storage;
			Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
			((Struct_yx4nca*)ptr3)->field_0 = struct_yx4nca2.field_0;
			Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
			((Struct_yx4nca*)ptr3)->field_1 = struct_yx4nca3.field_1;
			void* result;
			if (Optional_char_ToBoolean.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f))
			{
				result = *(void**)Optional_char_Multiply.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f);
			}
			else
			{
				if (Src != null)
				{
					Errno_Assignment.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer, 12);
				}
				result = null;
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f);
			return result;
		}
	}
}
