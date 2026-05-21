using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class DyadicFloat_128ul_normalize
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11DyadicFloatILm128EE9normalizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>::normalize()")]
	public unsafe static Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* This)
	{
		int num = 0;
		unchecked
		{
			if (!BigInt_128ul_false_unsigned_long_is_zero.Invoke((Anon_izyfb7*)(&This->Mantissa)))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = Cpp_countl_zero_BigInt_128ul_false_unsigned_long.Invoke((Anon_izyfb7*)(&This->Mantissa));
				checked
				{
					This->Exponent -= num;
				}
				BigInt_128ul_false_unsigned_long_Operator_89tuvz.Invoke((Anon_izyfb7*)(&This->Mantissa), num);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return This;
		}
	}
}
