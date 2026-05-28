using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_Operator
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator<<=(unsigned long)")]
	public unsafe static BigInt_ys7s55* Invoke([MangledName("this")] BigInt_ys7s55* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_knh6hw cpp_array_knh6hw = default(Cpp_array_knh6hw);
		Cpp_array_knh6hw cpp_array_knh6hw2 = default(Cpp_array_knh6hw);
		Llvm_lifetime_start_p0.Invoke(2L, &cpp_array_knh6hw);
		Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_knh6hw2, &This->Val, 2L, isVolatile: false);
		unchecked
		{
			short data = Multiword_shift_multiword_Direction_0_false_unsigned_short_1ul.Invoke(*(short*)(&cpp_array_knh6hw2.Data), S);
			*(short*)(&cpp_array_knh6hw.Data) = data;
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &cpp_array_knh6hw, 2L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(2L, &cpp_array_knh6hw);
			return This;
		}
	}
}
