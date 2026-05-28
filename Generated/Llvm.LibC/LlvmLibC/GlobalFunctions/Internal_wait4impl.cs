using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_wait4impl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9wait4implEiPiiP6rusage")]
	[DemangledName("__llvm_libc_20_1_2_::internal::wait4impl(int, int*, int, rusage*)")]
	public unsafe static long Invoke([MangledName("pid")][NativeType("int")] int Pid, [MangledName("wait_status")][NativeType("int*")] void* Wait_status, [MangledName("options")][NativeType("int")] int Options, [MangledName("usage")][NativeType("rusage*")] void* Usage)
	{
		Cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage = default(Cpp_optional_int_OptionalStorage);
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int num = Syscall_impl_int_int_int_int_rusage.Invoke(61L, Pid, Wait_status, Options, Usage);
		if (num < 0)
		{
			Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, -num);
			Expected_int_int_Constructor_wj76c9.Invoke(&cpp_optional_int_OptionalStorage, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0);
		}
		else
		{
			Expected_int_int_Constructor_mrm7sc.Invoke(&cpp_optional_int_OptionalStorage, num);
		}
		return *unchecked((long*)(&cpp_optional_int_OptionalStorage));
	}
}
