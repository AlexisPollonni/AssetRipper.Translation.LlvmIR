using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator>>(unsigned long) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_BigInt_q8g275* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_BigInt_q8g275* This, [MangledName("s")] long S)
	{
		Llvm_libc_20_1_2_cpp_array_anzbtp llvm_libc_20_1_2_cpp_array_anzbtp = default(Llvm_libc_20_1_2_cpp_array_anzbtp);
		Llvm_libc_20_1_2_cpp_array_anzbtp llvm_libc_20_1_2_cpp_array_anzbtp2 = default(Llvm_libc_20_1_2_cpp_array_anzbtp);
		Llvm_lifetime_start_p0.Invoke(2064L, &llvm_libc_20_1_2_cpp_array_anzbtp);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_anzbtp2, &This->Val, 2064L, isVolatile: false);
		Multiword_shift_multiword_Direction_1_false_unsigned_long_258ul.Invoke(&llvm_libc_20_1_2_cpp_array_anzbtp, &llvm_libc_20_1_2_cpp_array_anzbtp2, S);
		BigInt_16512ul_false_unsigned_long_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_cpp_array_anzbtp);
		Llvm_lifetime_end_p0.Invoke(2064L, &llvm_libc_20_1_2_cpp_array_anzbtp);
	}
}
