using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_lseekimpl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9lseekimplEili")]
	[DemangledName("__llvm_libc_20_1_2_::internal::lseekimpl(int, long, int)")]
	public unsafe static Struct_8myw6y Invoke([NativeType("int")] int fd, [NativeType("long")] long offset, [NativeType("int")] int whence)
	{
		cpp_expected cpp_expected2 = default(cpp_expected);
		long num = 0L;
		int num2 = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = syscall_impl_int_int_long_int.Invoke(8L, fd, offset, whence);
		num = num2;
		if (num2 < 0)
		{
			unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, -num2);
			expected_long_int_Constructor.Invoke(&cpp_expected2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
		}
		else
		{
			expected_long_int_Constructor.Invoke(&cpp_expected2, num);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return *unchecked((Struct_8myw6y*)(&cpp_expected2));
	}
}
