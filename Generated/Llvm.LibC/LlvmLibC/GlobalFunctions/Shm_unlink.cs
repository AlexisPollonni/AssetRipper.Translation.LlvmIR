using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Shm_unlink
{
	[MangledName("shm_unlink")]
	[DemangledName("shm_unlink")]
	public unsafe static int Invoke([MangledName("name")] void* Name)
	{
		int result = 0;
		Cpp_optional_hnriuf cpp_optional_hnriuf = default(Cpp_optional_hnriuf);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(266L, &cpp_optional_hnriuf);
		Llvm_memset_p0_i64.Invoke(&cpp_optional_hnriuf, -86, 266L, isVolatile: false);
		String_view_Constructor.Invoke(&cpp_string_view, Name);
		unchecked
		{
			Shm_common_translate_name.Invoke(&cpp_optional_hnriuf, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			int num;
			if (Optional_cpp_array_char_265ul_ToBoolean.Invoke(&cpp_optional_hnriuf))
			{
				result = ((delegate*<void*, int>)Unlink.__pointer)(Array_char_265ul_data.Invoke(Optional_cpp_array_char_265ul_PointerDereference.Invoke(&cpp_optional_hnriuf)));
				num = 1;
			}
			else
			{
				num = 0;
			}
			Llvm_lifetime_end_p0.Invoke(266L, &cpp_optional_hnriuf);
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
