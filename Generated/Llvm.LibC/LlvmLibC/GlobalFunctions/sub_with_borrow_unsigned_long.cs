using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sub_with_borrow_unsigned_long
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<long, long, long, void*, long>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_15sub_with_borrowImEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_S3_S3_RS3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type __llvm_libc_20_1_2_::sub_with_borrow<unsigned long>(unsigned long, unsigned long, unsigned long, unsigned long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type")]
	public unsafe static long Invoke([NativeType("unsigned long")] long a, [NativeType("unsigned long")] long b, [NativeType("unsigned long")] long carry_in, [NativeType("unsigned long&")] void* carry_out)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = (sub_overflow_unsigned_long.Invoke(a, b, &num) ? 1L : 0L);
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = (sub_overflow_unsigned_long.Invoke(num, carry_in, &num) ? 1L : 0L);
		*unchecked((long*)carry_out) = num2 | num3;
		long result = num;
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
	}
}
