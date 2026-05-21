using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_RightShift
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmErsEm")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator>>(unsigned long) const")]
	public unsafe static long Invoke(BigInt_555ggs* @this, [NativeType("unsigned long")] long s)
	{
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_rpgxvv cpp_array_rpgxvv3 = default(cpp_array_rpgxvv);
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_rpgxvv3, &@this->val, 8L, isVolatile: false);
		unchecked
		{
			long data = multiword_shift_multiword_Direction_1_false_unsigned_long_1ul.Invoke(*(long*)(&cpp_array_rpgxvv3.Data), s);
			*(long*)(&cpp_array_rpgxvv2.Data) = data;
			BigInt_64ul_false_unsigned_long_Constructor.Invoke(&bigInt_555ggs, &cpp_array_rpgxvv2);
			llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
			return *(long*)(&bigInt_555ggs.val.Data);
		}
	}
}
