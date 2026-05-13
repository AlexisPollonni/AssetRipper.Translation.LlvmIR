using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm192ELb0EmEC2ILm3EEERAT__Km")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long>::BigInt<3ul>(unsigned long const (&) [3ul])")]
internal static partial class BigInt_192ul_false_unsigned_long_BigInt_3ul_unsigned_long_const_3ul
{
	public unsafe static void Invoke(BigInt_ghrwnp* @this, void* nums)
	{
		long num = 0L;
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 24L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				long num2 = ((long*)nums)[num];
				*(long*)cpp_array_unsigned_long_3ul_operator_unsigned_long.Invoke(&@this->val, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
