using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE12quick_mul_hiERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&) const")]
internal static partial class BigInt_64ul_false_unsigned_long_quick_mul_hi_BigInt_64ul_false_unsigned_long_const_const
{
	public unsafe static long Invoke(BigInt_nx6qdt* @this, BigInt_nx6qdt* other)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		unchecked
		{
			*(long*)(&bigInt_nx6qdt) = -6148914691236517206L;
			BigInt_64ul_false_unsigned_long_BigInt.Invoke(&bigInt_nx6qdt);
			void_multiword_quick_mul_hi_unsigned_long_1ul_cpp_array_unsigned_long_1ul_cpp_array_unsigned_long_1ul_const_cpp_array_unsigned_long_1ul_const.Invoke(&bigInt_nx6qdt.val, &@this->val, &other->val);
			return *(long*)(&bigInt_nx6qdt.val.Data);
		}
	}
}
