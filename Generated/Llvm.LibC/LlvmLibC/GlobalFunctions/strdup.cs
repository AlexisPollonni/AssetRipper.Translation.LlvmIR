using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strdup
{
	public unsafe static void* Invoke(void* src)
	{
		cpp_optional_e5s7qx cpp_optional_e5s7qx2 = default(cpp_optional_e5s7qx);
		llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_e5s7qx2);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_optional_e5s7qx2);
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
			Struct_yx4nca struct_yx4nca = internal_strdup_char_const.Invoke(src);
			cpp_optional_char_OptionalStorage* ptr3 = &cpp_optional_e5s7qx2.storage;
			Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
			((Struct_yx4nca*)ptr3)->field_0 = struct_yx4nca2.field_0;
			Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
			((Struct_yx4nca*)ptr3)->field_1 = struct_yx4nca3.field_1;
			void* result;
			if (cpp_optional_char_operator_bool_const.Invoke(&cpp_optional_e5s7qx2))
			{
				result = *(void**)cpp_optional_char_operator.Invoke(&cpp_optional_e5s7qx2);
			}
			else
			{
				if (src != null)
				{
					Errno_operator_int_dntwiy.Invoke(libc_errno.Pointer, 12);
				}
				result = null;
			}
			llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_e5s7qx2);
			return result;
		}
	}
}
