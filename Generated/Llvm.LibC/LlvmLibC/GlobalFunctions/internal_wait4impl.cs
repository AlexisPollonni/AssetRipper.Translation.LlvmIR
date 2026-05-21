using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_wait4impl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9wait4implEiPiiP6rusage")]
	[DemangledName("__llvm_libc_20_1_2_::internal::wait4impl(int, int*, int, rusage*)")]
	public unsafe static long Invoke([NativeType("int")] int pid, [NativeType("int*")] void* wait_status, [NativeType("int")] int options, [NativeType("rusage*")] void* usage)
	{
		cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage2 = default(cpp_optional_int_OptionalStorage);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int num = syscall_impl_int_int_int_int_rusage.Invoke(61L, pid, wait_status, options, usage);
		if (num < 0)
		{
			unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, -num);
			expected_int_int_Constructor_wj76c9.Invoke(&cpp_optional_int_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
		}
		else
		{
			expected_int_int_Constructor_mrm7sc.Invoke(&cpp_optional_int_OptionalStorage2, num);
		}
		return *unchecked((long*)(&cpp_optional_int_OptionalStorage2));
	}
}
