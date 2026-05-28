using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Operator_pq2pm2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmElSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator<<=(unsigned long)")]
	[CleanName("BigInt_64ul_false_unsigned_long_Operator")]
	public unsafe static BigInt_555ggs* Invoke([MangledName("this")] BigInt_555ggs* This, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		Cpp_array_rpgxvv cpp_array_rpgxvv = default(Cpp_array_rpgxvv);
		Cpp_array_rpgxvv cpp_array_rpgxvv2 = default(Cpp_array_rpgxvv);
		Llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv);
		Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_rpgxvv2, &This->Val, 8L, isVolatile: false);
		unchecked
		{
			long data = Multiword_shift_multiword_Direction_0_false_unsigned_long_1ul.Invoke(*(long*)(&cpp_array_rpgxvv2.Data), S);
			*(long*)(&cpp_array_rpgxvv.Data) = data;
			Llvm_memcpy_p0_p0_i64.Invoke(&This->Val, &cpp_array_rpgxvv, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv);
			return This;
		}
	}
}
