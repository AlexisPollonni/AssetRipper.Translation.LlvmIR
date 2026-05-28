using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_lseekimpl
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9lseekimplEili")]
	[DemangledName("__llvm_libc_20_1_2_::internal::lseekimpl(int, long, int)")]
	public unsafe static Struct_8myw6y Invoke([MangledName("fd")][NativeType("int")] int Fd, [MangledName("offset")][NativeType("long")] long Offset, [MangledName("whence")][NativeType("int")] int Whence)
	{
		Cpp_expected cpp_expected = default(Cpp_expected);
		long exp = 0L;
		int num = 0;
		Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt = default(Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		Llvm_lifetime_start_p0.Invoke(8L, &exp);
		exp = -6148914691236517206L;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Syscall_impl_int_int_long_int.Invoke(8L, Fd, Offset, Whence);
		exp = num;
		if (num < 0)
		{
			Unexpected_int_Constructor.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt, -num);
			Expected_long_int_Constructor.Invoke(&cpp_expected, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt.field_0);
		}
		else
		{
			Expected_long_int_Constructor.Invoke(&cpp_expected, exp);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &exp);
		return *unchecked((Struct_8myw6y*)(&cpp_expected));
	}
}
