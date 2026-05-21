using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_256ul_false_unsigned_long_Increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEppEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator++()")]
	public unsafe static Llvm_libc_20_1_2_BigInt_x9dsed* Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This)
	{
		BigInt_256ul_false_unsigned_long_increment.Invoke(This);
		return This;
	}
}
internal static partial class BigInt_256ul_false_unsigned_long_increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE9incrementEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::increment()")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_x9dsed* This)
	{
		Llvm_libc_20_1_2_cpp_array_rpgxvv llvm_libc_20_1_2_cpp_array_rpgxvv = default(Llvm_libc_20_1_2_cpp_array_rpgxvv);
		Llvm_libc_20_1_2_cpp_array_jgy3xh* val = &This->Val;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_array_rpgxvv);
		*unchecked((long*)(&llvm_libc_20_1_2_cpp_array_rpgxvv.Data)) = 1L;
		Multiword_add_with_carry_unsigned_long_4ul_1ul.Invoke(val, &llvm_libc_20_1_2_cpp_array_rpgxvv);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_array_rpgxvv);
	}
}
