using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Operator_dpx3t5
{
	[MangledName("_ZN19__llvm_libc_20_1_2_oRERNS_6BigIntILm256ELb0EmEERKS1_")]
	[DemangledName("__llvm_libc_20_1_2_::operator|=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("Operator")]
	public unsafe static void Invoke([MangledName("agg.result")] BigInt_x9dsed* agg_result, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>&")] BigInt_x9dsed* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* rhs)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_256ul_false_unsigned_long_Index_g5vf7y.Invoke(rhs, num);
				*(long*)BigInt_256ul_false_unsigned_long_Index_mutfrx.Invoke(lhs, num) |= num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(agg_result, lhs, 32L, isVolatile: false);
		}
	}
}
