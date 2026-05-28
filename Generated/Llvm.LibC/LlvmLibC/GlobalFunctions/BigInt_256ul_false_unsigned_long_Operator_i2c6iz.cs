using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Operator_i2c6iz
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmErSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator>>=(unsigned long)")]
	[CleanName("BigInt_256ul_false_unsigned_long_Operator")]
	public unsafe static BigInt_x9dsed* Invoke([MangledName("this")] BigInt_x9dsed* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_jgy3xh cpp_array_jgy3xh = default(Cpp_array_jgy3xh);
		Cpp_array_jgy3xh cpp_array_jgy3xh2 = default(Cpp_array_jgy3xh);
		Llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh);
		Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_jgy3xh2, &This->Val, 32L, isVolatile: false);
		Multiword_shift_multiword_Direction_1_false_unsigned_long_4ul.Invoke(&cpp_array_jgy3xh, &cpp_array_jgy3xh2, S);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &cpp_array_jgy3xh, 32L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh);
		return This;
	}
}
