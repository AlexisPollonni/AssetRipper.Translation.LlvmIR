using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_sub_with_borrow_unsigned_long
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<long, long, long, void*, long>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowImEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned long>(unsigned long, unsigned long, unsigned long, unsigned long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type")]
	public unsafe static long Invoke([MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("carry_in")][NativeType("unsigned long")] long Carry_in, [MangledName("carry_out")][NativeType("unsigned long&")] void* Carry_out)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = (Llvm_libc_20_1_2_sub_overflow_unsigned_long.Invoke(A, B, &num) ? 1L : 0L);
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = (Llvm_libc_20_1_2_sub_overflow_unsigned_long.Invoke(num, Carry_in, &num) ? 1L : 0L);
		*unchecked((long*)Carry_out) = num2 | num3;
		long result = num;
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
