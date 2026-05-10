using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9wait4implEiPiiP6rusage")]
[DemangledName("__llvm_libc_20_1_2_::internal::wait4impl(int, int*, int, rusage*)")]
internal static partial class internal_wait4impl_int_int_int_rusage
{
	public unsafe static long Invoke(int pid, void* wait_status, int options, void* usage)
	{
		cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage2 = default(cpp_optional_int_OptionalStorage);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int num = int_syscall_impl_int_int_int_int_rusage_long_int_int_int_rusage.Invoke(61L, pid, wait_status, options, usage);
		if (num < 0)
		{
			cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, -num);
			cpp_expected_int_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_int_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
		}
		else
		{
			cpp_expected_int_int_expected_int.Invoke(&cpp_optional_int_OptionalStorage2, num);
		}
		return *unchecked((long*)(&cpp_optional_int_OptionalStorage2));
	}
}
