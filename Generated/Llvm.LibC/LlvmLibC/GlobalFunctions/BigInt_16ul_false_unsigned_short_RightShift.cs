using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_16ul_false_unsigned_short_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator>>(unsigned long) const")]
	public unsafe static short Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_ys7s55* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Llvm_libc_20_1_2_BigInt_ys7s55 llvm_libc_20_1_2_BigInt_ys7s = default(Llvm_libc_20_1_2_BigInt_ys7s55);
		Llvm_libc_20_1_2_cpp_array_knh6hw llvm_libc_20_1_2_cpp_array_knh6hw = default(Llvm_libc_20_1_2_cpp_array_knh6hw);
		Llvm_libc_20_1_2_cpp_array_knh6hw llvm_libc_20_1_2_cpp_array_knh6hw2 = default(Llvm_libc_20_1_2_cpp_array_knh6hw);
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_cpp_array_knh6hw);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_knh6hw2, &This->Val, 2L, isVolatile: false);
		unchecked
		{
			short data = Multiword_shift_multiword_Direction_1_false_unsigned_short_1ul.Invoke(*(short*)(&llvm_libc_20_1_2_cpp_array_knh6hw2.Data), S);
			*(short*)(&llvm_libc_20_1_2_cpp_array_knh6hw.Data) = data;
			BigInt_16ul_false_unsigned_short_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_ys7s, &llvm_libc_20_1_2_cpp_array_knh6hw);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_cpp_array_knh6hw);
			return *(short*)(&llvm_libc_20_1_2_BigInt_ys7s.Val.Data);
		}
	}
}
