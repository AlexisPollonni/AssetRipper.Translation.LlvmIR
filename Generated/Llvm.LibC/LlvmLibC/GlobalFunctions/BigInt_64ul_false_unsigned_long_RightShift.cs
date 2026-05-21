using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator>>(unsigned long) const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_BigInt_555ggs* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_libc_20_1_2_cpp_array_rpgxvv llvm_libc_20_1_2_cpp_array_rpgxvv = default(Llvm_libc_20_1_2_cpp_array_rpgxvv);
		Llvm_libc_20_1_2_cpp_array_rpgxvv llvm_libc_20_1_2_cpp_array_rpgxvv2 = default(Llvm_libc_20_1_2_cpp_array_rpgxvv);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_array_rpgxvv);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_rpgxvv2, &This->Val, 8L, isVolatile: false);
		unchecked
		{
			long data = Multiword_shift_multiword_Direction_1_false_unsigned_long_1ul.Invoke(*(long*)(&llvm_libc_20_1_2_cpp_array_rpgxvv2.Data), S);
			*(long*)(&llvm_libc_20_1_2_cpp_array_rpgxvv.Data) = data;
			BigInt_64ul_false_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, &llvm_libc_20_1_2_cpp_array_rpgxvv);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_array_rpgxvv);
			return *(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data);
		}
	}
}
