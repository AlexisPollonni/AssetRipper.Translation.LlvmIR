using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16512ul_false_unsigned_long_Operator
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::operator<<=(unsigned long)")]
	public unsafe static BigInt_q8g275* Invoke([MangledName("this")] BigInt_q8g275* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_anzbtp cpp_array_anzbtp = default(Cpp_array_anzbtp);
		Cpp_array_anzbtp cpp_array_anzbtp2 = default(Cpp_array_anzbtp);
		Llvm_lifetime_start_p0.Invoke(2064L, &cpp_array_anzbtp);
		Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_anzbtp2, &This->Val, 2064L, isVolatile: false);
		Multiword_shift_multiword_Direction_0_false_unsigned_long_258ul.Invoke(&cpp_array_anzbtp, &cpp_array_anzbtp2, S);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &cpp_array_anzbtp, 2064L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(2064L, &cpp_array_anzbtp);
		return This;
	}
}
