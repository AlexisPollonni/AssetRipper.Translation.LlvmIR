using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9lseekimplEili")]
[DemangledName("__llvm_libc_20_1_2_::internal::lseekimpl(int, long, int)")]
internal static partial class internal_lseekimpl_int_long_int
{
	public unsafe static Struct_8myw6y Invoke(int fd, long offset, int whence)
	{
		cpp_expected cpp_expected2 = default(cpp_expected);
		long num = 0L;
		int num2 = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = int_syscall_impl_int_int_long_int_long_int_long_int.Invoke(8L, fd, offset, whence);
		num = num2;
		if (num2 < 0)
		{
			cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, -num2);
			cpp_expected_long_int_expected_cpp_unexpected_int.Invoke(&cpp_expected2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
		}
		else
		{
			cpp_expected_long_int_expected_long.Invoke(&cpp_expected2, num);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return *unchecked((Struct_8myw6y*)(&cpp_expected2));
	}
}
