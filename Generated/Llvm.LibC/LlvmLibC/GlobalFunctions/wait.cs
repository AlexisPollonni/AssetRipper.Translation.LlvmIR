using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class wait
{
	public unsafe static int Invoke(void* wait_status)
	{
		cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage2 = default(cpp_optional_int_OptionalStorage);
		llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_int_OptionalStorage2);
		unchecked
		{
			*(int*)(&cpp_optional_int_OptionalStorage2) = -1431655766;
			((sbyte*)(&cpp_optional_int_OptionalStorage2))[4] = -86;
			sbyte* ptr = (sbyte*)(&cpp_optional_int_OptionalStorage2) + 5;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			*(InlineArray5_Byte*)(&cpp_optional_int_OptionalStorage2) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(internal_wait4impl.Invoke(-1, wait_status, 0, null));
			int result;
			if (!expected_int_int_has_value.Invoke(&cpp_optional_int_OptionalStorage2))
			{
				Errno_Assignment.Invoke(a: *(int*)expected_int_int_error.Invoke(&cpp_optional_int_OptionalStorage2), @this: libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = *(int*)expected_int_int_value.Invoke(&cpp_optional_int_OptionalStorage2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_int_OptionalStorage2);
			return result;
		}
	}
}
