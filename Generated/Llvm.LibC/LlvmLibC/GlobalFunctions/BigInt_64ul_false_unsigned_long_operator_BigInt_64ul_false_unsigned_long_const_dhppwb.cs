using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEmiEOS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator-(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>&&) const")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_dhppwb
{
	public unsafe static long Invoke(BigInt_nx6qdt* @this, BigInt_nx6qdt* other)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		unchecked
		{
			*(long*)(&bigInt_nx6qdt) = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_nx6qdt, @this, 8L, isVolatile: false);
			BigInt_64ul_false_unsigned_long_sub_overflow_BigInt_64ul_false_unsigned_long_const.Invoke(&bigInt_nx6qdt, other);
			return *(long*)(&bigInt_nx6qdt.val.Data);
		}
	}
}
