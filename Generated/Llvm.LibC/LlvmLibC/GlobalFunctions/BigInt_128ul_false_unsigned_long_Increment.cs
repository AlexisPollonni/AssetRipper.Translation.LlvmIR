using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_128ul_false_unsigned_long_Increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEppEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator++()")]
	public unsafe static Anon_izyfb7* Invoke([MangledName("this")] Anon_izyfb7* This)
	{
		BigInt_128ul_false_unsigned_long_increment.Invoke(This);
		return This;
	}
}
internal static partial class BigInt_128ul_false_unsigned_long_increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmE9incrementEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::increment()")]
	public unsafe static void Invoke([MangledName("this")] Anon_izyfb7* This)
	{
		Cpp_array_rpgxvv cpp_array_rpgxvv = default(Cpp_array_rpgxvv);
		unchecked
		{
			Cpp_array_i3937k* val = &((BigInt_qdkjbh*)This)->Val;
			Llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv);
			*(long*)(&cpp_array_rpgxvv.Data) = 1L;
			Multiword_add_with_carry_unsigned_long_2ul_1ul.Invoke(val, &cpp_array_rpgxvv);
			Llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv);
		}
	}
}
