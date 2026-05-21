using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sub_with_borrow_unsigned_int
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<int, int, int, void*, int>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned int>(unsigned int, unsigned int, unsigned int, unsigned int&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, unsigned int>::type")]
	public unsafe static int Invoke([NativeType("unsigned int")] int a, [NativeType("unsigned int")] int b, [NativeType("unsigned int")] int carry_in, [NativeType("unsigned int&")] void* carry_out)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = (sub_overflow_unsigned_int.Invoke(a, b, &num) ? 1 : 0);
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = (sub_overflow_unsigned_int.Invoke(num, carry_in, &num) ? 1 : 0);
		*unchecked((int*)carry_out) = num2 | num3;
		int result = num;
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
