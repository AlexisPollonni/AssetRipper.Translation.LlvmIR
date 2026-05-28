using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sub_with_borrow_unsigned_int
{
	public unsafe static readonly void* __pointer = (delegate*<int, int, int, void*, int>)(&Invoke);

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned int>(unsigned int, unsigned int, unsigned int, unsigned int&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type")]
	public unsafe static int Invoke([MangledName("a")][NativeType("unsigned int")] int A, [MangledName("b")][NativeType("unsigned int")] int B, [MangledName("carry_in")][NativeType("unsigned int")] int Carry_in, [MangledName("carry_out")][NativeType("unsigned int&")] void* Carry_out)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (Sub_overflow_unsigned_int.Invoke(A, B, &num) ? 1 : 0);
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = (Sub_overflow_unsigned_int.Invoke(num, Carry_in, &num) ? 1 : 0);
		*unchecked((int*)Carry_out) = num2 | num3;
		int result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
