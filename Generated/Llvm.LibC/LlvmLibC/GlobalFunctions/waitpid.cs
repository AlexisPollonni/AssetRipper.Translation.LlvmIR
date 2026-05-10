using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class waitpid
{
	public unsafe static int Invoke(int pid, void* wait_status, int options)
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
			*(InlineArray5_Byte*)(&cpp_optional_int_OptionalStorage2) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(internal_wait4impl_int_int_int_rusage.Invoke(pid, wait_status, options, null));
			int result;
			if (!cpp_expected_int_int_has_value_const.Invoke(&cpp_optional_int_OptionalStorage2))
			{
				Errno_operator_int_dntwiy.Invoke(a: *(int*)cpp_expected_int_int_error.Invoke(&cpp_optional_int_OptionalStorage2), @this: libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = *(int*)cpp_expected_int_int_value.Invoke(&cpp_optional_int_OptionalStorage2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_int_OptionalStorage2);
			return result;
		}
	}
}
