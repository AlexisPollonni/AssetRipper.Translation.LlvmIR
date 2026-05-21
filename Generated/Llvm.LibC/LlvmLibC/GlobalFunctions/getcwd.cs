using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class getcwd
{
	public unsafe static void* Invoke(void* buf, long size)
	{
		InlineArray4096_SByte inlineArray4096_SByte = default(InlineArray4096_SByte);
		cpp_optional_77yu8f cpp_optional_77yu8f2 = default(cpp_optional_77yu8f);
		unchecked
		{
			void* result;
			if (buf == null)
			{
				llvm_lifetime_start_p0.Invoke(4096L, &inlineArray4096_SByte);
				llvm_memset_p0_i64.Invoke(&inlineArray4096_SByte, -86, 4096L, isVolatile: false);
				if (!anonymous_namespace_getcwd_syscall.Invoke(&inlineArray4096_SByte, 4096L))
				{
					result = null;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_77yu8f2);
					sbyte* ptr = (sbyte*)(&cpp_optional_77yu8f2);
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
					Struct_yx4nca struct_yx4nca = internal_strdup.Invoke(&inlineArray4096_SByte);
					cpp_optional_char_OptionalStorage* ptr3 = &cpp_optional_77yu8f2.storage;
					Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
					((Struct_yx4nca*)ptr3)->field_0 = struct_yx4nca2.field_0;
					Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
					((Struct_yx4nca*)ptr3)->field_1 = struct_yx4nca3.field_1;
					if (!optional_char_ToBoolean.Invoke(&cpp_optional_77yu8f2))
					{
						Errno_Assignment.Invoke(libc_errno.Pointer, 12);
						result = null;
					}
					else
					{
						result = *(void**)optional_char_Multiply.Invoke(&cpp_optional_77yu8f2);
					}
					llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_77yu8f2);
				}
				llvm_lifetime_end_p0.Invoke(4096L, &inlineArray4096_SByte);
			}
			else if (size == 0L)
			{
				Errno_Assignment.Invoke(libc_errno.Pointer, 22);
				result = null;
			}
			else
			{
				result = (anonymous_namespace_getcwd_syscall.Invoke(buf, size) ? buf : null);
			}
			return result;
		}
	}
}
