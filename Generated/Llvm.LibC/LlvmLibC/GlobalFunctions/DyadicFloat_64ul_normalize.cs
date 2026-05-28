using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_64ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm64EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul>::normalize()")]
	public unsafe static Fputil_DyadicFloat_syracv* Invoke([MangledName("this")] Fputil_DyadicFloat_syracv* This)
	{
		int num = 0;
		if (!BigInt_64ul_false_unsigned_long_is_zero.Invoke(&This->Mantissa))
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Cpp_countl_zero_BigInt_64ul_false_unsigned_long.Invoke(&This->Mantissa);
			This->Exponent -= num;
			BigInt_64ul_false_unsigned_long_Operator_pq2pm2.Invoke(&This->Mantissa, num);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return This;
	}
}
