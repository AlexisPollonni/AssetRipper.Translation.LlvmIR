using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class munlock
{
	public unsafe static int Invoke(void* addr, long len)
	{
		long num = 0L;
		void* ptr = addr;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = syscall_impl_long_long_long.Invoke(150L, cpp_enable_if_sizeof_long_sizeof_void_const_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_void_const_value_long_type_cpp_bit_cast_long_void_const_void_const_const.Invoke(&ptr), len);
		unchecked
		{
			int result;
			if (num < 0L)
			{
				Errno_operator_int_dntwiy.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = -1;
			}
			else
			{
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
