using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_320ul_false_unsigned_long_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm320ELb0EmErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::operator>>(unsigned long) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_BigInt_76gxx6* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_BigInt_76gxx6* This, [MangledName("s")] long S)
	{
		Llvm_libc_20_1_2_cpp_array_msasyg llvm_libc_20_1_2_cpp_array_msasyg = default(Llvm_libc_20_1_2_cpp_array_msasyg);
		Llvm_libc_20_1_2_cpp_array_msasyg llvm_libc_20_1_2_cpp_array_msasyg2 = default(Llvm_libc_20_1_2_cpp_array_msasyg);
		Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_cpp_array_msasyg);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_msasyg2, &This->Val, 40L, isVolatile: false);
		Multiword_shift_multiword_Direction_1_false_unsigned_long_5ul.Invoke(&llvm_libc_20_1_2_cpp_array_msasyg, &llvm_libc_20_1_2_cpp_array_msasyg2, S);
		BigInt_320ul_false_unsigned_long_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_cpp_array_msasyg);
		Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_cpp_array_msasyg);
	}
}
