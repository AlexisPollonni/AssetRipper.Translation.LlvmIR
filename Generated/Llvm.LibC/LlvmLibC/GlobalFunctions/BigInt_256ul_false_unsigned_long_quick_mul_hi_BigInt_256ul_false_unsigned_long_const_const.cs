using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12quick_mul_hiERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::quick_mul_hi(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&) const")]
internal static partial class BigInt_256ul_false_unsigned_long_quick_mul_hi_BigInt_256ul_false_unsigned_long_const_const
{
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, void* @this, void* other)
	{
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((long*)agg_result)[1] = -6148914691236517206L;
			((long*)agg_result)[2] = -6148914691236517206L;
			((long*)agg_result)[3] = -6148914691236517206L;
			BigInt_256ul_false_unsigned_long_BigInt.Invoke(agg_result);
			void_multiword_quick_mul_hi_unsigned_long_4ul_cpp_array_unsigned_long_4ul_cpp_array_unsigned_long_4ul_const_cpp_array_unsigned_long_4ul_const.Invoke(&agg_result->val, &((BigInt_x9dsed*)@this)->val, &((BigInt_x9dsed*)other)->val);
		}
	}
}
