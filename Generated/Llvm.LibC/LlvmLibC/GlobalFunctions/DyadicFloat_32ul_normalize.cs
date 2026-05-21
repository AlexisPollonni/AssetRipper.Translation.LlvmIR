using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_32ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm32EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<32ul>::normalize()")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_32ul_false_unsigned_int_is_zero.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = Cpp_countl_zero_BigInt_32ul_false_unsigned_int.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa);
				checked
				{
					unchecked((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Exponent -= num;
				}
				BigInt_32ul_false_unsigned_int_Operator.Invoke(&((Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs*)This)->Mantissa, num);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return This;
		}
	}
}
