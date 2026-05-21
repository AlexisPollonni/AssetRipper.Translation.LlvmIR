using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Operator_d84zyi
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator<<=(unsigned long)")]
	[CleanName("BigInt_256ul_false_unsigned_long_Operator")]
	public unsafe static Llvm_libc_20_1_2_BigInt_x9dsed* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Llvm_libc_20_1_2_cpp_array_jgy3xh llvm_libc_20_1_2_cpp_array_jgy3xh = default(Llvm_libc_20_1_2_cpp_array_jgy3xh);
		Llvm_libc_20_1_2_cpp_array_jgy3xh llvm_libc_20_1_2_cpp_array_jgy3xh2 = default(Llvm_libc_20_1_2_cpp_array_jgy3xh);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_jgy3xh);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh2, &This->Val, 32L, isVolatile: false);
		Multiword_shift_multiword_Direction_0_false_unsigned_long_4ul.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh, &llvm_libc_20_1_2_cpp_array_jgy3xh2, S);
		Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &llvm_libc_20_1_2_cpp_array_jgy3xh, 32L, isVolatile: false);
		Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_jgy3xh);
		return This;
	}
}
