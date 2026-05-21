using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Operator_4fggky
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmErSEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator>>=(unsigned long)")]
	[CleanName("BigInt_64ul_false_unsigned_long_Operator")]
	public unsafe static BigInt_555ggs* Invoke(BigInt_555ggs* @this, [NativeType("unsigned long")] long s)
	{
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_rpgxvv cpp_array_rpgxvv3 = default(cpp_array_rpgxvv);
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_rpgxvv3, &@this->val, 8L, isVolatile: false);
		unchecked
		{
			long data = multiword_shift_multiword_Direction_1_false_unsigned_long_1ul.Invoke(*(long*)(&cpp_array_rpgxvv3.Data), s);
			*(long*)(&cpp_array_rpgxvv2.Data) = data;
			llvm_memcpy_p0_p0_i64.Invoke(&@this->val, &cpp_array_rpgxvv2, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
			return @this;
		}
	}
}
