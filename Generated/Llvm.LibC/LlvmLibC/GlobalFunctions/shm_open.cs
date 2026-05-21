using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class shm_open
{
	public unsafe static int Invoke(void* name, int oflags, int mode)
	{
		int result = 0;
		cpp_optional_hnriuf cpp_optional_hnriuf2 = default(cpp_optional_hnriuf);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(266L, &cpp_optional_hnriuf2);
		llvm_memset_p0_i64.Invoke(&cpp_optional_hnriuf2, -86, 266L, isVolatile: false);
		string_view_Constructor.Invoke(&cpp_string_view2, name);
		unchecked
		{
			shm_common_translate_name.Invoke(&cpp_optional_hnriuf2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			int num;
			if (optional_cpp_array_char_265ul_ToBoolean.Invoke(&cpp_optional_hnriuf2))
			{
				result = ((delegate*<void*, int, int>)open.__pointer)(array_char_265ul_data.Invoke(optional_cpp_array_char_265ul_PointerDereference.Invoke(&cpp_optional_hnriuf2)), oflags | 0xA0800);
				num = 1;
			}
			else
			{
				num = 0;
			}
			llvm_lifetime_end_p0.Invoke(266L, &cpp_optional_hnriuf2);
			switch (num)
			{
			case 0:
				result = -1;
				goto case 1;
			case 1:
				return result;
			default:
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
	}
}
