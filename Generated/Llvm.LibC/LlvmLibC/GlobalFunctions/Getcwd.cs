using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Getcwd
{
	[MangledName("getcwd")]
	[DemangledName("getcwd")]
	public unsafe static void* Invoke([MangledName("buf")] void* Buf, [MangledName("size")] long Size)
	{
		InlineArray4096_SByte inlineArray4096_SByte = default(InlineArray4096_SByte);
		Cpp_optional_77yu8f cpp_optional_77yu8f = default(Cpp_optional_77yu8f);
		unchecked
		{
			void* result;
			if (Buf == null)
			{
				Llvm_lifetime_start_p0.Invoke(4096L, &inlineArray4096_SByte);
				Llvm_memset_p0_i64.Invoke(&inlineArray4096_SByte, -86, 4096L, isVolatile: false);
				if (!Anonymous_namespace_getcwd_syscall.Invoke(&inlineArray4096_SByte, 4096L))
				{
					result = null;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_77yu8f);
					sbyte* ptr = (sbyte*)(&cpp_optional_77yu8f);
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
					Struct_yx4nca struct_yx4nca = Internal_strdup.Invoke(&inlineArray4096_SByte);
					Cpp_optional_char_OptionalStorage* ptr3 = &cpp_optional_77yu8f.Storage;
					Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
					((Struct_yx4nca*)ptr3)->field_0 = struct_yx4nca2.field_0;
					Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
					((Struct_yx4nca*)ptr3)->field_1 = struct_yx4nca3.field_1;
					if (!Optional_char_ToBoolean.Invoke(&cpp_optional_77yu8f))
					{
						Errno_Assignment.Invoke(Libc_errno.Pointer, 12);
						result = null;
					}
					else
					{
						result = *(void**)Optional_char_Multiply.Invoke(&cpp_optional_77yu8f);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_77yu8f);
				}
				Llvm_lifetime_end_p0.Invoke(4096L, &inlineArray4096_SByte);
			}
			else if (Size == 0L)
			{
				Errno_Assignment.Invoke(Libc_errno.Pointer, 22);
				result = null;
			}
			else
			{
				result = (Anonymous_namespace_getcwd_syscall.Invoke(Buf, Size) ? Buf : null);
			}
			return result;
		}
	}
}
